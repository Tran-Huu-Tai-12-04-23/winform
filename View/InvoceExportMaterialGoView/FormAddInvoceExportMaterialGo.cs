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
    public partial class FormAddInvoceExportMaterialGo : Form
    {
        private InvoiceFunctionCommonService invoiceFunctionCommonService;
        private MaterialService materialService;
        private InvoceService invoceService;
        private List<Material> materials;
        private double totalInvoce = 0;
        private int totalAmount = 0;
        private List<Object> selectedValues = new List<Object>();
        public FormAddInvoceExportMaterialGo()
        {
            invoiceFunctionCommonService = new InvoiceFunctionCommonService();
            materialService = new MaterialService();
            invoceService = new InvoceService();
            InitializeComponent();

            materials = materialService.GetAll(false);

            renderExportDepartment();
            lbTotalInvoce.Text = totalInvoce.ToString() + "000 vnd";

            FormClosed += handleFormClose;
            dataGridCreateInvoice.Rows.Add();
        }

        private void handleFormClose(object sender, FormClosedEventArgs e)
        {
            ChooseMaterial form = (ChooseMaterial)Application.OpenForms["ChooseMaterial"];
            if (form == null) return;
            if (form != null && !form.IsDisposed)
            {
                form.Close();
            }
        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            if (e.RowIndex < 0 || e.RowIndex >= dataGridView.Rows.Count) return;

            DataGridViewButtonCell tenNguyenLieu = dataGridView.Rows[e.RowIndex].Cells[0] as DataGridViewButtonCell;

            if (tenNguyenLieu == null) return;

            string selectedValue = (string)tenNguyenLieu.Value;

            Material material = materials.Find(m => m.tenNguyenLieu == selectedValue);

            if (material == null) return;

            DataGridViewTextBoxCell tenLoaiNguyenLieu = dataGridView.Rows[e.RowIndex].Cells[2] as DataGridViewTextBoxCell;
            DataGridViewTextBoxCell soLuong = dataGridView.Rows[e.RowIndex].Cells[1] as DataGridViewTextBoxCell;

            if (tenLoaiNguyenLieu == null || soLuong == null) return;

            tenLoaiNguyenLieu.Value = material.tenLoaiNguyenLieu;
            soLuong.Value = material.sl;


            int col = e.ColumnIndex;
            int row = e.RowIndex;

            if (row < 0 || col < 0)
            {

                MessageBox.Show("Col and row is not valid!");
                return;
            };


            switch (col)
            {
                case 3:
                    {
                        handleCheckTotalValidForm(row, col, material);
                        break;
                    }
            }


        }

        public void handleCheckTotalValidForm(int row, int col, Material material)
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
            if (amount > material.sl)
            {
                MessageBox.Show("Tồn kho của nguyên liệu không đủ để nhập!");
                cell.Value = null;
                totalCell.Value = null;
                return;
            }


            double totalMaterial = material.giaTien * amount;

            totalCell.Value = totalMaterial;

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

                string tenNguyenLieu = row.Cells[0].Value.ToString();
                Material material = materials.Find(m => m.tenNguyenLieu == tenNguyenLieu);

                if (material == null) continue;

                if (row.Cells[3].Value != null)
                {
                    int amount = int.Parse(row.Cells[3].Value.ToString());
                    totalAmountItem += amount;

                    row.Cells[4].Value = (amount * material.giaTien).ToString("N2") + "000 vnd";

                    total += (double)amount * material.giaTien;
                }


            }

            lbTotalInvoce.Text = total.ToString("N2") + "000 vnd";
            totalInvoce = total;
            totalAmount = totalAmountItem;

        }


        public void renderExportDepartment()
        {
            List<ExportDepartment> exportDepartMents = invoiceFunctionCommonService.GetAllExportDepartment();

            listExportDepartMent.DataSource = exportDepartMents;
            listExportDepartMent.DisplayMember = "tenBoPhanXuat"; // Display the 'Name' property of the Item class
            listExportDepartMent.ValueMember = "idBoPhanXuat";     // Use the 'Id' property as the value

        }

        private void buttonCustom2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void handle_keypress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is not a digit
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) // 8 is the ASCII code for backspace
            {
                e.Handled = true;
            }
        }
        public bool handleMaterialChoosed(Material material)
        {
            foreach (DataGridViewRow row in dataGridCreateInvoice.Rows)
            {
                if (row.Cells[0].Value == null) continue;
                // Access row properties or cells as needed
                string cellValue = row.Cells[0].Value.ToString();
                MessageBox.Show(cellValue);

                if (cellValue == material.tenNguyenLieu)
                {

                };
            }

            return false;

        }

        private void createInvoce_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ChooseMaterial form = (ChooseMaterial)Application.OpenForms["ChooseMaterial"];

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
                            openModalChooseMaterial(e.RowIndex, col);
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

        public void openModalChooseMaterial(int row, int col)
        {
            DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dataGridCreateInvoice.Rows[row].Cells[col];

            if (buttonCell == null) return;

            Rectangle cellBounds = dataGridCreateInvoice.GetCellDisplayRectangle(col, row, false);

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
            form.Location = dataGridCreateInvoice.PointToScreen(modalLocation);
            form.Show();
        }


        public void handleLoadData(int row, Material material)
        {
            this.materials = materialService.GetAll(false);
            bool checkMaterialChoosed = handleMaterialChoosed(material);

            if (checkMaterialChoosed)
            {
                MessageBox.Show("Nguyên liệu đã được chọn vui lòng chọn nguyên liệu khác!");

                return;
            }


            if (material == null) return;

            DataGridViewButtonCell tenNguyenLieu = dataGridCreateInvoice.Rows[row].Cells[0] as DataGridViewButtonCell;
            DataGridViewTextBoxCell soluong = dataGridCreateInvoice.Rows[row].Cells[1] as DataGridViewTextBoxCell;
            DataGridViewTextBoxCell tenLoaiNguyenLieu = dataGridCreateInvoice.Rows[row].Cells[2] as DataGridViewTextBoxCell;

            if (tenNguyenLieu == null || tenLoaiNguyenLieu == null || soluong == null) return;

            tenNguyenLieu.Value = material.tenNguyenLieu;
            soluong.Value = material.sl;
            tenLoaiNguyenLieu.Value = material.tenLoaiNguyenLieu;

            handleCheckTotalValidForm(row, 3, material);

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice();
            invoice.idBoPhanXuat = listExportDepartMent.SelectedValue.ToString();
            invoice.ngayXuat = exportDate.Value;
            invoice.idTaiKhoan = Properties.Settings.Default.idTaiKhoan;
            invoice.soLuong = totalAmount;
            invoice.tongTien = totalInvoce;
            invoice.idLoaiHoaDon = ContanstApp.XuatNguyenLieuHuy;

            if (invoice.soLuong <= 0 || invoice.tongTien <= 0)
            {
                return;
            }
            Invoice newInvoce = invoceService.CreateInvoceMaterial(invoice);

            if (newInvoce == null)
            {
                MessageBox.Show("Tạo hóa đơn thất bại!");
                return;
            }



            bool checkErr = true;
            foreach (DataGridViewRow row in dataGridCreateInvoice.Rows)
            {
                if (row.Cells[0].Value == null) return;

                string tenNguyenLieu = row.Cells[0].Value.ToString();
                Material material = materials.Find(m => m.tenNguyenLieu == tenNguyenLieu);

                if (material == null) return;

                InvoiceDetail invoceDetail = new InvoiceDetail();

                invoceDetail.idHoaDon = newInvoce.idHoaDon;
                invoceDetail.idNguyenLieu = material.idNguyenLieu;

                if (row.Cells[3].Value == null)
                {
                    break;
                }
                int sl = int.Parse(row.Cells[3].Value.ToString());

                invoceDetail.sl = sl;
                invoceDetail.tongTien = material.giaTien * sl;

                if (row.Cells[4].Value == null) break;

                //MessageBox.Show(row.Cells[4].Value.ToString());
                //invoceDetail.tongTien = double.Parse(row.Cells[4].Value.ToString());

                checkErr = invoceService.CreateDetailInvoceMaterial(invoceDetail) && checkErr;

            }

            if (checkErr == false)
            {
                MessageBox.Show("Tạo hóa đơn thất bại!");
            }
            else
            {
                MessageBox.Show("Tạo hóa đơn thành công!");
                ManagerExportMaterialGo form = (ManagerExportMaterialGo)Application.OpenForms["ManagerExportMaterialGo"];

                if (form != null)
                {
                    form.LoadDataIntoDataGridView();

                }
                clearValueInDataGrid();
            }
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
    }
}
