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
        private const string QUERY_CREATE_CUSTOMER = "CreateNewCustomer";
        private const string QUERY_GET_ALL = "SELECT * FROM View_GetAllKhachHang";
        private const string QUERY_REMOVE_CUSTOMER_BY_ID = "DeleteById";

        public CustomerService()
        {
            ConfigDB config = ConfigDB.Instance;
            connection = config.GetConnection();
        }

        public Customer Create(Customer customer)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(QUERY_CREATE_CUSTOMER, connection);

                cmd.CommandType = CommandType.StoredProcedure;

                // Input parameters
                cmd.Parameters.Add("@tenKhachHang", SqlDbType.VarChar).Value = customer.tenKhachHang;
                cmd.Parameters.Add("@diachi", SqlDbType.VarChar).Value = customer.diaChi;
                cmd.Parameters.Add("@soDienThoai", SqlDbType.VarChar).Value = customer.sodienthoai;

                // Output parameter for the new customer ID
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

                // Get the new customer ID

                // Execute the SQL command to insert the new customer
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

        public List<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>();

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



                using (SqlCommand cmd = new SqlCommand(QUERY_REMOVE_CUSTOMER_BY_ID, connection))
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


    }
}
