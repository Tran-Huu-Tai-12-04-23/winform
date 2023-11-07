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

namespace FinalProject_QUANLYKHO.View.DecentralizationView
{
    public partial class ManagerDecentralization : Form
    {
        private List<Decentralization> listData;
        private DecentralizationService decentralizationService;
        public ManagerDecentralization()
        {
            decentralizationService = new DecentralizationService();
            InitializeComponent();
            listData = new List<Decentralization>();
            GetData();
            LoadData();



        }

        public void GetData()
        {
            listData = decentralizationService.GetAll();
        }
        public void LoadData()
        {
            foreach (Decentralization decen in listData)
            {
                AddDecenIntoGridView(decen);
            }
        }

        public void AddDecenIntoGridView(Decentralization decentralization)
        {


            if (decentralization != null)
            {
                object[] rowData = new object[] { decentralization.idPhanQuyen, decentralization.tentaikhoan, decentralization.ngayBatDau, decentralization.ngayKetThuc, decentralization.quyenThem == true ? "Cho phép" : "Không cho phép", decentralization.quyenSua ? "Cho phép" : "Không cho phép", decentralization.quyenXoa ? "Cho phép" : "Không cho phép" };
                dataGridViewDecentralization.Rows.Add(rowData);
            }

        }

        private void dataGridViewDecentralization_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Kiểm tra xem ô được nhấp vào có hợp lệ không
            {
                // Lấy hàng (row) chứa ô được nhấp vào
                DataGridViewRow selectedRow = dataGridViewDecentralization.Rows[e.RowIndex];
                int selectedColumn = e.ColumnIndex;

                List<string> rowData = new List<string>();

                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    if (cell.Value != null)
                    {
                        rowData.Add(cell.Value.ToString());
                    }
                    else
                    {

                    }
                    {
                        rowData.Add("");
                    }
                }
                Decentralization decentralization = new Decentralization();
                decentralization.idPhanQuyen = rowData[1];
                decentralization.tentaikhoan = rowData[2];

                if (!string.IsNullOrEmpty(rowData[3]))
                {
                    if (DateTime.TryParse(rowData[3], out DateTime ngayBatDau))
                    {
                        decentralization.ngayBatDau = ngayBatDau;
                    }
                }

                if (!string.IsNullOrEmpty(rowData[4]))
                {
                    if (DateTime.TryParse(rowData[4], out DateTime ngayKetThuc))
                    {
                        decentralization.ngayKetThuc = ngayKetThuc;
                    }
                }

                decentralization.quyenThem = rowData[5] == "Cho phép";
                decentralization.quyenSua = rowData[6] == "Cho phép";
                decentralization.quyenXoa = rowData[7] == "Cho phép";

                switch (selectedColumn)
                {
                    case 7:
                        {
                            ModalEditDecentralization modalEditDecentralization = new ModalEditDecentralization(decentralization);
                            modalEditDecentralization.Show();
                            break;
                        }
                    case 8:
                        {
                            /* DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mục này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                             *//*Action remove*//*
                             if (result == DialogResult.Yes && customer.maKhachHang != null)
                             {
                                 bool deleteRes = customerService.Delete(customer.maKhachHang);

                                 if (deleteRes)
                                 {
                                     MessageBox.Show("Xóa khách hành thành công " + customer.tenKhachHang);
                                     dataGridViewCustomer.Rows.Remove(selectedRow);
                                 }
                                 else
                                 {
                                     MessageBox.Show("Xóa khách hàng thất bại " + customer.tenKhachHang);
                                 }
                             }*/
                            break;
                        }
                    case 9:
                        {

                            ModalViewDecentralization modalViewDecentralization = new ModalViewDecentralization();
                            modalViewDecentralization.Show();
                            break;
                        }

                }


            }

        }
    }
}
