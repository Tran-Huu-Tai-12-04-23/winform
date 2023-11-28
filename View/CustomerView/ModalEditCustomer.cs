using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject_QUANLYKHO.Service;
using FinalProject_QUANLYKHO.Models;

namespace FinalProject_QUANLYKHO.View.CustomerView
{
    public partial class ModalEditCustomer : Form
    {
        private CustomerService customerService;
        private Customer customer;
        public ModalEditCustomer()
        {
            customerService = new CustomerService();
            InitializeComponent();
        }

        public ModalEditCustomer(Customer cus)
        {
            customer = cus;
            customerService = new CustomerService();
            InitializeComponent();
            LoadDataForm(cus);
        }

        public void UpdateCustomerFromMainScreen(Customer cus)
        {
            ManagerCustomer form = (ManagerCustomer)Application.OpenForms["ManagerCustomer"];

            if (form != null)
            {
                form.UpdateCustomer(cus);

            }
        }




        private void buttonCustom2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string nameCus = inputName.Texts;
            string address = inputAddress.Texts;
            string phone = inputPhoneNumber.Texts;


            if (nameCus.Equals("") || address.Equals("") || phone.Equals(""))
            {
                return;
            }

            if (customer == null)
            {
                return;
            }

            customer.tenKhachHang = nameCus;
            customer.diaChi = address;
            customer.sodienthoai = phone;

            if (customer.tenKhachHang.Equals("") || customer.diaChi.Equals("") || customer.sodienthoai.Equals(""))
            {
                return;
            }

            Customer cusRes = customerService.Update(customer);

            if (cusRes != null)
            {
                MessageBox.Show("Chỉnh sửa khách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateCustomerFromMainScreen(cusRes);
                this.Close();
            }
            else
            {
                MessageBox.Show("Chỉnh sửa khash hàng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void LoadDataForm(Customer customer)
        {
            if (customer != null)
            {
                inputAddress.Texts = customer.diaChi;
                inputName.Texts = customer.tenKhachHang;
                inputPhoneNumber.Texts = customer.sodienthoai;
            }
        }


    }
}
