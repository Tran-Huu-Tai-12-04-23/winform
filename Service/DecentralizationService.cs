using FinalProject_QUANLYKHO.DB;
using FinalProject_QUANLYKHO.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_QUANLYKHO.Service
{

    internal class DecentralizationService
    {

        private SqlConnection connection;
        private const string QUERY_UPDATE_MATERIAL = "UpdateDecentralization";
        private const string QUERY_GET_ALL = "SELECT * FROM PhanQuyenView";
     
        public DecentralizationService()
        {
            ConfigDB config = ConfigDB.Instance;
            connection = config.GetConnection();
        }
        public List<Decentralization> GetAll()
        {
            List<Decentralization> decensList = new List<Decentralization>();

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }



                using (SqlCommand command = new SqlCommand(QUERY_GET_ALL, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            Decentralization decen = new Decentralization();
                            decen.idPhanQuyen = reader["idPhanquyen"].ToString();
                            decen.tentaikhoan = reader["tenTaiKhoan"].ToString();
                            decen.quyenThem = reader["quyenThem"] != DBNull.Value ? Convert.ToBoolean(reader["quyenThem"]) : false;
                            decen.quyenXoa = reader["quyenXoa"] != DBNull.Value ? Convert.ToBoolean(reader["quyenXoa"]) : false;
                            decen.quyenSua = reader["quyenSua"] != DBNull.Value ? Convert.ToBoolean(reader["quyenSua"]) : false;

                            if (reader["ngayBatDau"] != DBNull.Value)
                            {
                                decen.ngayBatDau = Convert.ToDateTime(reader["ngayBatDau"]);
                            }

                            if (reader["ngayKetThuc"] != DBNull.Value)
                            {
                                decen.ngayKetThuc = Convert.ToDateTime(reader["ngayKetThuc"]);
                            }

                            decensList.Add(decen);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return decensList;
        }
    }
}
