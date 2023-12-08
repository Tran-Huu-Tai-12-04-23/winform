using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject_QUANLYKHO.Models;
using FinalProject_QUANLYKHO.Service;
using FinalProject_QUANLYKHO.View.CustomerView;
using FinalProject_QUANLYKHO.View.InvoceExportMaterialGoView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject_QUANLYKHO.View.ImportMaterialView
{
    public partial class ManagerExportMaterialGo : Form
    {
        private InvoiceFunctionCommonService invoiceFunctionCommonService;
        private InvoceService invoceService;
        private List<Invoice> invoices = new List<Invoice>();
        public ManagerExportMaterialGo()
        {
            invoiceFunctionCommonService = new InvoiceFunctionCommonService();
            invoceService = new InvoceService();
            InitializeComponent();
            renderExportDepartment();
            LoadDataIntoDataGridView();

        }


        public void AddCusIntoGridView(Customer cus)
        {
            if (cus != null)
            {
                object[] rowData = new object[] { cus.maKhachHang, cus.tenKhachHang, cus.diaChi, cus.sodienthoai, cus.hien };
                dataGridViewInvoice.Rows.Add(rowData);
            }

        }
        public void LoadDataIntoDataGridView()
        {
            dataGridViewInvoice.Rows.Clear();
            DateTime dateOfInvoiceValue = dateOfInvoice.Value;
            invoices = invoceService.GetAllCancelledInvoicesByDate(dateOfInvoiceValue);
            MessageBox.Show(invoices.Count.ToString());
            foreach (Invoice inv in invoices)
            {
                object[] rowData = new object[] { inv.idHoaDon, inv.tongTien, inv.soLuong, inv.tenBoPhanXuat };
                dataGridViewInvoice.Rows.Add(rowData);
            }


        }


        public void renderExportDepartment()
        {

            List<ExportDepartment> exportDepartMents = invoiceFunctionCommonService.GetAllExportDepartment();
            List<ExportDepartment> exportDepartMentAll = new List<ExportDepartment>();
            ExportDepartment exportDepartment = new ExportDepartment();
            exportDepartment.tenBoPhanXuat = "Tất cả";
            exportDepartment.idBoPhanXuat = "-1";
            exportDepartMentAll.Add(exportDepartment);
            exportDepartMentAll.AddRange(exportDepartMents);

            listExportDepartMent.DataSource = exportDepartMentAll;
            listExportDepartMent.DisplayMember = "tenBoPhanXuat"; // Display the 'Name' property of the Item class
            listExportDepartMent.ValueMember = "idBoPhanXuat";     // Use the 'Id' property as the value

        }

        private void ManagerImportMaterial_Load(object sender, EventArgs e)
        {

        }

        private void labelCustomerTitle_Click(object sender, EventArgs e)
        {

        }

        private void listExportDepartMent_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selectedItem = listExportDepartMent.SelectedItem;

            // Check if an item is selected
            if (selectedItem != null)
            {
                // Convert the selected item to the appropriate type if needed
                ExportDepartment selectedDepartment = (ExportDepartment)selectedItem;

                if (selectedDepartment == null) return;
                // Access the properties of the selected item if needed
                filterDataFollowExportDepartment(selectedDepartment);
            }
        }

        private void filterDataFollowExportDepartment(ExportDepartment selectedDepartment)
        {
            if (selectedDepartment.idBoPhanXuat.Equals("-1"))
            {
                LoadDataIntoDataGridView();
                return;
            }

            dataGridViewInvoice.Rows.Clear();
            List<Invoice> invoicesPreview = invoices.FindAll(inv =>
            {
                return inv.idBoPhanXuat == selectedDepartment.idBoPhanXuat;
            });


            foreach (Invoice inv in invoicesPreview)
            {
                object[] rowData = new object[] { inv.idHoaDon, inv.tongTien, inv.soLuong, inv.tenBoPhanXuat };
                dataGridViewInvoice.Rows.Add(rowData);
            }
        }

        private void btnAddInvoce_Click(object sender, EventArgs e)
        {
            FormAddInvoceExportMaterialGo form = new FormAddInvoceExportMaterialGo();
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void dateOfInvoice_ValueChanged(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void dataGridViewInvoice_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Kiểm tra xem ô được nhấp vào có hợp lệ không
            {
                // Lấy hàng (row) chứa ô được nhấp vào
                DataGridViewRow selectedRow = dataGridViewInvoice.Rows[e.RowIndex];
                int selectedColumn = e.ColumnIndex;

                List<string> rowData = new List<string>();

                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    if (cell.Value != null)
                    {
                        rowData.Add(cell.Value.ToString());
                    }
                }
                Invoice invoice = new Invoice();
                invoice = invoices.Find(inv => inv.idHoaDon == rowData[0]);
                if (invoice == null) return;

                switch (selectedColumn)
                {
                    case 4:
                        {
                            DetailInvoice formDetailInvoice = new DetailInvoice(invoices, invoice);
                            formDetailInvoice.Show();
                            break;
                        }
                    case 5:
                        {
                            //handle remove 
                            // Handle remove
                            DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa hóa đơn không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                // Code to delete the bill goes here
                                bool removeRes = invoceService.RemoveInvoice(invoice);

                                if (removeRes)
                                {
                                    MessageBox.Show("Xóa hóa đơn thành công");

                                    LoadDataIntoDataGridView();
                                }
                                else
                                {
                                    MessageBox.Show("Xóa hóa đơn thất bại!");
                                }
                            }
                            break;
                        }

                }


            }
        }
    }
}
