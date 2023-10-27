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

namespace FinalProject_QUANLYKHO.View.CustomerView
{
    public partial class ManagerCustomer : Form
    {
        public ManagerCustomer()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {

            for (int i = 0; i < 10; i++)
            {
                object[] rowData = new object[] { "KH999 " + i, "Khách hàng mới " + i, "HCM " + i };
                dataGridViewCustomer.Rows.Add(rowData);
            }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonCustom5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonCustom4_Click(object sender, EventArgs e)
        {
            ModalAddCustomer modal = new ModalAddCustomer();
            modal.Show();
        }
    }

}
