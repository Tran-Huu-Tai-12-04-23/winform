using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_QUANLYKHO.View.Authentication
{



    public partial class Authentication : Form
    {
        private Form currentForm;


        public Authentication()
        {
            InitializeComponent();
            Login login = new Login();
            OpenChildForm(login);
        }

        public void OpenChildForm(Form childForm)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }


            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMainForm.Controls.Add(childForm);
            panelMainForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }



        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public void NavigateRegister()
        {
            Register register = new Register();
            OpenChildForm(register);
        }
        public void NavigateLogin()
        {
            Login login = new Login();
            OpenChildForm(login);
        }

        private void Authentication_Load(object sender, EventArgs e)
        {

        }
    }
}
