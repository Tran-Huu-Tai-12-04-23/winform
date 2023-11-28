using FinalProject_QUANLYKHO.Models;
using FinalProject_QUANLYKHO.Service;
using FinalProject_QUANLYKHO.View.CustomerView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject_QUANLYKHO.View.MaterialView
{
    public partial class ManagerMaterial : Form
    {
        MaterialService materialService = new MaterialService();
        MaterialTypeService materialTypeService = new MaterialTypeService();
        List<Material> materials = new List<Material>();
        List<MaterialType> materialTypes = new List<MaterialType>();
        List<Material> listItemSelected = new List<Material>();
        MaterialType materialTypeSelect = new MaterialType();
        int currentPage = 0;
        int totalPages = 0;
        public ManagerMaterial()
        {
            InitializeComponent();
            initData();
            initDataGirdView();
        }

        public void initData()
        {
            numberPage.SelectedIndex = 0;
            int totalRows = materialService.GetTotalRowMaterial();
            int pageSize = size();
            this.totalPages = (int)Math.Ceiling((double)totalRows / pageSize);
            notifiPagePresent.Text = (currentPage + 1) + " / " + this.totalPages;
        }
        private void initListMaterials()
        {
            if (Active.Checked)
            {
                this.materials = materialService.PageMaterial(currentPage, size(), true);
            }
            else
            {
                this.materials = materialService.PageMaterial(currentPage, size(), false);
            }
        }
        private void initListMaterialsByType()
        {
            if (Active.Checked)
            {
                this.materials = materialService.PageMaterialByType(currentPage, size(), this.materialTypeSelect.tenLoaiNguyenLieu, true);
            }
            else
            {
                this.materials = materialService.PageMaterialByType(currentPage, size(), this.materialTypeSelect.tenLoaiNguyenLieu, false);
            }
        }
        public void initDataGirdView()
        {
            dataGridViewMaterial.Rows.Clear();

            if (this.materialTypeSelect.idLoaiNguyenLieu == "-1" || this.materialTypeSelect.idLoaiNguyenLieu == null)
            {
                initListMaterials();
            }
            else
            {
                initListMaterialsByType();
            }

            MaterialType materialType = new MaterialType();
            materialType.idLoaiNguyenLieu = "-1";
            materialType.tenLoaiNguyenLieu = "Tất cả";

            this.materialTypes.Add(materialType);
            this.materialTypes.AddRange(materialService.GetNameTypeMaterial());

            foreach (Material material in this.materials)
            {
                object[] rowData = new object[] { false, material.idNguyenLieu, material.tenNguyenLieu, material.idLoaiNguyenLieu, material.donVi, material.giaTien, material.sl, material.hien };
                dataGridViewMaterial.Rows.Add(rowData);
            }
            inputTypeMaterial.DataSource = this.materialTypes;
            inputTypeMaterial.DisplayMember = "tenLoaiNguyenLieu";
            inputTypeMaterial.ValueMember = "idLoaiNguyenLieu";
        }

        public void loadDataIntoGirview(List<Material> listData)
        {
            dataGridViewMaterial.Rows.Clear();
            foreach (Material material in listData)
            {
                object[] rowData = new object[] { false, material.idNguyenLieu, material.tenNguyenLieu, material.idLoaiNguyenLieu, material.donVi, material.giaTien, material.sl, material.hien };
                dataGridViewMaterial.Rows.Add(rowData);
            }
        }

        public int size()
        {
            return int.Parse(numberPage.Text);
        }

        private void dataGridViewMaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            string idNguyenLieu = dataGridViewMaterial.Rows[row].Cells[1].Value.ToString();
            Material material = materials.Find(m => m.idNguyenLieu == idNguyenLieu);
            if (material == null) return;

            switch (col)
            {
                case 0:
                    //handle select item 
                    handleSelectItem(row, material);
                    break;
                case 7:
                    //hanel active/deactive item
                    handleActiveDeactiveItem(row, material);
                    break;
                case 8:
                    //handle edit item
                    handleEditItem(row, material);
                    break;
                case 9:

                    //handle rmeve item 
                    handleRemoveItem(row, material);
                    break;
            }
        }

        private void handleEditItem(int row, Material material) { 
            UpdateMaterial updateMaterial = new UpdateMaterial(material);
            updateMaterial.Show();
        }   
        private void handleRemoveItem(int row, Material material)
        {
            if (material == null) return;
            DialogResult result = MessageBox.Show("Bạn có muốn xóa nguyên liệu này không?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bool isRemoved = materialService.Delete(material.idNguyenLieu);
                MessageBox.Show(isRemoved ? "Xóa nguyên liệu thành công" : "Xóa nguyên liệu thất bại!");
                initDataGirdView();
            }
        }
        private void handleActiveDeactiveItem(int row, Material material)
        {
            DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)dataGridViewMaterial.Rows[row].Cells[7];

            if (checkbox == null)
                return;

            bool isChecked = Convert.ToBoolean(checkbox.Value);

            if (isChecked == false)
            {
                materialService.ActiveMaterial(material.idNguyenLieu, !isChecked);

            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn ẩn nguyên liệu này không?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    materialService.ActiveMaterial(material.idNguyenLieu, !isChecked);
                    MessageBox.Show("Ẩn nguyên liệu thành công!");

                }
            }

            initDataGirdView();
            checkbox.Value = !isChecked;
        }


        public void handleSelectItem(int row, Material material)
        {
            if (dataGridViewMaterial.Rows[row].Cells[0].Value == null) return;

            DataGridViewCheckBoxCell checkBox = (DataGridViewCheckBoxCell)dataGridViewMaterial.Rows[row].Cells[0];
            bool isChecked = Convert.ToBoolean(dataGridViewMaterial.Rows[row].Cells[0].Value);
            checkBox.Value = !isChecked;
            if (isChecked)
            {
                listItemSelected = listItemSelected.Where(m => m.idNguyenLieu != material.idNguyenLieu).ToList();
            }
            else
            {
                listItemSelected.Add(material);
            }

        }

        private void btnDeleteSelectItem_Click(object sender, EventArgs e)
        {
            bool isCheckRes = true;
            if (listItemSelected.Count <= 0)
            {
                MessageBox.Show("Bạn chưa chọn nguyên liệu nào để xóa!");

                return;
            }

            foreach (Material material in listItemSelected)
            {
                isCheckRes = isCheckRes && materialService.Delete(material.idNguyenLieu);
            }

            MessageBox.Show(isCheckRes ? "Xóa các nguyên liệu đã chọn thành công!" : "Xóa các nguyên liệu đã chọn thất bại!");
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage + 1 <= totalPages)
            {
                this.currentPage++;
                handleLoadPage();
            }
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (currentPage - 1 >= 0)
            {
                this.currentPage--;
                handleLoadPage();
            }

        }

        private void handleLoadPage()
        {
            notifiPagePresent.Text = (currentPage + 1) + " / " + this.totalPages;
            activeBtnActionNavigatePage();
            initDataGirdView();

        }

        private void activeBtnActionNavigatePage()
        {
            if (currentPage == 0)
            {
                btnPrevPage.Enabled = false;
            }
            else
            {
                btnPrevPage.Enabled = true;
            }

            if (currentPage + 1 == totalPages)
            {
                btnNextPage.Enabled = false;
            }
            else
            {
                btnNextPage.Enabled = true;
            }
        }

        private void inputTypeMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.materialTypeSelect = (MaterialType)inputTypeMaterial.SelectedItem;
            if (this.materialTypeSelect == null) return;


            if (this.materialTypeSelect.idLoaiNguyenLieu == "-1" || this.materialTypeSelect.idLoaiNguyenLieu == null)
            {
                initDataGirdView();
                return;
            }

            int totalRows = materialService.GetTotalRowMaterialByType(this.materialTypeSelect);
            int pageSize = size();
            this.totalPages = (int)Math.Ceiling((double)totalRows / pageSize);
            notifiPagePresent.Text = (currentPage + 1) + " / " + this.totalPages;

            initDataGirdView();
        }

        private void Active_CheckedChanged(object sender, EventArgs e)
        {
            initDataGirdView();
        }

        private void numberPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            initDataGirdView();
        }

        private void timerSearch_Tick(object sender, EventArgs e)
        {
            timerSearch.Stop();
            string key = edtFindMaterial.Text;

            if (key.Equals(""))
            {
                initDataGirdView();
                return;
            };

            List<Material> materials = materialService.FindMaterials(key);

            loadDataIntoGirview(materials);
        }

        private void edtFindMaterial_TextChanged(object sender, EventArgs e)
        {
            timerSearch.Stop();
            timerSearch.Start();
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            ModalAddMaterial addMaterial = new ModalAddMaterial();
            addMaterial.Show();
        }
    }
}
