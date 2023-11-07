using FinalProject_QUANLYKHO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_QUANLYKHO.View.DecentralizationView
{
    public partial class ModalEditDecentralization : Form
    {
        Decentralization data;
        public ModalEditDecentralization()
        {
            InitializeComponent();
        }
        public ModalEditDecentralization(Decentralization decentralization)
        {
            this.data = decentralization;
            InitializeComponent();
        }

        private void buttonCustom2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
