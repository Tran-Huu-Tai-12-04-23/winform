using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject_QUANLYKHO.Contanst;
using FinalProject_QUANLYKHO.Models;
using FinalProject_QUANLYKHO.Service;
using FinalProject_QUANLYKHO.View.CustomerView;
using FinalProject_QUANLYKHO.View.InvoceExportMaterialGoView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject_QUANLYKHO.View.ImportMaterialView
{
    public partial class ManagerImportBakeOutSide : Form
    {
        private InvoiceFunctionCommonService invoiceFunctionCommonService;
        private InvoceService invoceService;
        private List<Invoice> invoices = new List<Invoice>();
        CustomerService customerService;
        InvoiceBakeService invoiceBakeService;
        List<Customer> customers;
        public ManagerImportBakeOutSide()
        {
            invoiceFunctionCommonService = new InvoiceFunctionCommonService();
            invoceService = new InvoceService();
            customerService = new CustomerService();
            invoiceBakeService = new InvoiceBakeService();
            customers = customerService.GetAllActive(0, 1000);
            InitializeComponent();
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
            invoices = invoceService.GetAllInvoicesByDateAndType(dateOfInvoiceValue, ContanstApp.NhapBanhMuaNgoai);

            foreach (Invoice inv in invoices)
            {
                string id = (invoiceBakeService.GetAllInvoiceBakeImportByIdBill(inv.idHoaDon)[0]).idKhachHang;
                Customer customer = customers.Find(m => m.maKhachHang == id);
                object[] rowData = new object[] { inv.idHoaDon, inv.tongTien, inv.soLuong, customer.tenKhachHang };
                dataGridViewInvoice.Rows.Add(rowData);
            }


        }




        private void ManagerImportMaterial_Load(object sender, EventArgs e)
        {

        }

        private void labelCustomerTitle_Click(object sender, EventArgs e)
        {

        }


        private void filterDataFollowImportCustomer(Customer customer)
        {
            if (customer.maKhachHang.Equals("-1"))
            {
                LoadDataIntoDataGridView();
                return;
            }

            dataGridViewInvoice.Rows.Clear();
            DateTime dateOfInvoiceValue = dateOfInvoice.Value;

            invoices = invoceService.GetAllInvoicesByDateAndType(dateOfInvoiceValue, ContanstApp.NhapBanhMuaNgoai);

            foreach (Invoice inv in invoices)
            {
                object[] rowData = new object[] { inv.idHoaDon, inv.tongTien, inv.soLuong, inv.tenBoPhanXuat };
                dataGridViewInvoice.Rows.Add(rowData);
            }
        }

        private void btnAddInvoce_Click(object sender, EventArgs e)
        {
            FormAddInvoceImportBakeOutSide form = new FormAddInvoceImportBakeOutSide();
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
                string id = (invoiceBakeService.GetAllInvoiceBakeImportByIdBill(invoice.idHoaDon)[0]).idKhachHang;
                Customer customer = customers.Find(m => m.maKhachHang == id);
                switch (selectedColumn)
                {
                    case 4:
                        {
                            DetailBakeBillImport formDetailInvoice = new DetailBakeBillImport(invoices, invoice, customer);
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
                                invoceService.DeleteInvoice(invoice);


                                MessageBox.Show("Xóa hóa đơn thành công");

                                LoadDataIntoDataGridView();

                            }
                            break;
                        }

                }


            }
        }
    }
}
