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

    internal class MainService
    {
        private SqlConnection connection;
        private const string GET_INVEN_BAKE = "SELECT * from ViewTinhTonKhoBanh";
        private const string GET_INVEN_MATERIAL = "SELECT * from ViewTinhTonKhoNguyenLieu";
        private const string GET_TOTAL_AMOUNT_FOR_EXPORT_MATERIL = "GetTotalAmountForHoaDonXuatNguyenLieu";


        public MainService()
        {
            ConfigDB config = ConfigDB.Instance;
            connection = config.GetConnection();
        }

        public int GetInventoryForBakedGoods()
        {
            int inventoryQuantity = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(GET_INVEN_BAKE, connection);

                // Open the connection if it's not already open
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                // ExecuteScalar returns the first column of the first row
                var result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    inventoryQuantity = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return inventoryQuantity;
        }


        public int GetInventoryForMaterials()
        {
            int inventoryQuantity = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(GET_INVEN_MATERIAL, connection);

                // Open the connection if it's not already open
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                // ExecuteScalar returns the first column of the first row
                var result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    inventoryQuantity = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return inventoryQuantity;
        }


        public double GetTotalAmountForHoaDonXuatNguyenLieu(DateTime startDate, DateTime endDate)
        {
            double total = 0;

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(GET_TOTAL_AMOUNT_FOR_EXPORT_MATERIL, connection);

                command.CommandType = CommandType.StoredProcedure;

                // Input parameters
                command.Parameters.Add("@StartDate", SqlDbType.Date).Value = startDate;
                command.Parameters.Add("@EndDate", SqlDbType.Date).Value = endDate;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        total += Convert.ToDouble(reader["TotalAmount"]);
                    }
                }


            }
            catch (Exception ex)
            {
                // Handle the exception appropriately
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return total;
        }

        public double GetTotalAmountForHoaDonXuatBanh(DateTime startDate, DateTime endDate)
        {
            double total = 0;

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetTotalAmountForHoaDonXuatBanh", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Input parameters
                command.Parameters.Add("@StartDate", SqlDbType.Date).Value = startDate;
                command.Parameters.Add("@EndDate", SqlDbType.Date).Value = endDate;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Assuming your stored procedure returns a column named "TotalAmount"
                        total += Convert.ToDouble(reader["TotalAmount"]);
                    }
                }

            }
            catch (Exception ex)
            {
                // Handle the exception appropriately
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return total;
        }

    }

}
