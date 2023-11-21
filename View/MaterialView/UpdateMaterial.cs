using FinalProject_QUANLYKHO.Models;
using FinalProject_QUANLYKHO.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject_QUANLYKHO.View.MaterialView
{
    public partial class UpdateMaterial : Form
    {
        MaterialService materialService;
        string materialName;
        List<Material> materials;
        Material material { get; set; }
        List<string> oldData { get; set; }

        private string idMaterial;
        public UpdateMaterial()
        {
            materials = new List<Material>();
            material = new Material();
            InitializeComponent();


        }
        public UpdateMaterial(List<string> data)
        {
            InitializeComponent();
            oldData = data;
            inputTypeMaterial.Text = oldData[0];
            inputNameMaterial.Texts = oldData[1];
            inputUnit.Texts = oldData[2];
            inputPrice.Texts = oldData[3];
            InputNumber.Texts = oldData[4];
            materialService = new MaterialService();
            inputTypeMaterial.Items.AddRange(materialService.GetNameTypeMaterial().ToArray());


        }

        public void SetIdMaterialUpdate(string idMaterial)
        {

            this.idMaterial = idMaterial;
        }

        public void UpdateMaterialIntoMainForm()
        {
            ManagerMaterial form = (ManagerMaterial)Application.OpenForms["ManagerMaterial"];

            if (form != null)
            {
                if (form.checkType)
                {
                    form.LoadDataByPageAndTypeIntoDataGridView(form.currentPageType,form.size(),form.key(),form.checkActive());
                }
                else
                {
                    form.LoadDataByPageIntoDataGridView(form.currentPage, form.size(), form.checkActive());
                }

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ManagerMaterial manager = new ManagerMaterial();
            string nameMaterial = inputNameMaterial.Texts;
            string unitMaterial = inputUnit.Texts;
            string priceMaterial = inputPrice.Texts;
            string numberMaterial = InputNumber.Texts;
            string nameTypeMaterial = inputTypeMaterial.Text;
            if (!IsNumeric(priceMaterial))
            {
                inputPrice.Focus();

                MessageBox.Show("Giá tiền chỉ nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!IsNumeric(numberMaterial))
            {
                InputNumber.Focus();

                MessageBox.Show("Số lượng chỉ nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (nameMaterial == null || unitMaterial == null || priceMaterial == null || numberMaterial == null)
            {
                MessageBox.Show("Cập nhập nguyên liệu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            MaterialTypeService materialTypeService = new MaterialTypeService();
            string idType = materialTypeService.GetIDTypeMaterialByName(nameTypeMaterial);
            materialService.Update(new Material(idMaterial, idType, nameMaterial, int.Parse(numberMaterial.ToString()), float.Parse(priceMaterial.ToString()), unitMaterial));
            ClearForm();
            UpdateMaterialIntoMainForm();
            MessageBox.Show("Cập nhập nguyên liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }
        public bool IsNumeric(string input)
        {
            double result;
            return double.TryParse(input, out result);
        }
        private void ClearForm()
        {
            inputNameMaterial.Texts = "";
            inputUnit.Texts = "";
            inputPrice.Texts = "";
            InputNumber.Texts = "";
        }
        private void btnTurnOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
