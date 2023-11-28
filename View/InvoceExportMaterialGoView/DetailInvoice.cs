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
    public partial class DetailInvoice : Form
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

        public DetailInvoice()
        {
            InitializeComponent();
            invoiceService = new InvoceService();
            materials = materialService.GetAll(false);

            btnSaveEdit.Hide();
            btnRefresh.Hide();
        }

        public DetailInvoice(List<Invoice> invoices, Invoice invoice)
        {
            this.invoices = invoices;
            this.currentIndexInvoice = invoices.FindIndex(inv => inv.idHoaDon == invoice.idHoaDon);
            this.invoice = invoice;
            invoiceService = new InvoceService();
            materialService = new MaterialService();
            InitializeComponent();
            materials = materialService.GetAll(false);
            if (invoice == null) return;
            loadData();


            btnSaveEdit.Hide();
            btnRefresh.Hide();
        }


        public void loadData()
        {

            if (invoice == null) return;
            dataGridViewDetailInvoice.Rows.Clear();
            invoiceDetails = invoiceService.GetInvoiceDetails(invoice.idHoaDon);
            invoiceDetailsChange = invoiceDetails.Select(invDT => invDT.Clone()).ToList();
            calculatorTotal(invoiceDetails);
            lbExportDepartment.Text = invoice.tenBoPhanXuat;

            foreach (InvoiceDetail invDT in invoiceDetails)
            {
                object[] rowData = new object[] { invDT.material.tenNguyenLieu, invDT.material.tenLoaiNguyenLieu,
                    invDT.material.sl, invDT.material.donVi, invDT.sl, invDT.tongTien, invDT.idChiTietHoaDon};
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

        public void calculatorTotal(List<InvoiceDetail> detailInvoices)
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
            if (e.RowIndex >= 0) // Ensure that the click is in a valid row
            {
                int col = e.ColumnIndex;
                int row = e.RowIndex;
                DataGridViewButtonCell inputNameMaterial = (DataGridViewButtonCell)dataGridViewDetailInvoice.Rows[row].Cells[0];
                DataGridViewTextBoxCell inputIdDetailInvoice = (DataGridViewTextBoxCell)dataGridViewDetailInvoice.Rows[row].Cells[6];
                Material material = materials.Find(m => m.tenNguyenLieu == inputNameMaterial.Value.ToString());

                switch (col)
                {
                    case 4:
                        {
                            if (material == null)
                            {
                                return;
                            }
                            DataGridViewTextBoxCell inputTonKho= (DataGridViewTextBoxCell)dataGridViewDetailInvoice.Rows[row].Cells[2];
                            DataGridViewTextBoxCell inputAmountCell = (DataGridViewTextBoxCell)dataGridViewDetailInvoice.Rows[row].Cells[4];
                            DataGridViewTextBoxCell inputTotalCell = (DataGridViewTextBoxCell)dataGridViewDetailInvoice.Rows[row].Cells[5];
                            InvoiceDetail invoiceDetail = null;

                            try
                            {
                                if (inputAmountCell == null || inputAmountCell.Value == null || inputTonKho.Value == null)
                                {
                                  //  MessageBox.Show("sl null, tong null");
                                    return;
                                }

                                if (inputIdDetailInvoice.Value == null)
                                {
                                    invoiceDetail = new InvoiceDetail();

                                    //hang moi duoc them

                                }
                                else
                                {
                                    invoiceDetail = invoiceDetailsChange.Find(m => m.idChiTietHoaDon == inputIdDetailInvoice.Value.ToString());

                                }

                                if (invoiceDetail == null)
                                {
                                    MessageBox.Show("chi tiet hoa don rong ");
                                    return;
                                }

                                //handle calculator
                                int amount;
                                if (int.TryParse(inputAmountCell.Value.ToString(), out amount))
                                {
                                    double total = amount * material.giaTien;
                                    inputTotalCell.Value = total;
                                    MessageBox.Show(inputTonKho.Value.ToString());
                                    int tonKho = int.Parse(inputTonKho.Value.ToString());
                                    if (amount > tonKho) {
                                        MessageBox.Show("Nguyên liệu hiện không còn đủ để cung cấp");

                                        return;
                                    }

                                    if (invoiceDetail.idChiTietHoaDon == null)
                                    {
                                        invoiceDetail = listNewInvoiceDetails.Find(invDt => invDt.idChiTietHoaDon == row.ToString());

                                        if (invoiceDetail == null)
                                        {
                                            invoiceDetail = new InvoiceDetail();
                                            invoiceDetail.idNguyenLieu = material.idNguyenLieu;
                                            invoiceDetail.material = material;
                                            invoiceDetail.idHoaDon = invoice.idHoaDon;
                                            invoiceDetail.sl = amount;
                                            invoiceDetail.tongTien = total;
                                            invoiceDetail.idChiTietHoaDon = row.ToString();
                                            listNewInvoiceDetails.Add(invoiceDetail);
                                        }
                                        else
                                        {
                                            invoiceDetail.sl = amount;
                                            invoiceDetail.idNguyenLieu = material.idNguyenLieu;
                                            invoiceDetail.tongTien = total;
                                            invoiceDetail.material = material;
                                            invoiceDetail.idHoaDon = invoice.idHoaDon;

                                            listNewInvoiceDetails = updateInvoiceDetail(listNewInvoiceDetails, invoiceDetail);
                                        }

                                    }
                                    else
                                    {
                                        invoiceDetail.sl = amount;
                                        invoiceDetail.idNguyenLieu = material.idNguyenLieu;
                                        invoiceDetail.tongTien = total;
                                        invoiceDetail.material = material;
                                        invoiceDetail.idHoaDon = invoice.idHoaDon;
                                        invoiceDetailsChange = updateInvoiceDetail(invoiceDetailsChange, invoiceDetail);
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Số lượng phải là số nguyên!");
                                }
                            }
                            catch (Exception ex)
                            {
                                // Handle any other exceptions that might occur during the parsing or calculation
                                MessageBox.Show("An error occurred hello: " + ex.Message);
                            }


                            break;
                        }
                }

                if (checkChanged())
                {
                    activeBtnAction();
                }
                else
                {
                    deActiveBtnAction();
                }
            }
        }

        public List<InvoiceDetail> updateInvoiceDetail(List<InvoiceDetail> listInvoiceDetails, InvoiceDetail invoiceDetail)
        {
            MessageBox.Show(invoiceDetail.ToString());
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
        }
        private void dataGridViewDetailInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            ChooseMaterial form = (ChooseMaterial)Application.OpenForms["ChooseMaterial"];

            if (form != null)
            {
                form.Close();
            }
            // Check if the clicked cell is in the 0th column (replace 0 with the actual column index)
            if (e.RowIndex >= 0) // Ensure that the click is in a valid row
            {
                int col = e.ColumnIndex;
                int row = e.RowIndex;
                DataGridViewButtonCell inputNameMaterial = (DataGridViewButtonCell)dataGridViewDetailInvoice.Rows[row].Cells[0];
                DataGridViewTextBoxCell inputIdChiTietHoaDon = (DataGridViewTextBoxCell)dataGridViewDetailInvoice.Rows[row].Cells[6];

                switch (col)
                {
                    case 0:
                        {
                            openModalChooseMaterial(row, col);

                            break;
                        }


                    //do co mot cot bi an
                    case 7:
                        {
                            if (inputNameMaterial.Value == null || inputIdChiTietHoaDon.Value == null)
                            {
                                dataGridViewDetailInvoice.Rows.RemoveAt(row);

                                return;
                            }

                            DialogResult result = MessageBox.Show("Bạn chắn chắn xóa hàng này?", "Yes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            Material material = materials.Find(m => m.tenNguyenLieu == inputNameMaterial.Value.ToString());
                            InvoiceDetail invoiceDetail = invoiceDetails.Find(m => m.idChiTietHoaDon == inputIdChiTietHoaDon.Value.ToString());

                            if (invoiceDetail == null)
                            {
                                MessageBox.Show("Chi tiet hoa don null");
                                return;
                            }

                            if (result == DialogResult.Yes)
                            {
                                invoiceDetailsChange = invoiceDetailsChange.Where(invDt => invDt.idChiTietHoaDon != invoiceDetail.idChiTietHoaDon).ToList();
                                dataGridViewDetailInvoice.Rows.RemoveAt(row);
                                listidChiTietHoaDonToRemove.Add(invoiceDetail);
                                activeBtnAction();
                            }
                            break;
                        }
                }
            }
        }

        public bool handleMaterialChoosed(Material material) {
            foreach (DataGridViewRow row in dataGridViewDetailInvoice.Rows)
            {
                if (row.Cells[0].Value == null) continue;
                // Access row properties or cells as needed
                string cellValue = row.Cells[0].Value.ToString();

                if (cellValue == material.tenNguyenLieu) return true;
            }

            return false;

        }



        public void handleLoadData(int rowSelect, Material material)
        {

            bool checkMaterialChoosed = handleMaterialChoosed(material);

            if(checkMaterialChoosed )
            {
                MessageBox.Show("Nguyên liệu đã được chọn vui lòng chọn nguyên liệu khác!");

                    return;
            }

            if (material == null) return;

            DataGridViewButtonCell tenNguyenLieu = dataGridViewDetailInvoice.Rows[rowSelect].Cells[0] as DataGridViewButtonCell;
            DataGridViewTextBoxCell tenLoaiNguyenLieu = dataGridViewDetailInvoice.Rows[rowSelect].Cells[1] as DataGridViewTextBoxCell;
            DataGridViewTextBoxCell soluong = dataGridViewDetailInvoice.Rows[rowSelect].Cells[2] as DataGridViewTextBoxCell;
            DataGridViewTextBoxCell soluongInvoice = dataGridViewDetailInvoice.Rows[rowSelect].Cells[4] as DataGridViewTextBoxCell;
            DataGridViewTextBoxCell tongTien = dataGridViewDetailInvoice.Rows[rowSelect].Cells[5] as DataGridViewTextBoxCell;
            DataGridViewTextBoxCell donVi = dataGridViewDetailInvoice.Rows[rowSelect].Cells[3] as DataGridViewTextBoxCell;

            if (tenNguyenLieu == null || tenLoaiNguyenLieu == null || soluong == null) return;


            tenNguyenLieu.Value = material.tenNguyenLieu;
            soluong.Value = material.sl;
            tenLoaiNguyenLieu.Value = material.tenLoaiNguyenLieu;
            soluongInvoice.Value = null;
            tongTien.Value = null;
            donVi.Value = material.donVi;

            /*handleCheckTotalValidForm(row, 3, material);*/

        }

        public void openModalChooseMaterial(int row, int col)
        {

            DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dataGridViewDetailInvoice.Rows[row].Cells[col];

            if (buttonCell == null) return;

            Rectangle cellBounds = dataGridViewDetailInvoice.GetCellDisplayRectangle(col, row, false);

            Point modalLocation = new Point(
                cellBounds.Left + buttonCell.ContentBounds.Left,
                cellBounds.Top + buttonCell.ContentBounds.Bottom
            );

            ChooseMaterial form = (ChooseMaterial)Application.OpenForms["ChooseMaterial"];

            if (form == null)
            {
                form = new ChooseMaterial(row, this);
            }
            else if (!(form is ChooseMaterial))
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
            bool checkRes = listidChiTietHoaDonToRemove.All(invoiceDt => invoiceService.RemoveDetailInvoice(invoiceDt));

            foreach (InvoiceDetail invoiceDetail in invoiceDetailsChange) {
                MessageBox.Show(invoiceDetail.ToString());
            }
            bool checkResUpdate = invoiceDetailsChange.All(invoiceDetail => invoiceService.UpdateDetailInvoceMaterial(invoiceDetail));

            bool checkResCreate = listNewInvoiceDetails.All(invoiceDetail => invoiceService.CreateDetailInvoceMaterial(invoiceDetail));

            MessageBox.Show((checkRes && checkResUpdate && checkResCreate) ? "Cập nhật hóa đơn thành công!" : "Cập nhật hóa đơn thất bại!");
        }


        private void btnAddRow_Click(object sender, EventArgs e)
        {
            dataGridViewDetailInvoice.Rows.Add();
            InvoiceDetail invoiceDetail = new InvoiceDetail();
            invoiceDetail.idChiTietHoaDon = listNewInvoiceDetails.Count.ToString();
        }
    }


}
