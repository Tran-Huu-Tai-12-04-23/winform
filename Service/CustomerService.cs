using System;
using System.Data;
using System.Data.SqlClient;
using FinalProject_QUANLYKHO.DB;
using FinalProject_QUANLYKHO.Models;

namespace FinalProject_QUANLYKHO.Service
{
    internal class CustomerService
    {
        private SqlConnection connection;
        private const string CREATE_CUSTOMER_QUERY = "CreateNewCustomer";
        private const string GET_ALL_QUERY = "GetPaginatedData";
        private const string REMOVE_CUSTOMER_BY_ID_QUERY = "DeleteById";
        private const string UPDATE_QUERY = "UpdateCustomer";
        private const string SEARCH_QUERY = "SearchCustomer";
        private const string TABLE = "KhachHang";
        private const string COUNT_QUERY = "SELECT * FROM Count_Customer";
        private const string COUNT_ACTIVE_QUERY = "SELECT * FROM Count_Customer_Active";
        private const string ACTIVE_QUERY = "ActivateKhachHang";
        private const string INACTIVE_QUERY = "DeactivateKhachHang";
        private const string GET_ALL_QUERY_ACTIVE = "GetPaginatedDataHien";

        public CustomerService()
        {
            ConfigDB config = ConfigDB.Instance;
            connection = config.GetConnection();
        }

        public Customer Create(Customer customer)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(CREATE_CUSTOMER_QUERY, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.Add("@tenKhachHang", SqlDbType.VarChar).Value = customer.tenKhachHang;
                cmd.Parameters.Add("@diachi", SqlDbType.VarChar).Value = customer.diaChi;
                cmd.Parameters.Add("@soDienThoai", SqlDbType.VarChar).Value = customer.sodienthoai;
                
                SqlParameter newCustomerIDParam = new SqlParameter("@newCustomerID", SqlDbType.VarChar, 255);
                newCustomerIDParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(newCustomerIDParam);

                // Open the connection if it's not already open
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                cmd.ExecuteNonQuery();
                string newCustomerID = cmd.Parameters["@newCustomerID"].Value.ToString();
                customer.hien = true;
                customer.maKhachHang = newCustomerID;
                // Close the connection
                connection.Close();
                // Return the customer with the generated ID (if applicable)
                return customer;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return null;
                
            }
        }

        public List<Customer> GetAll(int page, int size)
        {
            List<Customer> customers = new List<Customer>();

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }



                using (SqlCommand command = new SqlCommand(GET_ALL_QUERY, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@table", SqlDbType.VarChar, 255)).Value = TABLE;
                    command.Parameters.Add(new SqlParameter("@page", SqlDbType.Int)).Value = page;
                    command.Parameters.Add(new SqlParameter("@size", SqlDbType.Int)).Value = size;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Customer customer = new Customer
                            {
                                maKhachHang = reader["idKhachHang"].ToString(),
                                tenKhachHang = reader["tenKhachHang"].ToString(),
                                diaChi = reader["diaChi"].ToString(),
                                sodienthoai = reader["sdt"].ToString(),
                              
                            };

                            customer.hien = bool.Parse(reader["hien"].ToString());
                            customers.Add(customer);
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

            return customers;
        }

        public List<Customer> GetAllActive(int page, int size)
        {
            List<Customer> customers = new List<Customer>();

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }



                using (SqlCommand command = new SqlCommand(GET_ALL_QUERY_ACTIVE, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@table", SqlDbType.VarChar, 255)).Value = TABLE;
                    command.Parameters.Add(new SqlParameter("@page", SqlDbType.Int)).Value = page;
                    command.Parameters.Add(new SqlParameter("@size", SqlDbType.Int)).Value = size;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Customer customer = new Customer
                            {
                                maKhachHang = reader["idKhachHang"].ToString(),
                                tenKhachHang = reader["tenKhachHang"].ToString(),
                                diaChi = reader["diaChi"].ToString(),
                                sodienthoai = reader["sdt"].ToString(),

                            };

                            customer.hien = bool.Parse(reader["hien"].ToString());


                            customers.Add(customer);
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

            return customers;
        }


        public bool Delete(string id)
        {

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }



                using (SqlCommand cmd = new SqlCommand(REMOVE_CUSTOMER_BY_ID_QUERY, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@id", id));
                    cmd.Parameters.Add(new SqlParameter("@tableName", "khachhang"));

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

        public Customer Update(Customer customer)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(UPDATE_QUERY, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    command.Parameters.Add(new SqlParameter("@idKhacHang", SqlDbType.VarChar, 255)).Value = customer.maKhachHang;
                    command.Parameters.Add(new SqlParameter("@tenKhachHang", SqlDbType.VarChar, 255)).Value = customer.tenKhachHang;
                    command.Parameters.Add(new SqlParameter("@diachi", SqlDbType.VarChar, 255)).Value = customer.diaChi;
                    command.Parameters.Add(new SqlParameter("@soDienThoai", SqlDbType.VarChar, 255)).Value = customer.sodienthoai;
                    command.Parameters.Add(new SqlParameter("@hien", SqlDbType.Bit)).Value = 1;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Customer cus = new Customer
                            {
                                maKhachHang = reader["idKhachHang"].ToString(),
                                tenKhachHang = reader["tenKhachHang"].ToString(),
                                sodienthoai = reader["sdt"].ToString(),
                                hien = bool.Parse(reader["hien"].ToString())
                            };

                            return cus;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception, log, or return a meaningful error message
                throw new Exception(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return null;
        }


        public List<Customer> Search(string key)
        {
            List<Customer> searchCustommer = new List<Customer>();

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(SEARCH_QUERY, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    command.Parameters.Add(new SqlParameter("@key", SqlDbType.VarChar, 255)).Value = key;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Customer cus = new Customer();
                            cus.maKhachHang = reader["idKhachHang"].ToString();
                            cus.tenKhachHang = reader["tenKhachHang"].ToString();
                            cus.diaChi = reader["diaChi"].ToString();
                            cus.sodienthoai = reader["sdt"].ToString();
                            cus.hien = bool.Parse(reader["hien"].ToString());

                            searchCustommer.Add(cus);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception, log, or return a meaningful error message
                throw new Exception(ex.Message);
            }
            finally
            {

                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();

                }
            }

            return searchCustommer;

        }
        public int GetTotalRow()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(COUNT_QUERY, connection))
                {


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return int.Parse(reader["TotalCustomers"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception, log, or return a meaningful error message
                throw new Exception(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return -1;
        }

        public int GetTotalRowActive()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(COUNT_ACTIVE_QUERY, connection))
                {


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return int.Parse(reader["TotalCustomers"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception, log, or return a meaningful error message
                throw new Exception(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return -1;
        }



        public bool Active(string id)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(ACTIVE_QUERY, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@idKhachHang", SqlDbType.VarChar, 255)).Value = id;
                    command.ExecuteReader();
                }
            }
            catch (Exception ex)
            {
                // Handle the exception, log, or return a meaningful error message
                throw new Exception(ex.Message);
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

        public bool DeActive(string id)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(INACTIVE_QUERY, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@idKhachHang", SqlDbType.VarChar, 255)).Value = id;
                    command.ExecuteReader();


                }
            }
            catch (Exception ex)
            {
                // Handle the exception, log, or return a meaningful error message
                throw new Exception(ex.Message);
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
