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
using FinalProject_QUANLYKHO.View.MaterialView;

namespace FinalProject_QUANLYKHO.View.BakeView
{
    public partial class ManagerBake : Form
    {
        BakeService bakeService = new BakeService();
        BakeTypeService bakeTypeService = new BakeTypeService();
        List<Bake> bakes = new List<Bake>();
        List<BakeType> baketypes = new List<BakeType>();
        List<Bake> listItemSelected = new List<Bake>();
        BakeType bakeTypeSelect = new BakeType();
        int currentPage = 0;
        int totalPages;

        public ManagerBake()
        {
            InitializeComponent();
            initData();
            initDataGirdView();
        }

        public void initData()
        {
            amountRowShow.SelectedIndex = 0;
            bool active = (Active.Checked);
            int totalRows = bakeService.GetTotalRowBakeByState(!active);
            int pageSize = size();
            this.totalPages = (int)Math.Ceiling((double)totalRows / pageSize);
            notifiPagePresent.Text = (currentPage + 1) + " / " + this.totalPages;
        }

        public void initDataGirdView()
        {
            dataGridViewBake.Rows.Clear();

            if (this.bakeTypeSelect.idLoaiBanh == "-1" || this.bakeTypeSelect.idLoaiBanh == null)
            {
                initListBake();
            }
            else
            {
                initListBakeByType();
            }

            BakeType bakeType = new BakeType();
            bakeType.idLoaiBanh = "-1";
            bakeType.tenLoaiBanh = "Tất cả";

            this.baketypes.Add(bakeType);
            this.baketypes.AddRange(bakeService.GetNameTypeBake());

            foreach (Bake bake in this.bakes)
            {
                object[] rowData = new object[] { false, bake.idBanh, bake.tenBanh, bake.idLoaiBanh, bake.donVi, bake.giaTien, bake.sl, bake.hien };
                dataGridViewBake.Rows.Add(rowData);
            }
            inputTypebake.DataSource = this.baketypes;
            inputTypebake.DisplayMember = "tenLoaiBanh";
            inputTypebake.ValueMember = "idLoaiBanh";
        }

        public void loadDataIntoGirview(List<Bake> listData)
        {
            dataGridViewBake.Rows.Clear();
            foreach (Bake bake in listData)
            {
                object[] rowData = new object[] { false, bake.idBanh, bake.tenBanh, bake.idLoaiBanh, bake.donVi, bake.giaTien, bake.sl, bake.hien };
                dataGridViewBake.Rows.Add(rowData);
            }
        }
        private void initListBake()
        {
            this.bakes = bakeService.PageBake(currentPage, size(), Active.Checked);
        }
        private void initListBakeByType()
        {
            this.bakes = bakeService.PageBakeByType(currentPage, size(), this.bakeTypeSelect.tenLoaiBanh, Active.Checked);


        }

        public int size()
        {
            return int.Parse(amountRowShow.Text);
        }

        private void Active_CheckedChanged(object sender, EventArgs e)
        {
            initDataGirdView();
        }

        private void dataGridViewBake_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            string idBanh = dataGridViewBake.Rows[row].Cells[1].Value.ToString();
            Bake bake = bakes.Find(m => m.idBanh == idBanh);
            if (bake == null) return;

            switch (col)
            {
                case 0:
                    //handle select item 
                    handleSelectItem(row, bake);
                    break;
                case 7:
                    //hanel active/deactive item
                    handleActiveDeactiveItem(row, bake);
                    break;
                case 8:
                    //handle edit item
                    handleEditItem(row, bake);
                    break;
                case 9:

                    //handle rmeve item 
                    handleRemoveItem(row, bake);
                    break;
            }
        }
        private void handleEditItem(int row, Bake bake)
        {
            UpdateBake updateBake  = new UpdateBake(bake);
            updateBake.Show();
        }
        private void handleRemoveItem(int row, Bake bake)
        {
            if (bake == null) return;
            DialogResult result = MessageBox.Show("Bạn có muốn xóa bánh này không?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bool isRemoved = bakeService.Delete(bake.idBanh);
                MessageBox.Show(isRemoved ? "Xóa bánh thành công" : "Xóa bánh thất bại!");
                initDataGirdView();
            }
        }
        private void handleActiveDeactiveItem(int row, Bake bake)
        {
            DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)dataGridViewBake.Rows[row].Cells[7];

            if (checkbox == null)
                return;

            bool isChecked = Convert.ToBoolean(checkbox.Value);

            if (isChecked == false)
            {
                bakeService.ActiveBake(bake.idBanh, !isChecked);

            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn ẩn bánh này không?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show(bake.idBanh);
                    bakeService.ActiveBake(bake.idBanh, !isChecked);
                    MessageBox.Show("Ẩn bánh thành công!");

                }
            }

            initDataGirdView();
            checkbox.Value = !isChecked;
        }


        public void handleSelectItem(int row, Bake bake)
        {
            if (dataGridViewBake.Rows[row].Cells[0].Value == null) return;

            DataGridViewCheckBoxCell checkBox = (DataGridViewCheckBoxCell)dataGridViewBake.Rows[row].Cells[0];
            bool isChecked = Convert.ToBoolean(dataGridViewBake.Rows[row].Cells[0].Value);
            checkBox.Value = !isChecked;
            if (isChecked)
            {
                listItemSelected = listItemSelected.Where(m => m.idBanh != bake.idBanh).ToList();
            }
            else
            {
                listItemSelected.Add(bake);
            }

        }

        private void buttonCustom2_Click(object sender, EventArgs e)
        {
            bool isCheckRes = true;
            if (listItemSelected.Count <= 0)
            {
                MessageBox.Show("Bạn chưa chọn bánh nào để xóa!");

                return;
            }
            DialogResult result = MessageBox.Show("Bạn có muốn xóa các bánh được chọn?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                foreach (Bake bake in listItemSelected)
                {
                    isCheckRes = isCheckRes && bakeService.Delete(bake.idBanh);
                }
                if (isCheckRes)
                {
                    initDataGirdView();
                }

                MessageBox.Show(isCheckRes ? "Xóa các bánh đã chọn thành công!" : "Xóa các bánh đã chọn thất bại!");
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage + 1 <= totalPages)
            {
                this.currentPage++;
                handleLoadPage();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
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

        private void inputTypebake_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.bakeTypeSelect = (BakeType)inputTypebake.SelectedItem;
            if (this.bakeTypeSelect == null) return;


            if (this.bakeTypeSelect.idLoaiBanh == "-1" || this.bakeTypeSelect.idLoaiBanh == null)
            {
                initDataGirdView();
                return;
            }

            int totalRows = bakeService.GetTotalRowBakeByType(this.bakeTypeSelect);
            int pageSize = size();
            this.totalPages = (int)Math.Ceiling((double)totalRows / pageSize);
            notifiPagePresent.Text = (currentPage + 1) + " / " + this.totalPages;

            initDataGirdView();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

            List<Bake> bakes = bakeService.FindBakes(key);

            loadDataIntoGirview(bakes);
        }

        private void edtFindMaterial_TextChanged(object sender, EventArgs e)
        {
            timerSearch.Stop();
            timerSearch.Start();
        }

        private void buttonCustom1_Click(object sender, EventArgs e)
        {
            AddBake addBake = new AddBake();
            addBake.Show();
        }
    }
}
