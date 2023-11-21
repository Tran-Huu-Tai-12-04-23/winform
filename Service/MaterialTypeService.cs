using FinalProject_QUANLYKHO.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_QUANLYKHO.Service
{
    internal class MaterialTypeService
    {
        private SqlConnection connection;

        public MaterialTypeService() {
            ConfigDB config = ConfigDB.Instance;
            connection = config.GetConnection();
        }
        public string GetNameTypeMaterialById(string id)
        {
            string QUERY_GET_NAMETYPEMATERIAL_BY_ID = "nameTypeOfMaterial";
            try
            {
                SqlCommand cmd1 = new SqlCommand(QUERY_GET_NAMETYPEMATERIAL_BY_ID, connection);

                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.Add("@idLoaiNguyenLieu", SqlDbType.VarChar).Value = id;
                SqlParameter nameTypeOfMaterial = new SqlParameter("@tenLoaiNguyenLieu", SqlDbType.NVarChar, 255);
                nameTypeOfMaterial.Direction = ParameterDirection.Output;
                cmd1.Parameters.Add(nameTypeOfMaterial);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                cmd1.ExecuteNonQuery();

                // Lấy giá trị đầu ra từ tham số đầu ra
                return nameTypeOfMaterial.Value as string;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
        public string GetIDTypeMaterialByName(string name)
        {
            string QUERY_GET_IDTYPEMATERIAL_BY_ID = "idTypeOfMaterial";
            try
            {
                SqlCommand cmd1 = new SqlCommand(QUERY_GET_IDTYPEMATERIAL_BY_ID, connection);

                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.Add("@tenLoaiNguyenLieu", SqlDbType.NVarChar).Value = name;
                SqlParameter idTypeOfMaterial = new SqlParameter("@idLoaiNguyenLieu", SqlDbType.VarChar, 255);
                idTypeOfMaterial.Direction = ParameterDirection.Output;
                cmd1.Parameters.Add(idTypeOfMaterial);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                cmd1.ExecuteNonQuery();

                // Lấy giá trị đầu ra từ tham số đầu ra
                return idTypeOfMaterial.Value as string;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

    }
}
