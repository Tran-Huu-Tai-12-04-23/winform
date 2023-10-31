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

namespace FinalProject_QUANLYKHO.View.BakeView
{
    public partial class ManagerBake : Form
    {
        private BakeService bakeService;
        public ManagerBake()
        {
            InitializeComponent();
            bakeService = new BakeService();
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {

            dataGridViewBake.Rows.Clear();
            if (bakeService != null)
            {
                List<Bake> list = bakeService.GetAll();
                for (int i = 0; i < list.Count; i++)
                {
                    /* rowData.Append(list[i]);*/
                    Bake bake = list[i];
                    object[] rowData = new object[] { bake.maBanh, bake.tenBanh, bake.soLuong, bake.giaTien, bake.donVi, bake.maLoaiBanh, bake.hien };
                    dataGridViewBake.Rows.Add(rowData);
                }
            }
        }

        public void AddBakeIntoGridView(Bake bake)
        {
            if (bake != null)
            {     /* rowData.Append(list[i]);*/
                object[] rowData = new object[] { bake.maBanh, bake.tenBanh, bake.soLuong, bake.giaTien, bake.donVi, bake.maLoaiBanh, bake.hien };
                dataGridViewBake.Rows.Add(rowData);
            }

        }

        private void label5Loc_Click(object sender, EventArgs e)
        {

        }

        private void buttonCustom4_Click(object sender, EventArgs e)
        {
            AddBakeForm addBakeForm = new AddBakeForm();
            addBakeForm.Show();
        }

        private void dataGridViewBake_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManagerBake_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

                    Bake bake = new Bake();
                    bake.maBanh = rowData[0].ToString();
                    bake.tenBanh = rowData[1];
                    bake.soLuong = Int32.Parse(rowData[2]);
                    bake.giaTien = float.Parse(rowData[3]);
                    bake.donVi = rowData[4];
                    bake.maLoaiBanh = rowData[5];

                    bool deleteRes = bakeService.Delete(bake.maBanh);

                    if (deleteRes)
                    {
                        MessageBox.Show("Xóa bánh thành công " + bake.tenBanh);
                        dataGridViewBake.Rows.Remove(selectedRow);
                    }
                    else
                    {
                        MessageBox.Show("Xóa bánh thất bại " + bake.tenBanh);
                    }


                }

            }
        }
    }
}
