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
        Material oldData;
        private string idMaterial;
        public UpdateMaterial()
        {
            materials = new List<Material>();
            material = new Material();
            InitializeComponent();


        }
        public UpdateMaterial(Material material)
        {
            InitializeComponent();
            oldData = material;
            inputTypeMaterial.Text = material.idLoaiNguyenLieu;
            inputNameMaterial.Texts = material.tenNguyenLieu;
            inputUnit.Texts = material.donVi;
            inputPrice.Texts = material.giaTien.ToString();
            InputNumber.Texts = material.sl.ToString();
            materialService = new MaterialService();
            List<MaterialType> materialTypes = materialService.GetNameTypeMaterial();
            inputTypeMaterial.DataSource = materialTypes;
            inputTypeMaterial.DisplayMember = "tenLoaiNguyenLieu";
            inputTypeMaterial.ValueMember = "idLoaiNguyenLieu";
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
                form.initDataGirdView();

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
            MaterialType materialType = (MaterialType)inputTypeMaterial.SelectedItem;

            if (materialType == null)
            {
                MessageBox.Show("Loai ngyen lieu null");
                return;
            }

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

            Material material = new Material(oldData.idNguyenLieu, materialType.idLoaiNguyenLieu, nameMaterial, int.Parse(numberMaterial.ToString()), float.Parse(priceMaterial.ToString()), unitMaterial);
            materialService.Update(material);
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
