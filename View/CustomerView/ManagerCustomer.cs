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
using static Syncfusion.Windows.Forms.TabBar;

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
            btnRemoveSelected.Hide();

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
                object[] rowData = new object[] { false, cus.maKhachHang, cus.tenKhachHang, cus.diaChi, cus.sodienthoai, cus.hien };
                dataGridViewCustomer.Rows.Add(rowData);
            }

        }
        public void LoadDataIntoDataGridView()
        {

            dataGridViewCustomer.Rows.Clear();
            List<Customer> dataCustomer = null;

            if (isJustShowCustomerActive)
            {
                dataCustomer = customerService.GetAllDeActive(page, rowOfPage);
            }
            else
            {
                dataCustomer = customerService.GetAllActive(page, rowOfPage);
            }
            if (dataCustomer == null) return;

            foreach (Customer cus in dataCustomer)
            {
                object[] rowData = new object[] { false, cus.maKhachHang, cus.tenKhachHang, cus.diaChi, cus.sodienthoai, cus.hien };
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
                    object[] rowData = new object[] { false, cus.maKhachHang, cus.tenKhachHang, cus.diaChi, cus.sodienthoai, cus.hien };
                    dataGridViewCustomer.Rows.Add(rowData);
                }
            }
        }


        private void buttonCustom4_Click(object sender, EventArgs e)
        {
            ModalAddCustomer modal = new ModalAddCustomer();
            modal.Show();
        }


        private void handleSelectCustomer(Customer cus, bool status)
        {
            if (status)
            {
                listCustomerDeleted.Add(cus);
            }
            else
            {
                listCustomerDeleted = listCustomerDeleted.Where(c => c.maKhachHang != cus.maKhachHang).ToList();
            }

            if (listCustomerDeleted.Count > 0)
            {
                btnRemoveSelected.Show();
            }
            else
            {
                btnRemoveSelected.Hide();
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
                }

                if (rowData.Count < 4)
                {
                    return;
                }


                Customer customer = new Customer();
                customer.maKhachHang = rowData[1];
                customer.tenKhachHang = rowData[2];
                customer.diaChi = rowData[3];
                customer.sodienthoai = rowData[4];
                customer.hien = bool.Parse(rowData[5]);


                switch (selectedColumn)
                {
                    case 0:
                        {
                            bool status = bool.Parse(rowData[0]);
                            selectedRow.Cells[0].Value = !status;
                            handleSelectCustomer(customer, !status);
                            break;
                        }
                    case 5:
                        {
                            if (customer.hien)
                            {
                                DialogResult result = MessageBox.Show("Bạn có muốn ẩn khách " + customer.tenKhachHang + " không?", "Xác nhận ẩn khách", MessageBoxButtons.YesNo);
                                if (result == DialogResult.Yes)
                                {
                                    customerService.DeActive(customer.maKhachHang);
                                    selectedRow.Cells[5].Value = false;
                                }
                            }
                            else
                            {
                                customerService.Active(customer.maKhachHang);
                                selectedRow.Cells[5].Value = true;
                            }


                            break;
                        }
                    case 6:
                        {
                            /*Action edit*/
                            if (customer != null)
                            {
                                ModalEditCustomer modal = new ModalEditCustomer(customer);
                                modal.Show();
                            }
                            break;
                        }
                    case 7:
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

            if (listCustomerDeleted.Count <= 0) return;
            bool deleteRes = true;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mục này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(listCustomerDeleted.Count.ToString());
                foreach (Customer customer in listCustomerDeleted)
                {
                    if (!string.IsNullOrEmpty(customer.tenKhachHang))
                    {
                        bool deleteResult = customerService.Delete(customer.maKhachHang);

                        if (!deleteResult)
                        {
                            deleteRes = false;
                        }

                    }
                }

                if (deleteRes)
                {
                    MessageBox.Show("Xóa các khách hàng đã chọn thành công!");
                    this.LoadDataIntoDataGridView();
                    btnRemoveSelected.Hide();
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

        private void buttonCustom3_Click(object sender, EventArgs e)
        {

        }

        private void inputSearch_TextChanged(object sender, EventArgs e)
        {
            timerSearch.Stop();
            timerSearch.Start();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void numberPage_Click(object sender, EventArgs e)
        {
        }
    }



}
