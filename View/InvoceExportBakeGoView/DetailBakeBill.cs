using FinalProject_QUANLYKHO.Models;
using FinalProject_QUANLYKHO.Service;
using FinalProject_QUANLYKHO.View.InvoceExportMaterialGoView;
using Syncfusion.Grouping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace FinalProject_QUANLYKHO.View.ImportMaterialView
{
    public partial class DetailBakeBill : Form
    {
        private Invoice invoice;
        private InvoceService invoiceService;
        private MaterialService materialService;
        private List<Invoice> invoices;
        private int currentIndexInvoice = 0;
        private double total = 0;
        private List<Material> materials = new List<Material>();
        List<InvoiceDetail> invoiceDetails = new List<InvoiceDetail>();
        List<InvoiceDetail> invoiceDetailsChange = new List<InvoiceDetail>();
        List<InvoiceDetail> listNewInvoiceDetails = new List<InvoiceDetail>();
        List<InvoiceDetail> listidChiTietHoaDonToRemove = new List<InvoiceDetail>();
        private List<InvoiceDetailBake> invoiceDetailBakes = new List<InvoiceDetailBake>();
        private InvoiceBakeService invoiceBakeService;
        private BakeService bakeService;
        private BakeTypeService bakeTypeService;
        InvoiceDetailBake invoiceDetailBake;
        List<Bake> bakes;
        private double totalInvoce = 0;
        private int totalAmount = 0;
        public DetailBakeBill()
        {
            InitializeComponent();
            invoiceService = new InvoceService();
            materials = materialService.GetAll(false);

            btnSaveEdit.Hide();
            btnRefresh.Hide();
        }

        public DetailBakeBill(List<Invoice> invoices, Invoice invoice)
        {
            this.invoices = invoices;
            this.currentIndexInvoice = invoices.FindIndex(inv => inv.idHoaDon == invoice.idHoaDon);
            this.invoice = invoice;
            invoiceService = new InvoceService();
            materialService = new MaterialService();
            invoiceBakeService = new InvoiceBakeService();
            bakeService = new BakeService();
            bakeTypeService = new BakeTypeService();
            bakes= new List<Bake>();
            invoiceDetailBake = new InvoiceDetailBake();
            InitializeComponent();
            materials = materialService.GetAll(false);
            bakes = bakeService.GetAll(false);
            if (invoice == null) return;
            loadData();


            btnSaveEdit.Hide();
            btnRefresh.Hide();
        }


        public void loadData()
        {

            if (invoice == null) return;
            dataGridViewDetailInvoice.Rows.Clear();
            invoiceDetailBakes = invoiceBakeService.GetAllInvoiceBakeExportByIdBill(invoice.idHoaDon);
            /*            invoiceDetailsChange = invoiceDetails.Select(invDT => invDT.Clone()).ToList();
            */
            calculatorTotal(invoiceDetailBakes);
            lbExportDepartment.Text = invoice.tenBoPhanXuat;

            foreach (InvoiceDetailBake invDT in invoiceDetailBakes)
            {
                Bake bake = bakeService.GetBakeById(invDT.idBanh);

                object[] rowData = new object[] { bake.tenBanh,bakeTypeService.GetNameTypeBakeById( bake.idLoaiBanh),
                    bake.sl, bake.donVi, invDT.sl, invDT.tongTien};
                dataGridViewDetailInvoice.Rows.Add(rowData);
            }
        }

        private void btnPrevInvoice_Click(object sender, EventArgs e)
        {
            if (currentIndexInvoice <= 0)
            {
                return;
            }

            currentIndexInvoice--;

            Invoice invoiceIndex = invoices[currentIndexInvoice];

            if (invoiceIndex == null) return;

            //loadData(invoiceIndex);

        }

        private void btnNextInvoice_Click(object sender, EventArgs e)
        {
            if (currentIndexInvoice >= invoices.Count - 1)
            {
                return;
            }

            currentIndexInvoice++;


            Invoice invoiceIndex = invoices[currentIndexInvoice];

            if (invoiceIndex == null) return;

            //loadData(invoiceIndex.idHoaDon);

        }

        private bool checkChanged()
        {
            bool checkChange = false; // Initialize to false, as you want to return false if there are no changes
            int i = 0;
            foreach (DataGridViewRow row in dataGridViewDetailInvoice.Rows)
            {
                if (!row.IsNewRow)
                {
                    string tenNguyenLieu = row.Cells[0].Value?.ToString();
                    int sl = Convert.ToInt32(row.Cells[4].Value);
                    double tongTien = Convert.ToDouble(row.Cells[5].Value);

                    if (i < invoiceDetails.Count)
                    {
                        InvoiceDetail invoiceDetail = invoiceDetails[i++];

                        // Compare the values
                        if (invoiceDetail != null &&
                            (tenNguyenLieu != invoiceDetail.material.tenNguyenLieu || sl != invoiceDetail.sl || tongTien != invoiceDetail.tongTien))
                        {
                            checkChange = true;
                            break; // Exit the loop as soon as a difference is found
                        }
                    }
                    else
                    {
                        checkChange = true;
                        break; // Exit the loop to avoid further iteration
                    }
                }
            }
            return checkChange;
        }

        public void calculatorTotal(List<InvoiceDetailBake> detailInvoices)
        {
            total = detailInvoices.Sum(detail => detail.tongTien);
            lbTotalInvoce.Text = total.ToString();
        }
        private void activeBtnAction()
        {
            btnSaveEdit.Show();
            btnRefresh.Show();
        }

        private void deActiveBtnAction()
        {
            btnSaveEdit.Hide();
            btnRefresh.Hide();
        }
        private void dataGridViewDetailInvoice_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            if (e.RowIndex < 0 || e.RowIndex >= dataGridView.Rows.Count) return;

            DataGridViewButtonCell tenBanh = dataGridView.Rows[e.RowIndex].Cells[0] as DataGridViewButtonCell;

            if (tenBanh == null) return;

            string selectedValue = (string)tenBanh.Value;

            Bake bake = bakes.Find(m => m.tenBanh == selectedValue);

            if (bake == null) return;

            DataGridViewTextBoxCell tenLoaiBanh = dataGridView.Rows[e.RowIndex].Cells[1] as DataGridViewTextBoxCell;
            DataGridViewTextBoxCell soLuong = dataGridView.Rows[e.RowIndex].Cells[2] as DataGridViewTextBoxCell;

            if (tenLoaiBanh == null || soLuong == null) return;

            tenLoaiBanh.Value = bake.idLoaiBanh;
            soLuong.Value = bake.sl;


            int col = e.ColumnIndex;
            int row = e.RowIndex;

            if (row < 0 || col < 0)
            {

                MessageBox.Show("Col and row is not valid!");
                return;
            };


            switch (col)
            {
                case 4:
                    {
                        handleCheckTotalValidForm(row, col, bake);
                        break;
                    }
            }
        }
        public void handleCheckTotalValidForm(int row, int col, Bake bake)
        {
            DataGridViewCell cell = dataGridViewDetailInvoice.Rows[row].Cells[col];

            if (cell.Value == null) return;
            string editedValue = (String)cell.Value;

            if (!int.TryParse(editedValue, out int intValue))
            {
                MessageBox.Show("Số lượng phải là số nguyên!");
                cell.Value = "";
                return;
            }

            int amount = int.Parse(editedValue);
            DataGridViewCell totalCell = dataGridViewDetailInvoice.Rows[row].Cells[5];
            if (amount > bake.sl)
            {
                MessageBox.Show("Tồn kho của nguyên liệu không đủ để nhập!");
                cell.Value = null;
                totalCell.Value = null;
            }else if (amount <=0)
            {
                cell.Value = null;
                totalCell.Value = null;
            }
            if (string.IsNullOrEmpty(editedValue))
            {
                cell.Value = null;
                totalCell.Value = null;
            }


            double totalBake = bake.giaTien * amount;
            if(totalBake > 0) 
            {
                totalCell.Value = totalBake;
            }
            else { totalCell.Value = null; }


            calculatorTotal();
        }
        public void calculatorTotal()
        {
            double total = 0;
            int totalAmountItem = 0;

            foreach (DataGridViewRow row in dataGridViewDetailInvoice.Rows)
            {
                if (row.Cells[0].Value == null) continue;

                string tenBanh = row.Cells[0].Value.ToString();
                Bake bake = bakes.Find(m => m.tenBanh == tenBanh);
                if (bake == null) continue;

                int amount = 0;
                if (row.Cells[4].Value == null)
                {
                    amount = 0;
                }
                else
                {
                    amount = int.Parse(row.Cells[4].Value.ToString());
                }

                totalAmountItem += amount;
                if (amount * bake.giaTien > 0)
                {
                    row.Cells[5].Value = (amount * bake.giaTien).ToString("N2") + "000 vnd";
                }
                else
                {
                    row.Cells[5].Value = null;
                }

                total += (double)amount * bake.giaTien;
            }

            lbTotalInvoce.Text = total.ToString("N2") + "000 vnd";
            totalInvoce = total;
            totalAmount = totalAmountItem;

        }
/*        public List<InvoiceDetail> updateInvoiceDetail(List<InvoiceDetail> listInvoiceDetails, InvoiceDetail invoiceDetail)
        {
            return listInvoiceDetails.Select(invDt =>
            {
                if (invDt.idChiTietHoaDon == invoiceDetail.idChiTietHoaDon)
                {
                    invDt.tongTien = invoiceDetail.tongTien;
                    invDt.sl = invoiceDetail.sl;
                    invDt.idNguyenLieu = invoiceDetail.idNguyenLieu;
                    invDt.material = invoiceDetail.material;
                    invDt.idHoaDon = invoice.idHoaDon;
                }
                return invDt;
            }).ToList();
        }*/
        private void dataGridViewDetailInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            ChooseBake form = (ChooseBake)Application.OpenForms["ChooseBake"];

            if (form != null)
            {
                form.Close();
            }
            // Check if the clicked cell is in the 0th column (replace 0 with the actual column index)
            if (e.RowIndex >= 0) // Ensure that the click is in a valid row
            {
                int col = e.ColumnIndex;
                int row = e.RowIndex;
                DataGridViewButtonCell inputNameBanh = (DataGridViewButtonCell)dataGridViewDetailInvoice.Rows[row].Cells[0];

                switch (col)
                {
                    case 0:
                        {
                            openModalChooseBake(row, col);
                            activeBtnAction();

                            break;
                        }


                    //do co mot cot bi an
                    case 6:
                        {
                            if (inputNameBanh.Value == null)
                            {
                                dataGridViewDetailInvoice.Rows.RemoveAt(row);

                                return;
                            }

                            DialogResult result = MessageBox.Show("Bạn chắn chắn xóa hàng này?", "Yes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            Bake bake = bakes.Find(m => m.tenBanh == inputNameBanh.Value.ToString());


                            if (result == DialogResult.Yes)
                            {
                                dataGridViewDetailInvoice.Rows.RemoveAt(row);
                                activeBtnAction();
                            }
                            break;
                        }
                }
            }
        }

        public bool handleBakeChoosed(Bake bake)
        {
            foreach (DataGridViewRow row in dataGridViewDetailInvoice.Rows)
            {
                if (row.Cells[0].Value == null) continue;
                // Access row properties or cells as needed
                string cellValue = row.Cells[0].Value.ToString();

                if (cellValue == bake.tenBanh) return true;
            }

            return false;

        }



        public void handleLoadData(int rowSelect, Bake bake)
        {

            bool checkBakeChoosed = handleBakeChoosed(bake);

            if (checkBakeChoosed)
            {
                MessageBox.Show("Bánh đã được chọn vui lòng chọn Bánh khác!");

                return;
            }

            if (bake == null) return;

            DataGridViewButtonCell tenBanh = dataGridViewDetailInvoice.Rows[rowSelect].Cells[0] as DataGridViewButtonCell;
            DataGridViewTextBoxCell tenLoaiBanh = dataGridViewDetailInvoice.Rows[rowSelect].Cells[1] as DataGridViewTextBoxCell;
            DataGridViewTextBoxCell soluong = dataGridViewDetailInvoice.Rows[rowSelect].Cells[2] as DataGridViewTextBoxCell;
            DataGridViewTextBoxCell soluongInvoice = dataGridViewDetailInvoice.Rows[rowSelect].Cells[4] as DataGridViewTextBoxCell;
            DataGridViewTextBoxCell tongTien = dataGridViewDetailInvoice.Rows[rowSelect].Cells[5] as DataGridViewTextBoxCell;
            DataGridViewTextBoxCell donVi = dataGridViewDetailInvoice.Rows[rowSelect].Cells[3] as DataGridViewTextBoxCell;

            if (tenBanh == null || tenLoaiBanh == null || soluong == null) return;


            tenBanh.Value = bake.tenBanh;
            tenLoaiBanh.Value = bake.idLoaiBanh;

            soluong.Value = bake.sl;
            soluongInvoice.Value = null;
            tongTien.Value = null;
            donVi.Value = bake.donVi;

            handleCheckTotalValidForm(rowSelect, 4, bake);

        }

        public void openModalChooseBake(int row, int col)
        {

            DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dataGridViewDetailInvoice.Rows[row].Cells[col];

            if (buttonCell == null) return;

            Rectangle cellBounds = dataGridViewDetailInvoice.GetCellDisplayRectangle(col, row, false);

            Point modalLocation = new Point(
                cellBounds.Left + buttonCell.ContentBounds.Left,
                cellBounds.Top + buttonCell.ContentBounds.Bottom
            );

            ChooseBake form = (ChooseBake)Application.OpenForms["ChooseBake"];

            if (form == null)
            {
                form = new ChooseBake(row, this);
            }
            else if (!(form is ChooseBake))
            {
                return;
            }

            form.setFormParent(this);
            form.setRowSelect(row);

            int taskbarHeight = Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Height;

            // Calculate available space above and below the button cell
            int spaceAbove = modalLocation.Y;
            int spaceBelow = Screen.PrimaryScreen.Bounds.Height - taskbarHeight - modalLocation.Y;

            // Check if there is more space above or below and adjust the modalLocation accordingly
            if (spaceAbove > spaceBelow && spaceAbove >= form.Height)
            {
                modalLocation.Y -= form.Height;
            }
            else if (spaceBelow >= form.Height)
            {
                modalLocation.Y += buttonCell.ContentBounds.Height;
            }

            form.TopMost = true;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = dataGridViewDetailInvoice.PointToScreen(modalLocation);
            form.Show();


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
            deActiveBtnAction();
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            foreach(InvoiceDetailBake invoiceDetailBake in invoiceDetailBakes) 
            {
                invoiceBakeService.DeleteDetailInvoiceExportBakeGo(invoice.idHoaDon, invoiceDetailBake.idBanh);
            }
            bakes = bakeService.GetAll(false);
            bool checkErr = true;
            foreach (DataGridViewRow row in dataGridViewDetailInvoice.Rows)
            {
                if (row.Cells[0].Value == null) return;

                string tenBanh = row.Cells[0].Value.ToString();
                Bake bake = bakes.Find(m => m.tenBanh == tenBanh);

                if (bake == null) return;

                InvoiceDetailBake invoceDetail = new InvoiceDetailBake();

                invoceDetail.idHoaDon = invoice.idHoaDon;
                invoceDetail.idBanh = bake.idBanh;

                if (row.Cells[4].Value == null)
                {
                    break;
                }
                int sl = int.Parse(row.Cells[4].Value.ToString());

                invoceDetail.sl = sl;
                invoceDetail.tongTien = bake.giaTien * sl;

                if (row.Cells[4].Value == null) break;

                //MessageBox.Show(row.Cells[4].Value.ToString());
                //invoceDetail.tongTien = double.Parse(row.Cells[4].Value.ToString());

                checkErr = invoiceBakeService.CreateDetailInvoiceBake(invoceDetail) && checkErr;
                bake.sl -= sl;
                bakeService.Update(bake);

            }

            if (checkErr == false)
            {
                MessageBox.Show("Cập nhập hóa đơn thất bại!");
            }
            else
            {
                loadData();
                deActiveBtnAction();
                MessageBox.Show("Cập nhập đơn thành công!");
                ManagerExportBakeGo form = (ManagerExportBakeGo)Application.OpenForms["ManagerExportBakeGo"];

                if (form != null)
                {
                    form.LoadDataIntoDataGridView();

                }
            }

        }


        private void btnAddRow_Click(object sender, EventArgs e)
        {
            dataGridViewDetailInvoice.Rows.Add();
            InvoiceDetail invoiceDetail = new InvoiceDetail();
            invoiceDetail.idChiTietHoaDon = listNewInvoiceDetails.Count.ToString();
        }
    }


}
