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

    internal class MaterialService
    {

        private SqlConnection connection;
        private const string QUERY_CREATE_MATERIAL = "CreateNewMaterial";
        private const string QUERY_GET_ALL = "SELECT * FROM NguyenLieu";
        private const string QUERY_REMOVE_MATERIAL_BY_ID = "DeleteById";
        private const string QUERY_GET_NAMETYPEMATERIAL = "SELECT tenLoaiNguyenLieu FROM LoaiNguyenLieu";
        public MaterialService()
        {
            ConfigDB config = ConfigDB.Instance;
            connection = config.GetConnection();
        }
        public Material Create(Material material)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(QUERY_CREATE_MATERIAL, connection);

                cmd.CommandType = CommandType.StoredProcedure;

                // Input parameters
                cmd.Parameters.Add("@tenNguyenLieu", SqlDbType.VarChar).Value = material.tenNguyenLieu;
                cmd.Parameters.Add("@sl", SqlDbType.Int).Value = material.sl;
                cmd.Parameters.Add("@giaTien", SqlDbType.Float).Value = material.giaTien;
                cmd.Parameters.Add("@donVi", SqlDbType.VarChar).Value = material.donVi;
                cmd.Parameters.Add("@tenLoaiNguyenLieu", SqlDbType.VarChar).Value = material.tenLoaiNguyenLieu;
                // Output parameter for the new customer ID
                SqlParameter newIDMaterialParam = new SqlParameter("@idNguyenLieuOutput", SqlDbType.VarChar, 255);
                newIDMaterialParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(newIDMaterialParam);
                SqlParameter IDTypeMaterialParam = new SqlParameter("@idLoaiNguyenLieuOutput", SqlDbType.VarChar, 255);
                IDTypeMaterialParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(IDTypeMaterialParam);

                // Open the connection if it's not already open
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                cmd.ExecuteNonQuery();

                string newIDMaterial = cmd.Parameters["@idNguyenLieu"].Value.ToString();
                string IDTypeMaterial = cmd.Parameters["@idLoaiNguyenLieu"].Value.ToString();

                material.hien = true;
                material.idNguyenLieu = newIDMaterial;
                material.tenNguyenLieu = IDTypeMaterial;


                connection.Close();
                return material;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return null;
            }
        }
        public List<String> GetNameTypeMaterial()
        {
            List<string> name = new List<String>();

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }



                using (SqlCommand command = new SqlCommand(QUERY_GET_NAMETYPEMATERIAL, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nametype = reader["tenLoaiNguyenLieu"].ToString();

                            name.Add(nametype);
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

            return name;
        }
        public List<Material> GetAll()
        {
            List<Material> materials = new List<Material>();

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }



                using (SqlCommand command = new SqlCommand("Select * from NguyenLieu", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {



                            Material material = new Material(reader["idNguyenLieu"].ToString(),
                                reader["idLoaiNguyenLieu"].ToString(),
                                reader["tenNguyenLieu"].ToString(),
                                int.Parse(reader["sl"].ToString()),
                                float.Parse(reader["giaTien"].ToString()),
                                reader["donVi"].ToString(),
                                bool.Parse(reader["hien"].ToString()));
                            materials.Add(material);
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

            return materials;
        }
        public bool Delete(string id)
        {

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }



                using (SqlCommand cmd = new SqlCommand(QUERY_REMOVE_MATERIAL_BY_ID, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@id", id));
                    cmd.Parameters.Add(new SqlParameter("@tableName", "NguyenLieu" + ""));

                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return true;

        }
    }
}
