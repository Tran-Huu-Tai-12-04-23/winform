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
        List<string> oldData { get; set; }

        private string idBake;

        public UpdateBake()
        {
            bakes = new List<Bake>();
            bake = new Bake();
            InitializeComponent();
        }
        public UpdateBake(List<string> data)
        {
            InitializeComponent();
            oldData = data;
            idBake = oldData[0];
            inputTypeBake.Text = oldData[1];
            inputNameBake.Texts = oldData[2];
            inputUnit.Texts = oldData[3];
            inputPrice.Texts = oldData[4];
            InputNumber.Texts = oldData[5];
            bakeService = new BakeService();
            inputTypeBake.Items.AddRange(bakeService.GetNameTypeBake().ToArray());


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
                if (form.checkType)
                {
                    form.LoadDataByPageAndTypeIntoDataGridView(form.currentPageType, form.size(), form.key(), form.checkActive());
                }
                else
                {
                    form.LoadDataByPageIntoDataGridView(form.currentPage, form.size(), form.checkActive());
                }

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ManagerBake manager = new ManagerBake();
            string nameBake = inputNameBake.Texts;
            string unitBake = inputUnit.Texts;
            string priceBake = inputPrice.Texts;
            string numberBake = InputNumber.Texts;
            string nameTypeBake = inputTypeBake.Text;
            /*if (!IsNumeric(priceBake))
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
            }*/
            if (nameBake == null || unitBake == null || priceBake == null || numberBake == null)
            {
                MessageBox.Show("Cập nhập bánh thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            else
            {
                BakeTypeService bakeTypeService = new BakeTypeService();
                string idType = bakeTypeService.GetIDTypeBakeByName(nameTypeBake);
                bakeService.Update(new Bake(idBake, idType, nameBake, int.Parse(numberBake.ToString()), float.Parse(priceBake.ToString()), unitBake));
                ClearForm();
                UpdateBakeIntoMainForm();
                MessageBox.Show("Cập nhập bánh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }           
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

        private void inputPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore the key press if it's not a digit or control key
            }

        }

        private void InputNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore the key press if it's not a digit or control key
            }

        }
    }
}
