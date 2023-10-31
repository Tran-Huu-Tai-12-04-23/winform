using System;
using System.Collections;
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

namespace FinalProject_QUANLYKHO.View.CustomerView
{
    public partial class ManagerCustomer : Form
    {
        private CustomerService customerService;
        public ManagerCustomer()
        {
            InitializeComponent();
            customerService = new CustomerService();
            LoadDataIntoDataGridView();
        }

        public void AddCusIntoGridView(Customer cus)
        {
            if (cus != null)
            {     /* rowData.Append(list[i]);*/
                object[] rowData = new object[] { cus.maKhachHang, cus.tenKhachHang, cus.diaChi, cus.sodienthoai, cus.hien };
                dataGridViewCustomer.Rows.Add(rowData);
            }

        }
        public void LoadDataIntoDataGridView()
        {

            dataGridViewCustomer.Rows.Clear();
            if (customerService != null)
            {
                List<Customer> list = customerService.GetAll();
                for (int i = 0; i < list.Count; i++)
                {
                    /* rowData.Append(list[i]);*/
                    Customer cus = list[i];
                    object[] rowData = new object[] { cus.maKhachHang, cus.tenKhachHang, cus.diaChi, cus.sodienthoai, cus.hien };
                    dataGridViewCustomer.Rows.Add(rowData);
                }
            }
        }


        private void buttonCustom4_Click(object sender, EventArgs e)
        {
            ModalAddCustomer modal = new ModalAddCustomer();
            modal.Show();
        }

        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Hiển thị hộp thoại xác nhận xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mục này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra kết quả của hộp thoại xác nhận
            if (result == DialogResult.Yes)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Kiểm tra xem ô được nhấp vào có hợp lệ không
                {
                    // Lấy hàng (row) chứa ô được nhấp vào
                    DataGridViewRow selectedRow = dataGridViewCustomer.Rows[e.RowIndex];

                    // Lấy tất cả giá trị của các ô trong hàng và chuyển đổi thành danh sách hoặc mảng
                    List<string> rowData = new List<string>();

                    foreach (DataGridViewCell cell in selectedRow.Cells)
                    {
                        if (cell.Value != null)
                        {
                            rowData.Add(cell.Value.ToString());
                        }
                        else
                        {
                            rowData.Add("");
                        }
                    }
                    Customer customer = new Customer();
                    customer.maKhachHang = rowData[0];
                    customer.tenKhachHang = rowData[1];
                    customer.diaChi = rowData[2];
                    customer.sodienthoai = rowData[3];

                    bool deleteRes = customerService.Delete(customer.maKhachHang);

                    if (deleteRes)
                    {
                        MessageBox.Show("Xóa khách hành thành công " + customer.tenKhachHang);
                        dataGridViewCustomer.Rows.Remove(selectedRow);
                    }
                    else
                    {
                        MessageBox.Show("Xóa khách hàng thất bại " + customer.tenKhachHang);
                    }


                }

            }



        }

        private void buttonCustom5_Click(object sender, EventArgs e)
        {

        }
    }

}
