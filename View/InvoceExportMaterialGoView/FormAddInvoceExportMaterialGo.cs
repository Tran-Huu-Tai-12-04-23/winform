using FinalProject_QUANLYKHO.Contanst;
using FinalProject_QUANLYKHO.Models;
using FinalProject_QUANLYKHO.Service;
using FinalProject_QUANLYKHO.View.CustomerView;
using FinalProject_QUANLYKHO.View.ImportMaterialView;
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
        private List<string> selectedValues= new List<string>();
        public FormAddInvoceExportMaterialGo()
        {
            invoiceFunctionCommonService = new InvoiceFunctionCommonService();
            materialService = new MaterialService();
            invoceService = new InvoceService();
            InitializeComponent();
            materials = materialService.GetAll(false);
            renderExportDepartment();
            renderComboboxIntoGridView(0);

            lbTotalInvoce.Text = totalInvoce.ToString() + "000 vnd";

            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.Name = "ComboBoxColumn";
            comboBoxColumn.Items.AddRange("Option 1", "Option 2", "Option 3");
            createInvoce.Columns.Add(comboBoxColumn);

            // Gắn sự kiện EditingControlShowing để theo dõi ComboBox được hiển thị
            createInvoce.EditingControlShowing += DataGridView1_EditingControlShowing;
        }

        private void DataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is System.Windows.Forms.ComboBox comboBox)
            {
                // Gắn sự kiện SelectedIndexChanged cho ComboBox
                comboBox.SelectedIndexChanged -= ComboBox_SelectedIndexChanged;
                comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.ComboBox comboBox && createInvoce.CurrentCell != null)
            {
                // Lấy giá trị được chọn
                object selectedValue = comboBox.SelectedItem;

                // Kiểm tra xem giá trị đã được chọn hay chưa
                if (selectedValues.Contains(selectedValue))
                {
                    // Nếu giá trị đã được chọn, hủy chọn và hiển thị thông báo
                    comboBox.SelectedIndex = -1;
                    MessageBox.Show("Giá trị này đã được chọn cho hàng khác.");
                }
                else
                {
                    MessageBox.Show(selectedValue.ToString());
                    // Nếu giá trị chưa được chọn, lưu giá trị vào danh sách
                    selectedValues.Add(selectedValue.ToString());
                }
            }
        }

        private void renderComboboxIntoGridView(int rowIndex)
        {
            // Assuming column 0 is a DataGridViewComboBoxColumn (replace with actual column index)
            DataGridViewComboBoxCell comboBoxCell1 = createInvoce.Rows[rowIndex].Cells[0] as DataGridViewComboBoxCell;

            if (comboBoxCell1 != null && materials != null)
            {
                materials = materialService.GetAll(false);

                if (materials.Count > 0)
                {
                    comboBoxCell1.DataSource = materials;
                    comboBoxCell1.DisplayMember = "tenNguyenLieu";
                    comboBoxCell1.ValueMember = "idNguyenLieu";
                    comboBoxCell1.Value = materials[0].idNguyenLieu;
                }
            }
        }

        public void renderComboboxIntoGridViewForAllRows()
        {
            for (int rowIndex = 0; rowIndex < createInvoce.Rows.Count; rowIndex++)
            {
                renderComboboxIntoGridView(rowIndex);
            }
        }

        private void createInvoce_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            renderComboboxIntoGridView(e.RowIndex);
        }




        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender; // Assuming dataGridView1 is the correct instance

            int rowIndex = e.RowIndex;

            if (rowIndex < 0 || rowIndex >= dataGridView.Rows.Count) return;

            DataGridViewComboBoxCell comboBoxCell1 = dataGridView.Rows[rowIndex].Cells[0] as DataGridViewComboBoxCell;

            if (comboBoxCell1 == null) return;

            Material material = new Material();

            string selectedValue = comboBoxCell1.Value?.ToString(); 
            material = materials.Find(m => m.idNguyenLieu == selectedValue);

            if (material == null) return;

            DataGridViewTextBoxCell textBoxCell = dataGridView.Rows[rowIndex].Cells[2] as DataGridViewTextBoxCell;

            DataGridViewTextBoxCell textBoxCellTon = dataGridView.Rows[rowIndex].Cells[1] as DataGridViewTextBoxCell;

            if (textBoxCell == null || textBoxCellTon == null) return;

            textBoxCell.Value = material.tenLoaiNguyenLieu;
            textBoxCellTon.Value = material.sl;


            if (e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                // Assuming yourTextBoxColumnIndex is the index of the TextBox column
                DataGridViewCell cell = createInvoce.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (cell.Value == null) return;
                string editedValue = cell.Value.ToString();
                if (!int.TryParse(editedValue, out int intValue))
                {
                    MessageBox.Show("Số lượng phải là số nguyên!");
                    cell.Value = "";

                    return;
                }

                int amount = int.Parse(editedValue);

                if (amount > material.sl)
                {
                    MessageBox.Show("Tồn kho của nguyên liệu không đủ để nhâp!");
                    cell.Value = null;
                    return;
                }
                DataGridViewCell totalcell = createInvoce.Rows[e.RowIndex].Cells[4];

                double totalMaterial = (double)(material.giaTien * amount);
                totalcell.Value = totalMaterial;

                CalculatorTotal();

            }

        }

        public void CalculatorTotal()
        {
            double total = 0;
            int totalAmountItem = 0;

            foreach (DataGridViewRow row in createInvoce.Rows)
            {
                if (row.Cells[0].Value == null) return;

                string idNguyenLieu = row.Cells[0].Value.ToString();
                Material material = materials.Find(m => m.idNguyenLieu == idNguyenLieu);

                if (material == null) return;

                if (row.Cells[3].Value != null && row.Cells[3].Value != null)
                {
                    totalAmountItem += int.Parse(row.Cells[3].Value.ToString());
                    row.Cells[4].Value = double.Parse((int.Parse(row.Cells[3].Value.ToString()) * material.giaTien).ToString()).ToString();
                }


                if (row.Cells[4].Value != null && double.TryParse(row.Cells[4].Value.ToString(), out double cellValue))
                {
                    // If the cell contains a valid numeric value, add it to the total
                    total += cellValue;
                }
            }

            lbTotalInvoce.Text = Math.Round(total, 2).ToString("N2") + "000 vnd";
            totalInvoce = Math.Round(total, 2);
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


        private void createInvoce_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //chlick col remove action
            if (e.ColumnIndex == 5)
            {
                if (e.RowIndex >= 0 && e.RowIndex < createInvoce.Rows.Count)
                {
                    createInvoce.Rows.RemoveAt(e.RowIndex);
                }
            }
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
            foreach (DataGridViewRow row in createInvoce.Rows)
            {
                if (row.Cells[0].Value == null) return;

                string idNguyenLieu = row.Cells[0].Value.ToString();
                Material material = materials.Find(m => m.idNguyenLieu == idNguyenLieu);



                if (material == null) return;

                InvoiceDetail invoceDetail = new InvoiceDetail();

                invoceDetail.idHoaDon = newInvoce.idHoaDon;
                invoceDetail.idNguyenLieu = material.idNguyenLieu;

                if (row.Cells[3].Value == null)
                {
                    break;
                }


                invoceDetail.sl = int.Parse(row.Cells[3].Value.ToString());
                if (row.Cells[4].Value == null) break;
                invoceDetail.tongTien = double.Parse(row.Cells[4].Value.ToString());

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
            foreach (DataGridViewRow row in createInvoce.Rows)
            {
                row.Cells[0].Value = null;
                row.Cells[1].Value = null;
                row.Cells[2].Value = null;
                row.Cells[3].Value = null;
                row.Cells[4].Value = null;
            }
        }

    }
}
