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
using Microsoft.VisualBasic;

namespace FinalProject_QUANLYKHO.View.InvoceView
{
    public partial class InvoceMenuView : Form
    {
        public InvoceMenuView()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void navigateView(int nameActive) {
            Form1 parentForm = (Form1)this.ParentForm;

            // Do something with the parent form, for example, show its name
            if (parentForm != null)
            {

                parentForm.switchForm(nameActive);
            }
            else
            {
                MessageBox.Show("No parent form found.");
            }
        }
        private void btnNavInvoceExportMaterialCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void btnActiveInvoceImportMaterialIn_Click(object sender, EventArgs e)
        {

        }

        private void btnActiveInvoceExportMaterialGo_Click(object sender, EventArgs e)
        {
            navigateView(ContanstApp.EXPORT_MATERIAL_GO);
        }
    }
}
