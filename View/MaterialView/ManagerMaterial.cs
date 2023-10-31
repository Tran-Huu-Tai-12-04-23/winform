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

namespace FinalProject_QUANLYKHO.View.MaterialView
{
    public partial class ManagerMaterial : Form
    {
        MaterialService materialService;
        public ManagerMaterial()
        {
            InitializeComponent();
            materialService = new MaterialService();
            LoadDataIntoDataGridView();
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
                object[] rowData = new object[] { material.idNguyenLieu, material.tenLoaiNguyenLieu, material.tenNguyenLieu, material.donVi, material.giaTien, material.sl, material.hien };
                dataGridViewMaterial.Rows.Add(rowData);
            }

        }
        public void LoadDataIntoDataGridView()
        {

            dataGridViewMaterial.Rows.Clear();
            if (materialService != null)
            {
                List<Material> list = materialService.GetAll();
                for (int i = 0; i < list.Count; i++)
                {
                    /* rowData.Append(list[i]);*/
                    Material material = list[i];
                    object[] rowData = new object[] { material.idNguyenLieu, material.tenLoaiNguyenLieu, material.tenNguyenLieu, material.donVi, material.giaTien, material.sl, material.hien };
                    dataGridViewMaterial.Rows.Add(rowData);
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelCustom6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewMaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            DataGridViewSelectedRowCollection selectedRows = dataGridViewMaterial.SelectedRows;
            int columnIndex = e.ColumnIndex;
            if (columnIndex ==8)
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

                        string idNguyenLieu= rowData[0];
                        string tenNguyenLieu = rowData[2];  
                        bool deleteRes = materialService.Delete(idNguyenLieu);

                        if (deleteRes)
                        {
                            MessageBox.Show("Xóa khách hành thành công " + tenNguyenLieu);
                            dataGridViewMaterial.Rows.Remove(selectedRow);
                        }
                        else
                        {
                            MessageBox.Show("Xóa khách hàng thất bại " + tenNguyenLieu);
                        }


                    }

                }
            }
        }
    }
}
