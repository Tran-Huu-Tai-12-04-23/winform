using FinalProject_QUANLYKHO.Models;
using FinalProject_QUANLYKHO.Service;
using FinalProject_QUANLYKHO.View.CustomerView;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject_QUANLYKHO.View.BakeView
{
    public partial class ManagerBake : Form
    {
        BakeService bakeService;
        BakeTypeService bakeTypeService;
        public int maxPage = 0;
        public int currentPage = 0;
        public int maxPageType = 0;
        public int currentPageType = 0;
        public bool checkType = false;
        public ManagerBake()
        {
            InitializeComponent();
            bakeService = new BakeService();
            bakeTypeService = new BakeTypeService();
            inputTypeBake.Items.AddRange(bakeService.GetNameTypeBake().ToArray());
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
            return inputTypeBake.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddBake_Click(object sender, EventArgs e)
        {
            AddBake modal = new AddBake();
            modal.Show();
        }
        public void AddBakeIntoGridView(Bake bake)
        {
            if (bake != null)
            {     /* rowData.Append(list[i]);*/
                object[] rowData = new object[] { bake.idBanh, bake.idLoaiBanh, bake.tenBanh, bake.donVi, bake.giaTien, bake.sl, bake.hien };
                dataGridViewBake.Rows.Add(rowData);
            }

        }
        public void LoadDataByPageAndTypeIntoDataGridView(int page, int size, string key, bool hien)
        {

            dataGridViewBake.Rows.Clear();
            if (bakeService != null)
            {
                List<Bake> list = bakeService.PageBakeByType(page, size, key, hien);
                for (int i = 0; i < list.Count; i++)
                {
                    /* rowData.Append(list[i]);*/
                    Bake bake = list[i];
                    object[] rowData = new object[] { bake.idBanh, bake.idLoaiBanh, bake.tenBanh, bake.donVi, bake.giaTien, bake.sl, bake.hien };
                    dataGridViewBake.Rows.Add(rowData);
                }

            }
        }
        public void LoadDataByPageIntoDataGridView(int page, int size, bool hien)
        {

            dataGridViewBake.Rows.Clear();
            if (bakeService != null)
            {
                List<Bake> list = bakeService.PageBake(page, size, hien);
                for (int i = 0; i < list.Count; i++)
                {
                    /* rowData.Append(list[i]);*/
                    Bake bake = list[i];
                    object[] rowData = new object[] { bake.idBanh, bake.idLoaiBanh, bake.tenBanh, bake.donVi, bake.giaTien, bake.sl, bake.hien };
                    dataGridViewBake.Rows.Add(rowData);
                }

            }
        }
        private void dataGridViewBake_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dataGridViewBake.SelectedRows;
            btnDeleteSelect.Visible = selectedRows.Count > 1;
        }

        private void dataGridViewBake_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            if (columnIndex == 8)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mục này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Kiểm tra xem ô được nhấp vào có hợp lệ không
                    {
                        // Lấy hàng (row) chứa ô được nhấp vào
                        DataGridViewRow selectedRow = dataGridViewBake.Rows[e.RowIndex];

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

                        string idBanh = rowData[0];
                        string tenBanh = rowData[2];
                        bool deleteRes = bakeService.Delete(idBanh);

                        if (deleteRes)
                        {
                            MessageBox.Show("Xóa bánh thành công " + tenBanh);
                            dataGridViewBake.Rows.Remove(selectedRow);
                            if (!string.IsNullOrEmpty(inputTypeBake.Text) && checkType == true)
                            {
                                int selected = int.Parse(numberPage.Text);
                                NumberPageByType();
                                if (currentPage > maxPage)
                                {
                                    currentPage = maxPage;
                                }
                                LoadDataByPageAndTypeIntoDataGridView(currentPageType, selected, inputTypeBake.Text, Active.Checked);
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
                            MessageBox.Show("Xóa bánh thất bại " + tenBanh);
                        }
                    }

                }
            }
            else if (columnIndex == 7)
            {
                DataGridViewRow selectedRow = dataGridViewBake.Rows[e.RowIndex];
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

                UpdateBake modal = new UpdateBake();

                /*                modal.SetIdBakeUpdate(rowData[0]);
                */
                oldData.Add(rowData[0]);
                oldData.Add(rowData[1]);
                oldData.Add(rowData[2]);
                oldData.Add(rowData[3]);
                oldData.Add(rowData[4]);
                oldData.Add(rowData[5]);
                modal = new UpdateBake(oldData);

                modal.Show();

            }
            else if (columnIndex == 6)
            {
                DataGridViewCheckBoxCell checkBoxCell = dataGridViewBake["Column4", e.RowIndex] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null)
                {

                    bool currentValue = (bool)checkBoxCell.Value;
                    if (currentValue == true)
                    {
                        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn ẩn mục này?", "Xác nhận ẩn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            checkBoxCell.Value = false;
                            DataGridViewRow selectedRow = dataGridViewBake.Rows[e.RowIndex];

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
                            string idBanh = rowData[0];
                            bakeService.ActiveBake(idBanh, (bool)checkBoxCell.Value);
                            string tenBanh = rowData[2];

                            MessageBox.Show("Ẩn bánh thành công " + tenBanh);
                            if (!string.IsNullOrEmpty(inputTypeBake.Text) && checkType == true)
                            {
                                int selected = int.Parse(numberPage.Text);
                                LoadDataByPageAndTypeIntoDataGridView(currentPageType, selected, inputTypeBake.Text, Active.Checked);
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
                            DataGridViewRow selectedRow = dataGridViewBake.Rows[e.RowIndex];

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

                            string idBanh = rowData[0];
                            bakeService.ActiveBake(idBanh, (bool)checkBoxCell.Value);
                            string tenBanh = rowData[2];

                            MessageBox.Show("Tắt ẩn bánh thành công " + tenBanh);
                            if (!string.IsNullOrEmpty(inputTypeBake.Text) && checkType == true)
                            {
                                int selected = int.Parse(numberPage.Text);
                                NumberPageByType();
                                LoadDataByPageAndTypeIntoDataGridView(currentPageType, selected, inputTypeBake.Text, Active.Checked);
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
        private void edtFindBake_TextChanged(object sender, EventArgs e)
        {
            string searchText = edtFindBake.Text;
            if (string.IsNullOrEmpty(searchText) && string.IsNullOrEmpty(inputTypeBake.Text))
            {
                LoadDataByPageIntoDataGridView(currentPage, int.Parse(numberPage.Text), Active.Checked);
            }
            else
            {
                dataGridViewBake.Rows.Clear();
                if (bakeService != null)
                {
                    List<Bake> list = bakeService.FindBakes(searchText.ToString());
                    foreach (Bake bake in list)
                    {
                        object[] rowData = new object[] { bake.idBanh, bake.idLoaiBanh, bake.tenBanh, bake.donVi, bake.giaTien, bake.sl, bake.hien };
                        dataGridViewBake.Rows.Add(rowData);
                    }
                }
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            edtFindBake.Text = "";
            if (!string.IsNullOrEmpty(inputTypeBake.Text) && checkType == true)
            {
                numberPage.SelectedIndex = 0;
                int selected = int.Parse(numberPage.Text);
                NumberPageByType();
                currentPageType = 0;
                LoadDataByPageAndTypeIntoDataGridView(currentPageType, selected, inputTypeBake.Text, Active.Checked);
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
            if (!string.IsNullOrEmpty(inputTypeBake.Text) && checkType == true)
            {
                numberPage.SelectedIndex = 0;
                int selected = int.Parse(numberPage.Text);
                NumberPageByType();
                currentPageType = 0;
                LoadDataByPageAndTypeIntoDataGridView(currentPageType, selected, inputTypeBake.Text, isOn);
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
            for (int i = int.Parse(numberPage.Text); i < bakeService.GetAll(Active.Checked).Count; i += int.Parse(numberPage.Text))
            {
                this.maxPage++;
            }
        }
        public void NumberPageByType()
        {
            maxPageType = 0;
            for (int i = int.Parse(numberPage.Text); i < bakeService.GetAllByType(inputTypeBake.Text, Active.Checked).Count; i += int.Parse(numberPage.Text))
            {
                this.maxPageType++;
            }

        }

        private void btnAfter_Click(object sender, EventArgs e)
        {
            //bakeService.PageBake();
            if (!string.IsNullOrEmpty(inputTypeBake.Text) && checkType == true)
            {
                if (currentPageType < maxPageType)
                {
                    currentPageType++;
                    int selected = int.Parse(numberPage.Text);
                    LoadDataByPageAndTypeIntoDataGridView(currentPageType, selected, inputTypeBake.Text, Active.Checked);
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
            if (!string.IsNullOrEmpty(inputTypeBake.Text) && checkType == true)
            {
                int selected = int.Parse(numberPage.Text);
                NumberPageByType();
                LoadDataByPageAndTypeIntoDataGridView(currentPageType, selected, inputTypeBake.Text, Active.Checked);
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
            if (!string.IsNullOrEmpty(inputTypeBake.Text) && checkType == true)
            {
                if (currentPageType > 0)
                {
                    currentPageType--;
                    int selected = int.Parse(numberPage.Text);
                    LoadDataByPageAndTypeIntoDataGridView(currentPageType, selected, inputTypeBake.Text, Active.Checked);
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
            if (string.IsNullOrEmpty(inputTypeBake.Text))
            {
                return;
            }
            else
            {
                int selected = int.Parse(numberPage.Text);
                for (int i = 0; i < inputTypeBake.Items.Count; i++)
                {
                    if (inputTypeBake.Text == inputTypeBake.Items[i].ToString())
                    {
                        maxPageType = 0;
                        checkType = true;
                        currentPageType = 0;
                        NumberPageByType();
                        LoadDataByPageAndTypeIntoDataGridView(currentPageType, selected, inputTypeBake.Text, Active.Checked);
                        SumPage.Text = (currentPageType + 1) + "/" + (maxPageType + 1);
                    }
                }
            }
        }

        private void btnRefreshType_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputTypeBake.Text))
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
            inputTypeBake.Text = "";
        }

        private void btnDeleteSelect_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tất cả mục này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow selectedRow in dataGridViewBake.SelectedRows)
                {
                    if (string.IsNullOrEmpty(selectedRow.Cells[0].Value.ToString()))
                    {
                        continue;
                    }

                    string idBanh = selectedRow.Cells[0].Value.ToString();
                    bakeService.Delete(idBanh);
                    if (!string.IsNullOrEmpty(inputTypeBake.Text) && checkType == true)
                    {
                        int selected = int.Parse(numberPage.Text);
                        NumberPageByType();
                        if (currentPage > maxPage)
                        {
                            currentPage = maxPage;
                        }
                        LoadDataByPageAndTypeIntoDataGridView(currentPageType, selected, inputTypeBake.Text, Active.Checked);
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
                MessageBox.Show("Xóa bánh thành công");

            }
        }
    }
}
