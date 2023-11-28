using FinalProject_QUANLYKHO.Models;
using FinalProject_QUANLYKHO.Service;
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
    public partial class AddBake : Form
    {

        BakeService bakeService;
        string bakeName;
        List<Bake> bakes;
        Bake bake;

        public AddBake()
        {
            bakeService = new BakeService();
            InitializeComponent();
            List<BakeType> bakeTypes = bakeService.GetNameTypeBake();
            inputTypeBake.DataSource = bakeTypes;
            inputTypeBake.DisplayMember = "tenLoaiBanh";
            inputTypeBake.ValueMember = "idLoaiBanh";
            bakes = new List<Bake>();
            bake = new Bake();
        }

        public void AddBakeIntoMainForm()
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

            if (baketype == null)
            {

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
            if (nameBake == null || unitBake == null || priceBake == null || numberBake == null)
            {
                MessageBox.Show("Thêm bánh thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            BakeTypeService bakeTypeService = new BakeTypeService();
            bakeService.Create(new Bake(baketype.idLoaiBanh, nameBake, unitBake, float.Parse(priceBake.ToString()), int.Parse(numberBake.ToString())));

            ClearForm();
            AddBakeIntoMainForm();
            MessageBox.Show("Thêm bánh thành công!Thêm tiếp tục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            inputTypeBake.Text = "";
        }

        private void buttonCustom2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InputNumber__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
