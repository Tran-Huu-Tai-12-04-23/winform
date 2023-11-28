using FinalProject_QUANLYKHO.Models;
using FinalProject_QUANLYKHO.Service;
using FinalProject_QUANLYKHO.View.CustomerView;
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
    public partial class ModalAddMaterial : Form
    {
        MaterialService materialService;
        string materialName;
        List<Material> materials;
        Material material;
        public ModalAddMaterial()
        {
            materialService = new MaterialService();
            InitializeComponent();
            List<MaterialType> materialTypes = materialService.GetNameTypeMaterial();
            inputTypeMaterial.DataSource = materialTypes;
            inputTypeMaterial.DisplayMember = "tenLoaiNguyenLieu"; // Display the 'Name' property of the Item class
            inputTypeMaterial.ValueMember = "tenLoaiNguyenLieu";     // Use t
            materials = new List<Material>();
            material = new Material();
        }
        public void AddMaterialIntoMainForm()
        {
            ManagerMaterial form = (ManagerMaterial)Application.OpenForms["ManagerMaterial"];

            if (form != null)
            {
                form.initDataGirdView();
            }
        }

        private void btnTurnOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

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
            inputTypeMaterial.Text = "";
        }
        private void inputTypeMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void panelCustom1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void inputTypeMaterial_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
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
            if (nameMaterial == null || unitMaterial == null || priceMaterial == null || numberMaterial == null)
            {
                MessageBox.Show("Thêm nguyên liệu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MaterialTypeService materialTypeService = new MaterialTypeService();
            string idType = materialTypeService.GetIDTypeMaterialByName(nameTypeMaterial);
            materialService.Create(new Material(nameTypeMaterial, nameMaterial, unitMaterial, float.Parse(priceMaterial.ToString()), int.Parse(numberMaterial.ToString())));

            ClearForm();
            AddMaterialIntoMainForm();
            MessageBox.Show("Thêm nguyên liệu thành công!Thêm tiếp tục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
