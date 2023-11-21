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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject_QUANLYKHO.View.MaterialView
{
    public partial class ManagerMaterial : Form
    {
        MaterialService materialService;
        MaterialTypeService materialTypeService;
        public int maxPage = 0;
        public int currentPage = 0;
        public int maxPageType = 0;
        public int currentPageType = 0;
        public bool checkType = false;
        public ManagerMaterial()
        {
            InitializeComponent();
            materialService = new MaterialService();
            materialTypeService = new MaterialTypeService();
            inputTypeMaterial.Items.AddRange(materialService.GetNameTypeMaterial().ToArray());
            numberPage.SelectedIndex = 0;
            LoadDataByPageIntoDataGridView(currentPage, int.Parse(numberPage.Text), Active.Checked);
            SumPage.Text = (currentPage + 1) + "/" + (maxPage + 1);
            btnDeleteSelect.Visible = false;
        }
        public bool checkActive()
        {
            return Active.Checked;
        }
        public int size()
        {
            return int.Parse(numberPage.Text);
        }
        public string key()
        {
            return inputTypeMaterial.Text;
        }
        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            AddMaterial modal = new AddMaterial();
            modal.Show();
        }

        public void AddMaterialIntoGridView(Material material)
        {
            if (material != null)
            {     /* rowData.Append(list[i]);*/
                object[] rowData = new object[] { material.idNguyenLieu, material.idLoaiNguyenLieu, material.tenNguyenLieu, material.donVi, material.giaTien, material.sl, material.hien };
                dataGridViewMaterial.Rows.Add(rowData);
            }

        }
        public void LoadDataByPageAndTypeIntoDataGridView(int page, int size, string key, bool hien)
        {

            dataGridViewMaterial.Rows.Clear();
            if (materialService != null)
            {
                List<Material> list = materialService.PageMaterialByType(page, size, key, hien);
                for (int i = 0; i < list.Count; i++)
                {
                    /* rowData.Append(list[i]);*/
                    Material material = list[i];
                    object[] rowData = new object[] { material.idNguyenLieu, material.idLoaiNguyenLieu, material.tenNguyenLieu, material.donVi, material.giaTien, material.sl, material.hien };
                    dataGridViewMaterial.Rows.Add(rowData);
                }

            }
        }
        public void LoadDataByPageIntoDataGridView(int page, int size, bool hien)
        {

            dataGridViewMaterial.Rows.Clear();
            if (materialService != null)
            {
                List<Material> list = materialService.PageMaterial(page, size, hien);
                for (int i = 0; i < list.Count; i++)
                {
                    /* rowData.Append(list[i]);*/
                    Material material = list[i];
                    object[] rowData = new object[] { material.idNguyenLieu, material.idLoaiNguyenLieu, material.tenNguyenLieu, material.donVi, material.giaTien, material.sl, material.hien };
                    dataGridViewMaterial.Rows.Add(rowData);
                }

            }
        }
        private void dataGridViewMaterial_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dataGridViewMaterial.SelectedRows;
            btnDeleteSelect.Visible = selectedRows.Count > 1;
        }
        private void dataGridViewMaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            int columnIndex = e.ColumnIndex;
            if (e.RowIndex != dataGridViewMaterial.Rows.Count - 1)
            {
                if (columnIndex == 8)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mục này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Kiểm tra xem ô được nhấp vào có hợp lệ không
                        {
                            // Lấy hàng (row) chứa ô được nhấp vào
                            DataGridViewRow selectedRow = dataGridViewMaterial.Rows[e.RowIndex];

                            // Lấy tất cả giá trị của các ô trong hàng và chuyển đổi thành danh sách hoặc mảng
                            List<string> rowData = new List<string>();

                            foreach (DataGridViewCell cell in selectedRow.Cells)
                            {
                                if (cell.Value != null)
                                {
                                    rowData.Add(cell.Value.ToString());
                                }
                                else
                                {
                                    rowData.Add("");
                                }
                            }

                            string idNguyenLieu = rowData[0];
                            string tenNguyenLieu = rowData[2];
                            bool deleteRes = materialService.Delete(idNguyenLieu);

                            if (deleteRes)
                            {
                                MessageBox.Show("Xóa nguyên liệu thành công " + tenNguyenLieu);
                                dataGridViewMaterial.Rows.Remove(selectedRow);
                                if (!string.IsNullOrEmpty(inputTypeMaterial.Text) && checkType == true)
                                {
                                    int selected = int.Parse(numberPage.Text);
                                    NumberPageByType();
                                    if (currentPage > maxPage)
                                    {
                                        currentPage = maxPage;
                                    }
                                    LoadDataByPageAndTypeIntoDataGridView(currentPageType, selected, inputTypeMaterial.Text, Active.Checked);
                                    SumPage.Text = (currentPageType + 1) + "/" + (maxPageType + 1);
                                }
                                else
                                {
                                    int selected = int.Parse(numberPage.Text);
                                    NumberPage();
                                    if (currentPage > maxPage)
                                    {
                                        currentPage = maxPage;
                                    }
                                    LoadDataByPageIntoDataGridView(currentPage, selected, Active.Checked);
                                    SumPage.Text = (currentPage + 1) + "/" + (maxPage + 1);


                                }
                            }
                            else
                            {
                                MessageBox.Show("Xóa nguyên liệu thất bại " + tenNguyenLieu);
                            }
                        }

                    }
                }
                else if (columnIndex == 7)
                {
                    DataGridViewRow selectedRow = dataGridViewMaterial.Rows[e.RowIndex];
                    // Lấy tất cả giá trị của các ô trong hàng và chuyển đổi thành danh sách hoặc mảng
                    List<string> rowData = new List<string>();
                    foreach (DataGridViewCell cell in selectedRow.Cells)
                    {
                        if (cell.Value != null)
                        {
                            rowData.Add(cell.Value.ToString());
                        }
                        else
                        {
                            rowData.Add("");
                        }
                    }


                    List<string> oldData = new List<string>();

                    UpdateMaterial modal = new UpdateMaterial();

                    modal.SetIdMaterialUpdate(rowData[0]);
                    oldData.Add(rowData[1]);
                    oldData.Add(rowData[2]);
                    oldData.Add(rowData[3]);
                    oldData.Add(rowData[4]);
                    oldData.Add(rowData[5]);
                    modal = new UpdateMaterial(oldData);

                    modal.Show();

                }
                else if (columnIndex == 6)
                {
                    DataGridViewCheckBoxCell checkBoxCell = dataGridViewMaterial["Column4", e.RowIndex] as DataGridViewCheckBoxCell;
                    if (checkBoxCell != null)
                    {

                        bool currentValue = (bool)checkBoxCell.Value;
                        if (currentValue == true)
                        {
                            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn ẩn mục này?", "Xác nhận ẩn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                checkBoxCell.Value = false;
                                DataGridViewRow selectedRow = dataGridViewMaterial.Rows[e.RowIndex];

                                // Lấy tất cả giá trị của các ô trong hàng và chuyển đổi thành danh sách hoặc mảng
                                List<string> rowData = new List<string>();

                                foreach (DataGridViewCell cell in selectedRow.Cells)
                                {
                                    if (cell.Value != null)
                                    {
                                        rowData.Add(cell.Value.ToString());
                                    }
                                    else
                                    {
                                        rowData.Add("");
                                    }
                                }
                                string idNguyenLieu = rowData[0];
                                materialService.ActiveMaterial(idNguyenLieu, (bool)checkBoxCell.Value);
                                string tenNguyenLieu = rowData[2];

                                MessageBox.Show("Ẩn nguyên liệu thành công " + tenNguyenLieu);
                                if (!string.IsNullOrEmpty(inputTypeMaterial.Text) && checkType == true)
                                {
                                    int selected = int.Parse(numberPage.Text);
                                    LoadDataByPageAndTypeIntoDataGridView(currentPageType, selected, inputTypeMaterial.Text, Active.Checked);
                                    SumPage.Text = (currentPageType + 1) + "/" + (maxPageType + 1);
                                }
                                else
                                {
                                    int selected = int.Parse(numberPage.Text);
                                    LoadDataByPageIntoDataGridView(currentPage, selected, Active.Checked);
                                    SumPage.Text = (currentPage + 1) + "/" + (maxPage + 1);


                                }
                            }

                        }
                        else if (currentValue == false)
                        {
                            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hiện mục này?", "Xác nhận hiện", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                checkBoxCell.Value = true;
                                DataGridViewRow selectedRow = dataGridViewMaterial.Rows[e.RowIndex];

                                // Lấy tất cả giá trị của các ô trong hàng và chuyển đổi thành danh sách hoặc mảng
                                List<string> rowData = new List<string>();

                                foreach (DataGridViewCell cell in selectedRow.Cells)
                                {
                                    if (cell.Value != null)
                                    {
                                        rowData.Add(cell.Value.ToString());
                                    }
                                    else
                                    {
                                        rowData.Add("");
                                    }
                                }

                                string idNguyenLieu = rowData[0];
                                materialService.ActiveMaterial(idNguyenLieu, (bool)checkBoxCell.Value);
                                string tenNguyenLieu = rowData[2];

                                MessageBox.Show("Tắt ẩn nguyên liệu thành công " + tenNguyenLieu);
                                if (!string.IsNullOrEmpty(inputTypeMaterial.Text) && checkType == true)
                                {
                                    int selected = int.Parse(numberPage.Text);
                                    NumberPageByType();
                                    LoadDataByPageAndTypeIntoDataGridView(currentPageType, selected, inputTypeMaterial.Text, Active.Checked);
                                    SumPage.Text = (currentPageType + 1) + "/" + (maxPageType + 1);
                                }
                                else
                                {
                                    int selected = int.Parse(numberPage.Text);
                                    NumberPage();
                                    LoadDataByPageIntoDataGridView(currentPage, selected, Active.Checked);
                                    SumPage.Text = (currentPage + 1) + "/" + (maxPage + 1);


                                }
                            }

                        }
                        // Thay đổi giá trị CheckBox
                        //checkBoxCell.Value = !currentValue;
                        // Điều gì xảy ra khi CheckBox thay đổi

                        if (!currentValue)
                        {
                            // CheckBox được bật lên
                            // Thực hiện xử lý khi kiểm hoặc (checked)
                        }
                        else
                        {
                            // CheckBox bị tắt (unchecked)
                            // Thực hiện xử lý khi bỏ kiểm
                        }
                    }
                }
            }
            
        }
        private void edtFindMaterial_TextChanged(object sender, EventArgs e)
        {
            string searchText = edtFindMaterial.Text;
            if (string.IsNullOrEmpty(searchText) && string.IsNullOrEmpty(inputTypeMaterial.Text))
            {
                LoadDataByPageIntoDataGridView(currentPage, int.Parse(numberPage.Text), Active.Checked);
            }
            else
            {
                dataGridViewMaterial.Rows.Clear();
                if (materialService != null)
                {
                    List<Material> list = materialService.FindMaterials(searchText.ToString());
                    foreach (Material material in list)
                    {
                        object[] rowData = new object[] { material.idNguyenLieu, material.idLoaiNguyenLieu, material.tenNguyenLieu, material.donVi, material.giaTien, material.sl, material.hien };
                        dataGridViewMaterial.Rows.Add(rowData);
                    }
                }
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            edtFindMaterial.Text = "";
            if (!string.IsNullOrEmpty(inputTypeMaterial.Text) && checkType == true)
            {
                numberPage.SelectedIndex = 0;
                int selected = int.Parse(numberPage.Text);
                NumberPageByType();
                currentPageType = 0;
                LoadDataByPageAndTypeIntoDataGridView(currentPageType, selected, inputTypeMaterial.Text, Active.Checked);
                SumPage.Text = (currentPageType + 1) + "/" + (maxPageType + 1);
            }
            else
            {
                numberPage.SelectedIndex = 0;
                int selected = int.Parse(numberPage.Text);
                NumberPage();
                currentPage = 0;
                LoadDataByPageIntoDataGridView(currentPage, selected, Active.Checked);
                SumPage.Text = (currentPage + 1) + "/" + (maxPage + 1);

            }
        }


        private void Active_CheckedChanged(object sender, EventArgs e)
        {
            bool isOn = Active.Checked;
            if (!string.IsNullOrEmpty(inputTypeMaterial.Text) && checkType == true)
            {
                numberPage.SelectedIndex = 0;
                int selected = int.Parse(numberPage.Text);
                NumberPageByType();
                currentPageType = 0;
                LoadDataByPageAndTypeIntoDataGridView(currentPageType, selected, inputTypeMaterial.Text, isOn);
                SumPage.Text = (currentPageType + 1) + "/" + (maxPageType + 1);
            }
            else
            {
                numberPage.SelectedIndex = 0;
                int selected = int.Parse(numberPage.Text);
                NumberPage();
                currentPage = 0;
                LoadDataByPageIntoDataGridView(currentPage, selected, isOn);
                SumPage.Text = (currentPage + 1) + "/" + (maxPage + 1);

            }



        }
        public void NumberPage()
        {
            maxPage = 0;
            for (int i = int.Parse(numberPage.Text); i < materialService.GetAll(Active.Checked).Count; i += int.Parse(numberPage.Text))
            {
                this.maxPage++;
            }
        }
        public void NumberPageByType()
        {
            maxPageType = 0;
            for (int i = int.Parse(numberPage.Text); i < materialService.GetAllByType(inputTypeMaterial.Text, Active.Checked).Count; i += int.Parse(numberPage.Text))
            {
                this.maxPageType++;
            }
            MessageBox.Show(maxPageType.ToString());

        }
        private void btnAfter_Click(object sender, EventArgs e)
        {
            //materialService.PageMaterial();
            if (!string.IsNullOrEmpty(inputTypeMaterial.Text) && checkType == true)
            {
                if (currentPageType < maxPageType)
                {
                    currentPageType++;
                    int selected = int.Parse(numberPage.Text);
                    LoadDataByPageAndTypeIntoDataGridView(currentPageType, selected, inputTypeMaterial.Text, Active.Checked);
                    SumPage.Text = (currentPageType + 1) + "/" + (maxPageType + 1);
                }
            }
            else
            {
                if (currentPage < maxPage)
                {
                    currentPage++;
                    int selected = int.Parse(numberPage.Text);
                    LoadDataByPageIntoDataGridView(currentPage, selected, Active.Checked);
                    SumPage.Text = (currentPage + 1) + "/" + (maxPage + 1);

                }

            }


        }
        private void numberPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inputTypeMaterial.Text) && checkType == true)
            {
                int selected = int.Parse(numberPage.Text);
                NumberPageByType();
                LoadDataByPageAndTypeIntoDataGridView(currentPageType, selected, inputTypeMaterial.Text, Active.Checked);
                SumPage.Text = (currentPageType + 1) + "/" + (maxPageType + 1);
            }
            else
            {
                int selected = int.Parse(numberPage.Text);
                NumberPage();
                currentPage = 0;
                LoadDataByPageIntoDataGridView(currentPage, selected, Active.Checked);
                SumPage.Text = (currentPage + 1) + "/" + (maxPage + 1);

            }

        }
        private void btnBefore_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(inputTypeMaterial.Text) && checkType == true)
            {
                if (currentPageType > 0)
                {
                    currentPageType--;
                    int selected = int.Parse(numberPage.Text);
                    LoadDataByPageAndTypeIntoDataGridView(currentPageType, selected, inputTypeMaterial.Text, Active.Checked);
                    SumPage.Text = (currentPageType + 1) + "/" + (maxPageType + 1);
                }
            }
            else
            {
                if (currentPage > 0)
                {
                    currentPage--;
                    int selected = int.Parse(numberPage.Text);
                    LoadDataByPageIntoDataGridView(currentPage, selected, Active.Checked);
                    SumPage.Text = (currentPage + 1) + "/" + (maxPage + 1);
                }

            }

        }
        private void btnTreatment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputTypeMaterial.Text))
            {
                return;
            }
            else
            {
                int selected = int.Parse(numberPage.Text);
                for (int i = 0; i < inputTypeMaterial.Items.Count; i++)
                {
                    if (inputTypeMaterial.Text == inputTypeMaterial.Items[i].ToString())
                    {
                        maxPageType = 0;
                        checkType = true;
                        currentPageType = 0;
                        NumberPageByType();
                        LoadDataByPageAndTypeIntoDataGridView(currentPageType, selected, inputTypeMaterial.Text, Active.Checked);
                        SumPage.Text = (currentPageType + 1) + "/" + (maxPageType + 1);
                    }
                }
            }
        }
        private void btnRefreshType_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputTypeMaterial.Text))
            {
                return;
            }
            currentPage = 0;
            maxPage = 0;
            currentPageType = 0;
            maxPageType = 0;
            numberPage.SelectedIndex = 0;
            NumberPage();
            LoadDataByPageIntoDataGridView(currentPage, int.Parse(numberPage.Text), Active.Checked);
            SumPage.Text = (currentPage + 1) + "/" + (maxPage + 1);
            checkType = false;
            inputTypeMaterial.Text = "";
        }

        private void btnDeleteSelect_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tất cả mục này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DataGridViewSelectedRowCollection selectedRows = dataGridViewMaterial.SelectedRows;
                DataGridViewRow lastSelectedRow = selectedRows[selectedRows.Count - 1];
                foreach (DataGridViewRow selectedRow in selectedRows)
                {

                    if (selectedRow != lastSelectedRow)
                    {
                        string idNguyenLieu = selectedRow.Cells[0].Value.ToString();
                        materialService.Delete(idNguyenLieu);
                        if (!string.IsNullOrEmpty(inputTypeMaterial.Text) && checkType == true)
                        {
                            int selected = int.Parse(numberPage.Text);
                            NumberPageByType();
                            if (currentPage > maxPage)
                            {
                                currentPage = maxPage;
                            }
                            LoadDataByPageAndTypeIntoDataGridView(currentPageType, selected, inputTypeMaterial.Text, Active.Checked);
                            SumPage.Text = (currentPageType + 1) + "/" + (maxPageType + 1);
                        }
                        else
                        {
                            int selected = int.Parse(numberPage.Text);
                            NumberPage();
                            if (currentPage > maxPage)
                            {
                                currentPage = maxPage;
                            }
                            LoadDataByPageIntoDataGridView(currentPage, selected, Active.Checked);
                            SumPage.Text = (currentPage + 1) + "/" + (maxPage + 1);


                        }
                    }
                    
                }
                MessageBox.Show("Xóa nguyên liệu thành công");

            }
        }
 
    }
}
