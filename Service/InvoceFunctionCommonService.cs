using FinalProject_QUANLYKHO.DB;
using FinalProject_QUANLYKHO.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace FinalProject_QUANLYKHO.Service
{
    internal class InvoiceFunctionCommonService
    {
        private SqlConnection connection;
        private const string GET_ALL_EXPORT_DEPARTMENT = "SELECT * FROM GetBoPhanXuat";

        public InvoiceFunctionCommonService()
        {
            ConfigDB config = ConfigDB.Instance;
            connection = config.GetConnection();
        }

        public List<ExportDepartment> GetAllExportDepartment()
        {

            List<ExportDepartment> exportDepartments = new List<ExportDepartment>();

            try
            {
                using (SqlCommand command = new SqlCommand(GET_ALL_EXPORT_DEPARTMENT, connection))
                {
                    // Open the connection if it's not already open
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ExportDepartment exportDepartment = new ExportDepartment(
                                reader["idBoPhanXuat"].ToString(),
                                reader["tenBoPhanXuat"].ToString());

                            exportDepartments.Add(exportDepartment);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (log or show a message box, etc.)
                Console.WriteLine($"Error in GetAllExportDepartment: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return exportDepartments;
        }
    }
}
