using FinalProject_QUANLYKHO.Models;
using FinalProject_QUANLYKHO.Service;
using FinalProject_QUANLYKHO.View.BakeView;
using FinalProject_QUANLYKHO.View.BakeView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_QUANLYKHO.View.BakeView
{
    public partial class UpdateBake : Form
    {

        BakeService bakeService;
        string bakeName;
        List<Bake> bakes;
        Bake bake { get; set; }
        Bake oldData{ get; set; }

        private string idBake;

        public UpdateBake()
        {
            bakes = new List<Bake>();
            bake = new Bake();
            InitializeComponent();
        }
        public UpdateBake(Bake bake)
        {
            InitializeComponent();
            oldData = bake;
            idBake = bake.idBanh;
            inputTypeBake.Text = bake.idLoaiBanh;
            inputNameBake.Texts = bake.tenBanh;
            inputUnit.Texts = bake.donVi;
            inputPrice.Texts = bake.giaTien.ToString();
            InputNumber.Texts = bake.sl.ToString();
            bakeService = new BakeService();

            List<BakeType> bakeTypes= bakeService.GetNameTypeBake();
            inputTypeBake.DataSource = bakeTypes;
            inputTypeBake.DisplayMember = "tenLoaiBanh";
            inputTypeBake.ValueMember = "idLoaiBanh";


        }
        public void SetIdBakeUpdate(string idBake)
        {

            this.idBake = idBake;
        }
        public void UpdateBakeIntoMainForm()
        {
            ManagerBake form = (ManagerBake)Application.OpenForms["ManagerBake"];

            if (form != null)
            {
                form.initDataGirdView();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            BakeType baketype = (BakeType)inputTypeBake.SelectedItem;

            if (baketype == null) {

                MessageBox.Show("Bake type is null!");
                return;
            }

            string nameBake = inputNameBake.Texts;
            string unitBake = inputUnit.Texts;
            string priceBake = inputPrice.Texts;
            string numberBake = InputNumber.Texts;
            string nameTypeBake = inputTypeBake.Text;
            if (!IsNumeric(priceBake))
            {
                inputPrice.Focus();

                MessageBox.Show("Giá tiền chỉ nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!IsNumeric(numberBake))
            {
                InputNumber.Focus();

                MessageBox.Show("Số lượng chỉ nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (nameBake == null || unitBake == null || priceBake == null || numberBake == null)
            {
                MessageBox.Show("Cập nhập bánh thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            BakeTypeService bakeTypeService = new BakeTypeService();
            
            bakeService.Update(new Bake(idBake, baketype.idLoaiBanh, nameBake, int.Parse(numberBake.ToString()), float.Parse(priceBake.ToString()), unitBake));
            ClearForm();
            UpdateBakeIntoMainForm();
            MessageBox.Show("Cập nhập bánh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        public bool IsNumeric(string input)
        {
            double result;
            return double.TryParse(input, out result);
        }
        private void ClearForm()
        {
            inputNameBake.Texts = "";
            inputUnit.Texts = "";
            inputPrice.Texts = "";
            InputNumber.Texts = "";
        }

        private void buttonCustom2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inputTypeBake_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
