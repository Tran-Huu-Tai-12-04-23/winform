using FinalProject_QUANLYKHO.Models;
using FinalProject_QUANLYKHO.Service;
using FinalProject_QUANLYKHO.View.CustomerView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_QUANLYKHO.View.BakeView
{


    public partial class AddBakeForm : Form
    {
        private BakeService bakeService;
        private List<Bake> newBakeList;
        public AddBakeForm()
        {
            newBakeList = new List<Bake>();
            bakeService = new BakeService();
            InitializeComponent();
        }

        public void AddBakeIntoMainForm(Bake bake)
        {
            ManagerBake form = (ManagerBake)Application.OpenForms["ManagerBake"];

            if (form != null)
            {
                form.AddBakeIntoGridView(bake);

            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddBakeForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonCustom2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string nameBake = inputName.Texts;
            int amountBake = int.Parse(inputSoLuong.Texts);
            float priceBake = float.Parse(inputGiaTien.Texts);
            string unitBake = inputDonVi.Texts;
            string idUnitBake = inputId.Texts;

            if (nameBake.Equals("") || unitBake.Equals("") || idUnitBake.Equals(""))
            {
                return;
            }

            Bake newBake = new Bake(nameBake, amountBake, priceBake, unitBake, idUnitBake); 
            
            Bake bakeRes = bakeService.Create(newBake);
            
            if (bakeRes != null)
            {
                newBakeList.Add(bakeRes);
                AddBakeIntoMainForm(bakeRes);
                MessageBox.Show("Thêm bánh thành công!Thêm tiếp tục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            else
            {
               MessageBox.Show("Thêm bánh thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearForm()
        {
            inputName.Texts = "";
            inputSoLuong.Texts = "";
            inputGiaTien.Texts = "";
            inputDonVi.Texts = "";
            inputId.Texts = "";
        }
    }
}
