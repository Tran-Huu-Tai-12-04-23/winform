using FinalProject_QUANLYKHO.DB;
using FinalProject_QUANLYKHO.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject_QUANLYKHO.Service
{

    internal class MaterialService
    {

        private SqlConnection connection;
        private const string QUERY_CREATE_MATERIAL = "CreateNewMaterial";
        private const string QUERY_GETPAGE_MATERIAL = "GetPaginatedData";
        private const string QUERY_GETPAGE_MATERIAL_BYTYPE = "GetPaginatedDataByType";
        private const string QUERY_FIND_MATERIAL = "SearchMaterial";
        private const string QUERY_UPDATE_MATERIAL = "UpdateMaterial";
        private const string QUERY_ACTIVE_MATERIAL = "ActiveMaterial";
        private const string QUERY_GET_ALL = "GetAllMaterial";
        private const string QUERY_GET_ALL_BYTYPE = "GetAllMaterialByType";

        private const string QUERY_REMOVE_MATERIAL_BY_ID = "DeleteById";
        private const string QUERY_GET_NAMETYPEMATERIAL = "SELECT * FROM LoaiNguyenLieu";
        private const string QUERY_GET_TOTAL_ROW_BYTYPE = "GetTotalRowOfMaterialByType";
        private const string QUERY_GET_TOTAL_ROW_MATERIAL = "SELECT COUNT(*) AS total FROM nguyenlieu WHERE hien = 1";
        private MaterialTypeService materialTypeService;

        public MaterialService()
        {
            ConfigDB config = ConfigDB.Instance;
            connection = config.GetConnection();
        }


        public void Create(Material material)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(QUERY_CREATE_MATERIAL, connection);

                cmd.CommandType = CommandType.StoredProcedure;

                // Input parameters
                cmd.Parameters.Add("@tenNguyenLieu", SqlDbType.NVarChar).Value = material.tenNguyenLieu;
                cmd.Parameters.Add("@sl", SqlDbType.Int).Value = material.sl;
                cmd.Parameters.Add("@giaTien", SqlDbType.Float).Value = material.giaTien;
                cmd.Parameters.Add("@donVi", SqlDbType.NVarChar).Value = material.donVi;
                cmd.Parameters.Add("@tenLoaiNguyenLieu", SqlDbType.NVarChar).Value = material.idLoaiNguyenLieu;
                SqlParameter IDTypeMaterialParam = new SqlParameter("@idLoaiNguyenLieuOutput", SqlDbType.VarChar, 255);
                IDTypeMaterialParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(IDTypeMaterialParam);
                SqlParameter newIDMaterialParam = new SqlParameter("@idNguyenLieuOutput", SqlDbType.VarChar, 255);
                newIDMaterialParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(newIDMaterialParam);

                // Open the connection if it's not already open
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }
        public void Update(Material material)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(QUERY_UPDATE_MATERIAL, connection);

                cmd.CommandType = CommandType.StoredProcedure;

                // Input parameters
                MessageBox.Show(material.idNguyenLieu);
                cmd.Parameters.Add("@idNguyenLieu", SqlDbType.VarChar).Value = material.idNguyenLieu;
                MessageBox.Show(material.idLoaiNguyenLieu);
                cmd.Parameters.Add("@idLoaiNguyenLieu", SqlDbType.VarChar).Value = material.idLoaiNguyenLieu;
                MessageBox.Show(material.tenNguyenLieu);
                cmd.Parameters.Add("@tenNguyenLieu", SqlDbType.NVarChar).Value = material.tenNguyenLieu;
                MessageBox.Show(material.sl.ToString());
                cmd.Parameters.Add("@sl", SqlDbType.Int).Value = material.sl;
                MessageBox.Show(material.giaTien.ToString());
                cmd.Parameters.Add("@giaTien", SqlDbType.Float).Value = material.giaTien;
                cmd.Parameters.Add("@donVi", SqlDbType.NVarChar).Value = material.donVi;
                // Open the connection if it's not already open
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }
        public void ActiveMaterial(string id, bool hien)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(QUERY_ACTIVE_MATERIAL, connection);

                cmd.CommandType = CommandType.StoredProcedure;

                // Input parameters
                cmd.Parameters.Add("@idNguyenLieu", SqlDbType.VarChar).Value = id;
                if (hien)
                {
                    cmd.Parameters.Add("@hien", SqlDbType.Bit).Value = 0;

                }
                else
                {
                    cmd.Parameters.Add("@hien", SqlDbType.Bit).Value = 1;
                }

                // Open the connection if it's not already open
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }
        public List<Material> PageMaterial(int page, int size, bool hien)
        {
            List<Material> materials = new List<Material>();
            materialTypeService = new MaterialTypeService();
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                using (SqlCommand command = new SqlCommand(QUERY_GETPAGE_MATERIAL, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Input parameters
                    command.Parameters.Add("@table", SqlDbType.NVarChar).Value = "NguyenLieu";

                    command.Parameters.Add("@page", SqlDbType.Int).Value = page;
                    command.Parameters.Add("@size", SqlDbType.Int).Value = size;
                    if (hien)
                    {
                        command.Parameters.Add("@hien", SqlDbType.Bit).Value = 0;

                    }
                    else
                    {
                        command.Parameters.Add("@hien", SqlDbType.Bit).Value = 1;
                    }
                    // Open the connection if it's not already open
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    command.ExecuteNonQuery();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            //MessageBox.Show(materialTypeService.GetNameTypeMaterialById(reader["idLoaiNguyenLieu"].ToString()), "Tiêu đề thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //MessageBox.Show(materialTypeService.GetNameTypeMaterialById(reader["idLoaiNguyenLieu"].ToString()));
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

                materials.ForEach(x => x.idLoaiNguyenLieu = materialTypeService.GetNameTypeMaterialById(x.idLoaiNguyenLieu));
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
        public List<Material> PageMaterialByType(int page, int size, string key, bool hien)
        {
            List<Material> materials = new List<Material>();
            materialTypeService = new MaterialTypeService();
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                using (SqlCommand command = new SqlCommand(QUERY_GETPAGE_MATERIAL_BYTYPE, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Input parameters
                    command.Parameters.Add("@table", SqlDbType.NVarChar).Value = "NguyenLieu";

                    command.Parameters.Add("@page", SqlDbType.Int).Value = page;
                    command.Parameters.Add("@size", SqlDbType.Int).Value = size;
                    command.Parameters.Add("@key", SqlDbType.NVarChar).Value = key;
                    if (hien)
                    {
                        command.Parameters.Add("@hien", SqlDbType.Bit).Value = 0;

                    }
                    else
                    {
                        command.Parameters.Add("@hien", SqlDbType.Bit).Value = 1;
                    }


                    // Open the connection if it's not already open
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    command.ExecuteNonQuery();
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

                materials.ForEach(x => x.idLoaiNguyenLieu = materialTypeService.GetNameTypeMaterialById(x.idLoaiNguyenLieu));
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
        public List<MaterialType> GetNameTypeMaterial()
        {
            List<MaterialType> materialTypes = new List<MaterialType>();

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
                            MaterialType materialType = new MaterialType();
                            string nametype = reader["tenLoaiNguyenLieu"].ToString();
                            string idType = reader["idLoaiNguyenLieu"].ToString();

                            materialType.tenLoaiNguyenLieu = nametype;
                            materialType.idLoaiNguyenLieu = idType;    

                            materialTypes.Add(materialType);

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

            return materialTypes ;
        }

        public int GetTotalRowMaterial()
        {
            int totalRow = 0;
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(QUERY_GET_TOTAL_ROW_MATERIAL, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            totalRow = Convert.ToInt32(reader["total"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return totalRow;
        }
        public int GetTotalRowMaterialByType(MaterialType materialType)
        {
            int totalRow = 0;
            materialTypeService = new MaterialTypeService();

            try
            {
                using (SqlCommand command = new SqlCommand("GetTotalRowOfMaterialByType", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Input parameter
                    command.Parameters.Add("@idLoaiNguyenLieu", SqlDbType.VarChar, 255).Value = materialType.idLoaiNguyenLieu;

                    // Output parameter
                    command.Parameters.Add("@totalRow", SqlDbType.Int).Direction = ParameterDirection.Output;

                    // Open the connection if it's not already open
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    command.ExecuteNonQuery();

                    totalRow = Convert.ToInt32(command.Parameters["@totalRow"].Value);
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return totalRow;
        }


        public List<Material> GetAll(bool hien)
        {
            List<Material> materials = new List<Material>();
            materialTypeService = new MaterialTypeService();
            try
            {
                using (SqlCommand command = new SqlCommand(QUERY_GET_ALL, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (hien)
                    {
                        command.Parameters.Add("@hien", SqlDbType.Bit).Value = 0;

                    }
                    else
                    {
                        command.Parameters.Add("@hien", SqlDbType.Bit).Value = 1;
                    }
                    // Open the connection if it's not already open
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    command.ExecuteNonQuery();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            // MessageBox.Show(materialTypeService.GetNameTypeMaterialById(reader["idLoaiNguyenLieu"].ToString()), "Tiêu đề thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Material material = new Material(reader["idNguyenLieu"].ToString(),
                                reader["idLoaiNguyenLieu"].ToString(),
                                reader["tenNguyenLieu"].ToString(),
                                int.Parse(reader["sl"].ToString()),
                                float.Parse(reader["giaTien"].ToString()),
                                reader["donVi"].ToString(),
                                bool.Parse(reader["hien"].ToString()));
                            material.tenLoaiNguyenLieu = reader["tenLoaiNguyenLieu"].ToString();
                            materials.Add(material);
                        }
                    }
                }

                materials.ForEach(x => x.idLoaiNguyenLieu = materialTypeService.GetNameTypeMaterialById(x.idLoaiNguyenLieu));
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
        public List<Material> GetAllByType(string key, bool hien)
        {
            List<Material> materials = new List<Material>();
            materialTypeService = new MaterialTypeService();
            try
            {
                using (SqlCommand command = new SqlCommand(QUERY_GET_ALL_BYTYPE, connection))
                {

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@key", SqlDbType.NVarChar).Value = key;

                    if (hien)
                    {
                        command.Parameters.Add("@hien", SqlDbType.Bit).Value = 0;

                    }
                    else
                    {
                        command.Parameters.Add("@hien", SqlDbType.Bit).Value = 1;
                    }


                    // Open the connection if it's not already open
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    command.ExecuteNonQuery();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {


                            // MessageBox.Show(materialTypeService.GetNameTypeMaterialById(reader["idLoaiNguyenLieu"].ToString()), "Tiêu đề thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                materials.ForEach(x => x.idLoaiNguyenLieu = materialTypeService.GetNameTypeMaterialById(x.idLoaiNguyenLieu));
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
        public List<Material> FindMaterials(string key)
        {
            List<Material> materials = new List<Material>();
            materialTypeService = new MaterialTypeService();
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                using (SqlCommand command = new SqlCommand(QUERY_FIND_MATERIAL, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@key", key));

                    command.ExecuteNonQuery();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {


                            //MessageBox.Show(materialTypeService.GetNameTypeMaterialById(reader["idLoaiNguyenLieu"].ToString()), "Tiêu đề thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                materials.ForEach(x => x.idLoaiNguyenLieu = materialTypeService.GetNameTypeMaterialById(x.idLoaiNguyenLieu));
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
                    cmd.Parameters.Add(new SqlParameter("@tableName", "NguyenLieu"));

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
