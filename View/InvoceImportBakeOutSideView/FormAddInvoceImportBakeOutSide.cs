using FinalProject_QUANLYKHO.Contanst;
using FinalProject_QUANLYKHO.Models;
using FinalProject_QUANLYKHO.Service;
using FinalProject_QUANLYKHO.View.CustomerView;
using FinalProject_QUANLYKHO.View.InvoceView;
using FinalProject_QUANLYKHO.View.InvoceExportMaterialGoView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using FinalProject_QUANLYKHO.View.ImportMaterialView;
using System.Reflection;

namespace FinalProject_QUANLYKHO.View.InvoceExportMaterialGoView
{
    public partial class FormAddInvoceImportBakeOutSide : Form
    {
        private InvoiceFunctionCommonService invoiceFunctionCommonService;
        private InvoceService invoceService;
        private InvoiceBakeService invoiceBakeService;
        private BakeService bakeService;
        private List<Material> materials;
        private List<Bake> bakes;

        private double totalInvoce = 0;
        private int totalAmount = 0;
        private List<Object> selectedValues = new List<Object>();
        CustomerService customerService;
        public FormAddInvoceImportBakeOutSide()
        {
            invoceService = new InvoceService();
            bakeService = new BakeService();
            invoiceBakeService = new InvoiceBakeService();
            invoiceFunctionCommonService = new InvoiceFunctionCommonService();
            customerService = new CustomerService();
            InitializeComponent();
            bakes = bakeService.GetAll(false);
            renderExportDepartment();
            lbTotalInvoce.Text = totalInvoce.ToString() + "000 vnd";
            FormClosed += handleFormClose;
            dataGridCreateInvoice.Rows.Add();
        }

        private void handleFormClose(object sender, FormClosedEventArgs e)
        {
            ChooseBake form = (ChooseBake)Application.OpenForms["ChooseBake"];
            if (form == null) return;
            if (form != null && !form.IsDisposed)
            {
                form.Close();
            }
        }


        private void dataGridCreateInvoice_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            if (e.RowIndex < 0 || e.RowIndex >= dataGridView.Rows.Count) return;

            DataGridViewButtonCell tenBanh = dataGridView.Rows[e.RowIndex].Cells[0] as DataGridViewButtonCell;

            if (tenBanh == null) return;

            string selectedValue = (string)tenBanh.Value;

            Bake bake = bakes.Find(m => m.tenBanh == selectedValue);

            if (bake == null) return;

            DataGridViewTextBoxCell tenLoaiBanh = dataGridView.Rows[e.RowIndex].Cells[2] as DataGridViewTextBoxCell;
            DataGridViewTextBoxCell soLuong = dataGridView.Rows[e.RowIndex].Cells[1] as DataGridViewTextBoxCell;

            if (tenLoaiBanh == null || soLuong == null) return;

            tenLoaiBanh.Value = bake.idLoaiBanh;
            soLuong.Value = bake.sl;


            int col = e.ColumnIndex;
            int row = e.RowIndex;

            if (row < 0 || col < 0)
            {

                MessageBox.Show("Col and row is not valid!");
                return;
            }


            switch (col)
            {
                case 3:
                    {
                        handleCheckTotalValidForm(row, col, bake);
                        break;
                    }
            }


        }

        public void handleCheckTotalValidForm(int row, int col, Bake bake)
        {
            DataGridViewCell cell = dataGridCreateInvoice.Rows[row].Cells[col];

            if (cell.Value == null) return;
            string editedValue = (String)cell.Value;

            if (!int.TryParse(editedValue, out int intValue))
            {
                MessageBox.Show("Số lượng phải là số nguyên!");
                cell.Value = "";
                return;
            }

            int amount = int.Parse(editedValue);
            DataGridViewCell totalCell = dataGridCreateInvoice.Rows[row].Cells[4];
            if (amount <= 0)
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
            if (totalBake > 0)
            {
                totalCell.Value = totalBake;
            }
            else { totalCell.Value = null; }


            calculatorTotal();
        }

        public void reRenderRow(int row)
        {
            if (row >= dataGridCreateInvoice.Rows.Count)
            {
                MessageBox.Show("Row nho hon total row");
                return;
            }
            DataGridViewButtonCell tenNguyenLieu = dataGridCreateInvoice.Rows[row].Cells[0] as DataGridViewButtonCell;

            if (tenNguyenLieu == null) return;

            string selectedValue = (string)tenNguyenLieu.Value;

            Material material = materials.Find(m => m.tenNguyenLieu == selectedValue);

            if (material == null) return;

            DataGridViewTextBoxCell textBoxCell = dataGridCreateInvoice.Rows[row].Cells[2] as DataGridViewTextBoxCell;
            DataGridViewTextBoxCell textBoxCellTon = dataGridCreateInvoice.Rows[row].Cells[1] as DataGridViewTextBoxCell;


        }

        public void calculatorTotal()
        {
            double total = 0;
            int totalAmountItem = 0;

            foreach (DataGridViewRow row in dataGridCreateInvoice.Rows)
            {
                if (row.Cells[0].Value == null) continue;

                string tenBanh = row.Cells[0].Value.ToString();
                Bake bake = bakes.Find(m => m.tenBanh == tenBanh);
                if (bake == null) continue;

                int amount = 0;
                if (row.Cells[3].Value == null)
                {
                    amount = 0;
                }
                else
                {
                    amount = int.Parse(row.Cells[3].Value.ToString());
                }

                totalAmountItem += amount;
                if (amount * bake.giaTien > 0)
                {
                    row.Cells[4].Value = (amount * bake.giaTien).ToString("N2") + "000 vnd";
                }
                else
                {
                    row.Cells[4].Value = null;
                }

                total += (double)amount * bake.giaTien;
            }

            lbTotalInvoce.Text = total.ToString("N2") + "000 vnd";
            totalInvoce = total;
            totalAmount = totalAmountItem;

        }


        public void renderExportDepartment()
        {
            List<Customer> customers = customerService.GetAllDeActive(0, 1000);

            listImportCustomer.DataSource = customers;
            listImportCustomer.DisplayMember = "tenKhachHang"; // Display the 'Name' property of the Item class
            listImportCustomer.ValueMember = "maKhachHang";


        }


        private void handle_keypress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is not a digit
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) // 8 is the ASCII code for backspace
            {
                e.Handled = true;
            }
        }
        public bool handleBakeChoosed(Bake bake)
        {
            foreach (DataGridViewRow row in dataGridCreateInvoice.Rows)
            {
                if (row.Cells[0].Value == null) continue;
                // Access row properties or cells as needed
                string cellValue = row.Cells[0].Value.ToString();
                if (cellValue == bake.tenBanh)
                {
                    return true;
                }
            }

            return false;

        }

        private void createInvoce_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ChooseBake form = (ChooseBake)Application.OpenForms["ChooseBake"];

            if (form != null)
            {
                form.Close();
            }
            if (e.RowIndex >= 0)
            {

                int col = e.ColumnIndex;

                switch (col)
                {
                    case 0:
                        {
                            openModalChooseBake(e.RowIndex, col);
                            break;
                        }

                    case 5:
                        {

                            try
                            {
                                if (e.RowIndex >= 0 && e.RowIndex < dataGridCreateInvoice.Rows.Count)
                                {
                                    if (dataGridCreateInvoice.IsCurrentCellInEditMode)
                                    {
                                        dataGridCreateInvoice.CancelEdit();
                                    }
                                    dataGridCreateInvoice.Rows.RemoveAt(e.RowIndex);
                                }
                            }
                            catch (Exception ex)
                            {
                                //MessageBox.Show("Error removing row: " + ex.Message);
                            }
                            break;
                        }
                }
            }


        }

        public void openModalChooseBake(int row, int col)
        {
            DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dataGridCreateInvoice.Rows[row].Cells[col];

            if (buttonCell == null) return;

            Rectangle cellBounds = dataGridCreateInvoice.GetCellDisplayRectangle(col, row, false);

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
            form.Location = dataGridCreateInvoice.PointToScreen(modalLocation);
            form.Show();
        }


        public void handleLoadData(int row, Bake bake)
        {
            this.bakes = bakeService.GetAll(false);
            bool checkBakeChoosed = handleBakeChoosed(bake);

            if (checkBakeChoosed)
            {
                MessageBox.Show("Bánh đã được chọn vui lòng chọn bánh khác!");

                return;
            }


            if (bake == null) return;

            DataGridViewButtonCell tenBanh = dataGridCreateInvoice.Rows[row].Cells[0] as DataGridViewButtonCell;
            DataGridViewTextBoxCell soluong = dataGridCreateInvoice.Rows[row].Cells[1] as DataGridViewTextBoxCell;
            DataGridViewTextBoxCell tenLoaiBanh = dataGridCreateInvoice.Rows[row].Cells[2] as DataGridViewTextBoxCell;

            if (tenBanh == null || tenBanh == null || soluong == null) return;

            tenBanh.Value = bake.tenBanh;
            soluong.Value = bake.sl;
            tenLoaiBanh.Value = bake.idLoaiBanh;

            handleCheckTotalValidForm(row, 3, bake);

        }

        public void clearValueInDataGrid()
        {
            dataGridCreateInvoice.Rows.Clear();
            dataGridCreateInvoice.Rows.Add();
            lbTotalInvoce.Text = "0 vnd";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dataGridCreateInvoice.Rows.Add();
        }

        private void listExportDepartMent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exportDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbTotalInvoce_Click(object sender, EventArgs e)
        {

        }

        private void dataGridCreateInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ChooseBake form = (ChooseBake)Application.OpenForms["ChooseBake"];

            if (form != null)
            {
                form.Close();
            }
            if (e.RowIndex >= 0)
            {

                int col = e.ColumnIndex;

                switch (col)
                {
                    case 0:
                        {
                            openModalChooseBake(e.RowIndex, col);
                            break;
                        }

                    case 5:
                        {

                            try
                            {
                                if (e.RowIndex >= 0 && e.RowIndex < dataGridCreateInvoice.Rows.Count)
                                {
                                    if (dataGridCreateInvoice.IsCurrentCellInEditMode)
                                    {
                                        dataGridCreateInvoice.CancelEdit();
                                    }
                                    dataGridCreateInvoice.Rows.RemoveAt(e.RowIndex);
                                }
                            }
                            catch (Exception ex)
                            {
                                //MessageBox.Show("Error removing row: " + ex.Message);
                            }
                            break;
                        }
                }
            }
        }

        private void btnSelect_Click_1(object sender, EventArgs e)
        {
            dataGridCreateInvoice.Rows.Add();
        }

        private void listExportDepartMent_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice();
            invoice.ngayXuat = exportDate.Value;
            invoice.idBoPhanXuat = "bpx-03";
            invoice.idTaiKhoan = Properties.Settings.Default.idTaiKhoan;
            invoice.soLuong = totalAmount;
            invoice.tongTien = totalInvoce;
            invoice.idLoaiHoaDon = ContanstApp.NhapBanhMuaNgoai;

            if (invoice.soLuong <= 0 || invoice.tongTien <= 0)
            {
                return;
            }
            Invoice newInvoce = invoceService.CreateInvoiceBake(invoice);

            if (newInvoce == null)
            {
                MessageBox.Show("Tạo hóa đơn thất bại!");
                return;
            }

            object selectedItem = listImportCustomer.SelectedItem;

            Customer selected = (Customer)selectedItem;

            bool checkErr = true;
            foreach (DataGridViewRow row in dataGridCreateInvoice.Rows)
            {
                if (row.Cells[0].Value == null) return;

                string tenBanh = row.Cells[0].Value.ToString();
                Bake bake = bakes.Find(m => m.tenBanh == tenBanh);

                if (bake == null) return;


                InvoiceDetailBakeImport invoceDetail = new InvoiceDetailBakeImport();

                invoceDetail.idHoaDon = newInvoce.idHoaDon;
                invoceDetail.idBanh = bake.idBanh;
                invoceDetail.idKhachHang = selected.maKhachHang;
                if (row.Cells[3].Value == null)
                {
                    break;
                }
                int sl = int.Parse(row.Cells[3].Value.ToString());

                invoceDetail.sl = sl;
                invoceDetail.tongTien = bake.giaTien * sl;

                if (row.Cells[4].Value == null) break;

                checkErr = invoiceBakeService.CreateDetailInvoiceBakeImportOut(invoceDetail) && checkErr;
                bake.sl += sl;
                bakeService.Update(bake);

            }

            if (checkErr == false)
            {
                MessageBox.Show("Tạo hóa đơn thất bại!");
            }
            else
            {
                MessageBox.Show("Tạo hóa đơn thành công!");
                ManagerImportBakeOutSide form = (ManagerImportBakeOutSide)Application.OpenForms["ManagerImportBakeOutSide"];

                if (form != null)
                {
                    form.LoadDataIntoDataGridView();
                    

                }
                clearValueInDataGrid();
            }
        }
    }
}
