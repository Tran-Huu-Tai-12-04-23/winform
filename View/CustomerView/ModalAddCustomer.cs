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
    public partial class ModalAddCustomer : Form
    {
        private CustomerService customerService;
        private List<Customer> newCustomerList;
        public ModalAddCustomer()
        {
            newCustomerList = new List<Customer>();
            customerService = new CustomerService();
            InitializeComponent();
        }

        public void AddCusIntoMainForm(Customer cus)
        {
            ManagerCustomer form = (ManagerCustomer)Application.OpenForms["ManagerCustomer"];

            if (form != null)
            {
                form.AddCusIntoGridView(cus);

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


            Customer newCus = new Customer(nameCus, address, phone);

            Customer cusRes = customerService.Create(newCus);

            if( cusRes != null)
            {
                newCustomerList.Add(cusRes);
                AddCusIntoMainForm(cusRes);
                MessageBox.Show("Thêm khách thành công!Thêm tiếp tục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void ClearForm()
        {
            inputAddress.Texts = "";
            inputName.Texts = "";
            inputPhoneNumber.Texts = "";
        }
    }
}
