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
            DateTime dateOfInvoiceValue = dateOfInvoice.Value;
            dataGridViewInvoice.Rows.Clear();
            invoices = invoceService.GetAllCancelledInvoicesByDate(dateOfInvoiceValue);

            foreach (Invoice inv in invoices)
            {
                object[] rowData = new object[] { inv.idHoaDon, inv.tongTien, inv.soLuong, inv.tenBoPhanXuat };
                dataGridViewInvoice.Rows.Add(rowData);
            }

        }
        public void renderExportDepartment()
        {
            List<ExportDepartment> exportDepartMents = invoiceFunctionCommonService.GetAllExportDepartment();

            listExportDepartMent.DataSource = exportDepartMents;
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

        }

        private void btnAddInvoce_Click(object sender, EventArgs e)
        {
            FormAddInvoceExportMaterialGo form = new FormAddInvoceExportMaterialGo();
            form.Show();
        }

        private void dataGridViewInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                            /*Action edit*/

                            break;
                        }
                    case 6:
                        {

                            break;
                        }

                }


            }
        }

        private void dateOfInvoice_ValueChanged(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }
    }
}
