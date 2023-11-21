using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject_QUANLYKHO.Models;
using FinalProject_QUANLYKHO.Contanst;
using FinalProject_QUANLYKHO.Service;

namespace FinalProject_QUANLYKHO.View.CustomerView
{
    public partial class ManagerCustomer : Form
    {
        private CustomerService customerService;
        private List<Customer> listCustomerDeleted;
        private int totalCustomer;
        private int page = 0;
        private int rowOfPage = 10;
        private int totalPage = 0;
        private bool isJustShowCustomerActive = false;
        public ManagerCustomer()
        {
            InitializeComponent();
            customerService = new CustomerService();
            listCustomerDeleted = new List<Customer>();

            LoadDataIntoDataGridView();

            if (customerService != null)
            {
                totalCustomer = customerService.GetTotalRow();
                rowShowNotification.Text = "Hiển thị " + rowOfPage + " trong tổng " + totalCustomer;

                DisableBtn(btnPrevPage);
                totalPage = (int)Math.Ceiling(totalCustomer / (double)rowOfPage);
                if (totalPage < 2)
                {
                    DisableBtn(btnNextPage);
                }
                numberPage.Text = (page + 1).ToString() + "/" + totalPage.ToString();

                selectNumberPage.SelectedIndex = 0;

            }
        }


        public void UpdateCustomer(Customer customer)
        {
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
            List<Customer> dataCustomer = null;

            if (isJustShowCustomerActive)
            {
                dataCustomer = customerService.GetAllActive(page, rowOfPage);
            }
            else
            {
                dataCustomer = customerService.GetAll(page, rowOfPage);
            }
            if (dataCustomer == null) return;

            foreach (Customer cus in dataCustomer)
            {
                object[] rowData = new object[] { cus.maKhachHang, cus.tenKhachHang, cus.diaChi, cus.sodienthoai, cus.hien };
                dataGridViewCustomer.Rows.Add(rowData);
            }

        }


        private void LoadDataSearchIntoDataGridView(List<Customer> searchCustomer)
        {
            if (searchCustomer != null)
            {
                dataGridViewCustomer.Rows.Clear();
                for (int i = 0; i < searchCustomer.Count; i++)
                {
                    /* rowData.Append(list[i]);*/
                    Customer cus = searchCustomer[i];
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn hay không
            if (dataGridViewCustomer.SelectedRows.Count > 0)
            {
                listCustomerDeleted.Clear();
                foreach (DataGridViewRow row in dataGridViewCustomer.SelectedRows)
                {
                    List<string> rowData = new List<string>();
                    foreach (DataGridViewCell cell in row.Cells)
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



                    if (customer == null || customer.maKhachHang.Equals("") || customer.diaChi.Equals("") || customer.sodienthoai.Equals(""))
                    {
                        if (dataGridViewCustomer.SelectedRows.Count == 1)
                        {
                            btnRemoveSelected.Hide();
                            return;
                        }
                    }

                    btnRemoveSelected.Show();

                    listCustomerDeleted.Add(customer);
                }
            }
        }

        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Kiểm tra xem ô được nhấp vào có hợp lệ không
            {
                // Lấy hàng (row) chứa ô được nhấp vào
                DataGridViewRow selectedRow = dataGridViewCustomer.Rows[e.RowIndex];
                int selectedColumn = e.ColumnIndex;

                List<string> rowData = new List<string>();

                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    if (cell.Value != null)
                    {
                        rowData.Add(cell.Value.ToString());
                    }
                    else
                    {

                    }
                    {
                        rowData.Add("");
                    }
                }
                Customer customer = new Customer();
                customer.maKhachHang = rowData[0];
                customer.tenKhachHang = rowData[1];
                customer.diaChi = rowData[2];
                customer.sodienthoai = rowData[3];
                customer.hien = bool.Parse(rowData[8]);


                switch (selectedColumn)
                {
                    case 4:
                        {
                            if (customer.hien)
                            {
                                customerService.DeActive(customer.maKhachHang);
                                selectedRow.Cells[4].Value = false;
                            }
                            else
                            {
                                customerService.Active(customer.maKhachHang);
                                selectedRow.Cells[4].Value = true;
                            }
                            break;
                        }
                    case 5:
                        {
                            /*Action edit*/
                            if (customer != null)
                            {
                                ModalEditCustomer modal = new ModalEditCustomer(customer);
                                modal.Show();
                            }
                            break;
                        }
                    case 6:
                        {
                            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mục này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            /*Action remove*/
                            if (result == DialogResult.Yes && customer.maKhachHang != null)
                            {
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
                            break;
                        }

                }


            }
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            bool deleteRes = true;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mục này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (Customer customer in listCustomerDeleted)
                {
                    if (!customer.tenKhachHang.Equals(""))
                    {
                        bool deleteResult = customerService.Delete(customer.maKhachHang);

                        if (!deleteResult)
                        {
                            deleteRes = false;
                        }
                        else
                        {
                            this.LoadDataIntoDataGridView();
                            btnRemoveSelected.Hide();
                        }
                    }

                }

                if (deleteRes)
                {
                    MessageBox.Show("Xóa các khách hàng đã chọn thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa các khách hàng đã chọn thất bại!");
                }

            }



        }

        private void btnSarch_Click(object sender, EventArgs e)
        {
            inputSearch.Text = "";
            LoadDataIntoDataGridView();
        }


        private void yourTextBox_TextChanged(object sender, EventArgs e)
        {
            timerSearch.Stop();
            timerSearch.Start();
        }

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            // Thực hiện tìm kiếm sau khi Timer đạt đủ thời gian chờ
            timerSearch.Stop();
            String key = inputSearch.Text;

            if (key.Equals(""))
            {
                LoadDataIntoDataGridView();
                return;
            }

            List<Customer> listSearchCustomer = customerService.Search(key);

            if (listSearchCustomer == null)
            {
                return;
            }

            LoadDataSearchIntoDataGridView(listSearchCustomer);

        }

        private void SelectNumberPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            rowOfPage = int.Parse(selectNumberPage.SelectedItem.ToString());
            totalPage = (int)Math.Ceiling(totalCustomer / (double)rowOfPage);
            RestPageNotification();
            LoadDataIntoDataGridView();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {

            this.page += 1;
            LoadDataIntoDataGridView();
            RestPageNotification();

        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {


            this.page -= 1;
            LoadDataIntoDataGridView();
            RestPageNotification();
        }


        private void RestPageNotification()
        {
            totalPage = (int)Math.Ceiling(totalCustomer / (double)rowOfPage);
            numberPage.Text = (page + 1).ToString() + " / " + this.totalPage.ToString();
            rowShowNotification.Text = "Hiển thị " + rowOfPage + " trong tổng " + totalCustomer;

            if (this.page + 1 < totalPage)
            {
                EnableBtn(btnNextPage);
            }
            else if (this.page + 1 >= this.totalPage)
            {
                DisableBtn(btnNextPage);
            }

            if (this.page < 1)
            {
                DisableBtn(btnPrevPage);
            }
            else if (this.page + 1 < this.totalPage)
            {
                EnableBtn(btnPrevPage);
            }



        }

        private void DisableBtn(Button button)
        {
            button.Enabled = false;
            button.BackColor = ContanstApp.INACTIVE_COLOR;
        }

        private void EnableBtn(Button button)
        {
            button.Enabled = true;
            button.BackColor = ContanstApp.ACTIVE_COLOR;
        }

        private void rjToggle2_CheckedChanged(object sender, EventArgs e)
        {
            if (rjToggle2.Checked)
            {
                isJustShowCustomerActive = true;
                totalCustomer = customerService.GetTotalRowActive();
            }
            else
            {
                isJustShowCustomerActive = false;
                totalCustomer = customerService.GetTotalRow();

            }
            RestPageNotification();
            LoadDataIntoDataGridView();
        }
    }



}
