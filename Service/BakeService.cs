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
    internal class BakeService
    {
        private SqlConnection connection;
        private const string QUERY_CREATE_BAKE = "CreateNewBake";
        private const string QUERY_GETPAGE_BAKE = "GetPaginatedData";
        private const string QUERY_GETPAGE_BAKE_BYTYPE = "GetPaginatedDataByBakeType";
        private const string QUERY_FIND_BAKE = "SearchBake";
        private const string QUERY_UPDATE_BAKE = "UpdateBake";
        private const string QUERY_ACTIVE_BAKE = "ActiveBake";
        private const string QUERY_GET_ALL = "GetAllBake";
        private const string QUERY_GET_ALL_BYTYPE = "GetAllBakeByType";

        private const string QUERY_REMOVE_BAKE_BY_ID = "DeleteById";
        private const string QUERY_GET_NAMETYPEBAKE = "SELECT tenLoaiBanh FROM LoaiBanh";
        private BakeTypeService bakeTypeService;

        public BakeService()
        {
            ConfigDB config = ConfigDB.Instance;
            connection = config.GetConnection();
        }

        public void Create(Bake bake)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(QUERY_CREATE_BAKE, connection);

                cmd.CommandType = CommandType.StoredProcedure;

                // Input parameters
                cmd.Parameters.Add("@tenbanh", SqlDbType.VarChar).Value = bake.tenBanh;
                cmd.Parameters.Add("@sl", SqlDbType.Int).Value = bake.sl;
                cmd.Parameters.Add("@giaTien", SqlDbType.Float).Value = bake.giaTien;
                cmd.Parameters.Add("@donVi", SqlDbType.VarChar).Value = bake.donVi;
                cmd.Parameters.Add("@tenLoaibanh", SqlDbType.VarChar).Value = bake.idLoaiBanh;
                SqlParameter IDTypeBakeParam = new SqlParameter("@idLoaibanhOutput", SqlDbType.VarChar, 255);
                IDTypeBakeParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(IDTypeBakeParam);
                SqlParameter newIDBakeParam = new SqlParameter("@idbanhOutput", SqlDbType.VarChar, 255);
                newIDBakeParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(newIDBakeParam);

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
        public void Update(Bake bake)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(QUERY_UPDATE_BAKE, connection);

                cmd.CommandType = CommandType.StoredProcedure;

                // Input parameters
                cmd.Parameters.Add("@idBanh", SqlDbType.VarChar).Value = bake.idBanh;
                cmd.Parameters.Add("@idLoaiBanh", SqlDbType.VarChar).Value = bake.idLoaiBanh;
                cmd.Parameters.Add("@tenBanh", SqlDbType.VarChar).Value = bake.tenBanh;
                cmd.Parameters.Add("@sl", SqlDbType.Int).Value = bake.sl;
                cmd.Parameters.Add("@giaTien", SqlDbType.Float).Value = bake.giaTien;
                cmd.Parameters.Add("@donVi", SqlDbType.VarChar).Value = bake.donVi;
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
        public void ActiveBake(string id, bool hien)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(QUERY_ACTIVE_BAKE, connection);

                cmd.CommandType = CommandType.StoredProcedure;

                // Input parameters
                cmd.Parameters.Add("@idBanh", SqlDbType.VarChar).Value = id;
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
        public List<Bake> PageBake(int page, int size, bool hien)
        {
            List<Bake> bakes = new List<Bake>();
            bakeTypeService = new BakeTypeService();
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                using (SqlCommand command = new SqlCommand(QUERY_GETPAGE_BAKE, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Input parameters
                    command.Parameters.Add("@table", SqlDbType.VarChar).Value = "Banh";

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
                            //MessageBox.Show(bakeTypeService.GetNameTypeBakeById(reader["idLoaiBanh"].ToString()), "Tiêu đề thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //MessageBox.Show(bakeTypeService.GetNameTypeBakeById(reader["idLoaiBanh"].ToString()));
                            Bake bake = new Bake(reader["idBanh"].ToString(),
                                reader["idLoaiBanh"].ToString(),
                                reader["tenBanh"].ToString(),
                                int.Parse(reader["sl"].ToString()),
                                float.Parse(reader["giaTien"].ToString()),
                                reader["donVi"].ToString(),
                                bool.Parse(reader["hien"].ToString()));
                            bakes.Add(bake);
                        }
                    }
                }

                bakes.ForEach(x => x.idLoaiBanh = bakeTypeService.GetNameTypeBakeById(x.idLoaiBanh));
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

            return bakes;
        }
        public List<Bake> PageBakeByType(int page, int size, string key, bool hien)
        {
            List<Bake> bakes = new List<Bake>();
            bakeTypeService = new BakeTypeService();
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                using (SqlCommand command = new SqlCommand(QUERY_GETPAGE_BAKE_BYTYPE, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Input parameters
                    command.Parameters.Add("@table", SqlDbType.VarChar).Value = "Banh";

                    command.Parameters.Add("@page", SqlDbType.Int).Value = page;
                    command.Parameters.Add("@size", SqlDbType.Int).Value = size;
                    command.Parameters.Add("@key", SqlDbType.VarChar).Value = key;
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

                            Bake bake = new Bake(reader["idBanh"].ToString(),
                                reader["idLoaiBanh"].ToString(),
                                reader["tenBanh"].ToString(),
                                int.Parse(reader["sl"].ToString()),
                                float.Parse(reader["giaTien"].ToString()),
                                reader["donVi"].ToString(),
                                bool.Parse(reader["hien"].ToString()));
                            bakes.Add(bake);
                        }
                    }
                }

                bakes.ForEach(x => x.idLoaiBanh = bakeTypeService.GetNameTypeBakeById(x.idLoaiBanh));
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

            return bakes;
        }
        public List<String> GetNameTypeBake()
        {
            List<string> name = new List<String>();

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(QUERY_GET_NAMETYPEBAKE, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nametype = reader["tenLoaiBanh"].ToString();

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
        public List<Bake> GetAll(bool hien)
        {
            List<Bake> bakes = new List<Bake>();
            bakeTypeService = new BakeTypeService();
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


                            // MessageBox.Show(bakeTypeService.GetNameTypeBakeById(reader["idLoaiBanh"].ToString()), "Tiêu đề thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Bake bake = new Bake(reader["idBanh"].ToString(),
                                reader["idLoaiBanh"].ToString(),
                                reader["tenBanh"].ToString(),
                                int.Parse(reader["sl"].ToString()),
                                float.Parse(reader["giaTien"].ToString()),
                                reader["donVi"].ToString(),
                                bool.Parse(reader["hien"].ToString()));
                            bakes.Add(bake);
                        }
                    }
                }

                bakes.ForEach(x => x.idLoaiBanh = bakeTypeService.GetNameTypeBakeById(x.idLoaiBanh));
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

            return bakes;
        }
        public List<Bake> GetAllByType(string key, bool hien)
        {
            List<Bake> bakes = new List<Bake>();
            bakeTypeService = new BakeTypeService();
            try
            {
                using (SqlCommand command = new SqlCommand(QUERY_GET_ALL_BYTYPE, connection))
                {

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@key", SqlDbType.VarChar).Value = key;

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


                            // MessageBox.Show(bakeTypeService.GetNameTypeBakeById(reader["idLoaiBanh"].ToString()), "Tiêu đề thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Bake bake = new Bake(reader["idBanh"].ToString(),
                                reader["idLoaiBanh"].ToString(),
                                reader["tenBanh"].ToString(),
                                int.Parse(reader["sl"].ToString()),
                                float.Parse(reader["giaTien"].ToString()),
                                reader["donVi"].ToString(),
                                bool.Parse(reader["hien"].ToString()));
                            bakes.Add(bake);
                        }
                    }
                }

                bakes.ForEach(x => x.idLoaiBanh = bakeTypeService.GetNameTypeBakeById(x.idLoaiBanh));
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

            return bakes;
        }
        public List<Bake> FindBakes(string key)
        {
            List<Bake> bakes = new List<Bake>();
            bakeTypeService = new BakeTypeService();
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                using (SqlCommand command = new SqlCommand(QUERY_FIND_BAKE, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@key", key));

                    command.ExecuteNonQuery();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {


                            //MessageBox.Show(bakeTypeService.GetNameTypeBakeById(reader["idLoaiBanh"].ToString()), "Tiêu đề thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Bake bake = new Bake(reader["idBanh"].ToString(),
                                reader["idLoaiBanh"].ToString(),
                                reader["tenBanh"].ToString(),
                                int.Parse(reader["sl"].ToString()),
                                float.Parse(reader["giaTien"].ToString()),
                                reader["donVi"].ToString(),
                                bool.Parse(reader["hien"].ToString()));
                            bakes.Add(bake);
                        }
                    }
                }

                bakes.ForEach(x => x.idLoaiBanh = bakeTypeService.GetNameTypeBakeById(x.idLoaiBanh));
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

            return bakes;
        }
        public bool Delete(string id)
        {

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }



                using (SqlCommand cmd = new SqlCommand(QUERY_REMOVE_BAKE_BY_ID, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@id", id));
                    cmd.Parameters.Add(new SqlParameter("@tableName", "Banh" + ""));

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
