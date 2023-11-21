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
    internal class BakeTypeService
    {
        private SqlConnection connection;
        public BakeTypeService()
        {
            ConfigDB config = ConfigDB.Instance;
            connection = config.GetConnection();
        }

        public string GetNameTypeBakeById(string id)
        {
            string QUERY_GET_NAMETYPEBAKE_BY_ID = "nameTypeOfBake";
            try
            {
                SqlCommand cmd1 = new SqlCommand(QUERY_GET_NAMETYPEBAKE_BY_ID, connection);

                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.Add("@idLoaiBanh", SqlDbType.VarChar).Value = id;
                SqlParameter nameTypeOfBake = new SqlParameter("@tenLoaiBanh", SqlDbType.VarChar, 255);
                nameTypeOfBake.Direction = ParameterDirection.Output;
                cmd1.Parameters.Add(nameTypeOfBake);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                cmd1.ExecuteNonQuery();

                // Lấy giá trị đầu ra từ tham số đầu ra
                return nameTypeOfBake.Value as string;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        public string GetIDTypeBakeByName(string name)
        {
            string QUERY_GET_IDTYPEBAKE_BY_ID = "idTypeOfBake";
            try
            {
                SqlCommand cmd1 = new SqlCommand(QUERY_GET_IDTYPEBAKE_BY_ID, connection);

                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.Add("@tenLoaiBanh", SqlDbType.VarChar).Value = name;
                SqlParameter idTypeOfBake = new SqlParameter("@idLoaiBanh", SqlDbType.VarChar, 255);
                idTypeOfBake.Direction = ParameterDirection.Output;
                cmd1.Parameters.Add(idTypeOfBake);
                if (connection.State == ConnectionState.Closed) 
                {
                    connection.Open();
                }
                cmd1.ExecuteNonQuery();

                // Lấy giá trị đầu ra từ tham số đầu ra
                return idTypeOfBake.Value as string;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
    }
}
