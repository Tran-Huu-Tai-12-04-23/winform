using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUpForm
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
            removeBG(imgEmail, imgAddressIcon);
            removeBG(imgPhone, imgPhoneIcon);
            removeBG(imgUsername, imgUserIcon);
            removeBG(imgPass, imgPassIcon);
            removeBG(imgConfirmPass, imgConfirmPassIcon);
        }

        void removeBG(PictureBox pb, PictureBox pb2)
        {
            var pos = this.PointToScreen(pb2.Location);
            pos = pb.PointToClient(pos);
            pb2.Parent = pb;
            pb2.Location = pos;
            pb2.BackColor = Color.Transparent;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
