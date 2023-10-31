using System;
using System.Data;
using System.Data.SqlClient;
using FinalProject_QUANLYKHO.DB;
using FinalProject_QUANLYKHO.Models;

namespace FinalProject_QUANLYKHO.Service
{
    internal class BakeService
    {
        private SqlConnection connection;
        private const string QUERY_CREATE_BAKE = "CreateNewBake";
        private const string QUERY_GET_ALL = "SELECT * FROM View_GetAllBanh";
        private const string QUERY_REMOVE_BAKE_BY_ID = "DeleteById";

        public BakeService()
        {
            ConfigDB config = ConfigDB.Instance;
            connection = config.GetConnection();
        }

        public Bake Create(Bake bake)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(QUERY_CREATE_BAKE, connection);

                cmd.CommandType = CommandType.StoredProcedure;

                // Input parameters
                cmd.Parameters.Add("@tenBanh", SqlDbType.VarChar).Value = bake.tenBanh;
                cmd.Parameters.Add("@sl", SqlDbType.Int).Value = bake.soLuong;
                cmd.Parameters.Add("@giaTien", SqlDbType.Float).Value = bake.giaTien;
                cmd.Parameters.Add("@donVi", SqlDbType.VarChar).Value = bake.donVi;
                cmd.Parameters.Add("@idLoaiBanh", SqlDbType.VarChar).Value = bake.maLoaiBanh;

                // Output parameter for the new customer ID
                SqlParameter newBakeIDParam = new SqlParameter("@idBanh", SqlDbType.VarChar, 255);
                newBakeIDParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(newBakeIDParam);


                // Open the connection if it's not already open
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                cmd.ExecuteNonQuery();

                string newBakeID = cmd.Parameters["@idBanh"].Value.ToString();

                bake.hien = true;
                bake.maBanh = newBakeID;
                // Close the connection
                connection.Close();
                // Return the customer with the generated ID (if applicable)
                return bake;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return null;

            }
        }

        public List<Bake> GetAll()
        {

            List<Bake> bakes = new List<Bake>();

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
                            Bake bake = new Bake
                            {
                                maBanh = reader["idBanh"].ToString(),
                                tenBanh = reader["tenBanh"].ToString(),
                                soLuong = Int32.Parse(reader["sl"].ToString()),
                                giaTien = float.Parse(reader["giaTien"].ToString()),
                                donVi = reader["donVi"].ToString(),
                                maLoaiBanh = reader["idLoaiBanh"].ToString(),
                            };

                            bake.hien = bool.Parse(reader["hien"].ToString());




                            bakes.Add(bake);
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
                    cmd.Parameters.Add(new SqlParameter("@tableName", "Banh"));

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
