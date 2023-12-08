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
    internal class InvoiceBakeService
    {
        private SqlConnection connection;

        public InvoiceBakeService()
        {
            ConfigDB config = ConfigDB.Instance;
            connection = config.GetConnection();
        }
        public List<InvoiceDetailBake> GetAllInvoiceBakeExportByIdBill(string idHoaDon)
        {
            List<InvoiceDetailBake> invoiceDetails = new List<InvoiceDetailBake>();

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand("GetHoaDonXuatBanh", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    command.Parameters.Add("@idHoaDon", SqlDbType.VarChar).Value = idHoaDon;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            InvoiceDetailBake invoiceDetailBake = new InvoiceDetailBake(reader["idBanh"].ToString(),
                                reader["idHoadon"].ToString(),
                                int.Parse(reader["sl"].ToString()),
                                double.Parse(reader["tongTien"].ToString()));
                            invoiceDetails.Add(invoiceDetailBake);
                        }
                        return invoiceDetails;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return invoiceDetails;
        }
        public List<InvoiceDetailBakeImport> GetAllInvoiceBakeImportByIdBill(string idHoaDon)
        {
            List<InvoiceDetailBakeImport> invoiceDetails = new List<InvoiceDetailBakeImport>();

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand("GetHoaDonNhapBanh", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    command.Parameters.Add("@idHoaDon", SqlDbType.VarChar).Value = idHoaDon;
                    command.Parameters.Add("@trong", SqlDbType.Bit).Value = 0;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            InvoiceDetailBakeImport invoiceDetailBake = new InvoiceDetailBakeImport(reader["idBanh"].ToString(),
                                reader["idKhachHang"].ToString(),
                                reader["idHoadon"].ToString(),
                                int.Parse(reader["soluong"].ToString()),
                                double.Parse(reader["tongTien"].ToString()));
                            invoiceDetails.Add(invoiceDetailBake);
                        }
                        return invoiceDetails;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return invoiceDetails;
        }
        
        public bool CreateDetailInvoiceBake(InvoiceDetailBake invoiceDetail)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("InsertHoaDonXuatBanh", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@idBanh", SqlDbType.VarChar).Value = invoiceDetail.idBanh;
                cmd.Parameters.Add("@idHoaDon", SqlDbType.VarChar).Value = invoiceDetail.idHoaDon;
                cmd.Parameters.Add("@sl", SqlDbType.Int).Value = invoiceDetail.sl;
                cmd.Parameters.Add("@tongTien", SqlDbType.Float).Value = float.Parse(invoiceDetail.tongTien.ToString());

                // Open the connection if it's not already open
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                cmd.ExecuteNonQuery();

                // Retrieve the value from the output parameter

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                MessageBox.Show(ex.Message);
                return false; // Handle the exception appropriately, and return null or throw an exception
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        public bool CreateDetailInvoiceBakeImportOut(InvoiceDetailBakeImport invoiceDetail)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("InsertHoaDonNhapBanhNgoai", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@idBanh", SqlDbType.VarChar).Value = invoiceDetail.idBanh;
                cmd.Parameters.Add("@idHoaDon", SqlDbType.VarChar).Value = invoiceDetail.idHoaDon;
                cmd.Parameters.Add("@idKhachHang", SqlDbType.VarChar).Value = invoiceDetail.idKhachHang;
                cmd.Parameters.Add("@sl", SqlDbType.Int).Value = invoiceDetail.sl;
                cmd.Parameters.Add("@tongTien", SqlDbType.Float).Value = float.Parse(invoiceDetail.tongTien.ToString());

                // Open the connection if it's not already open
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                cmd.ExecuteNonQuery();

                // Retrieve the value from the output parameter

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                MessageBox.Show(ex.Message+"nug");
                return false; // Handle the exception appropriately, and return null or throw an exception
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        public bool DeleteInvoice(string id)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                using (SqlCommand cmd = new SqlCommand("DeleteHoaDon", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@id", id));
                    cmd.ExecuteNonQuery();
                    return true;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        public bool DeleteDetailInvoiceExportBakeGo(string idHoaDon,string idBanh)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                using (SqlCommand cmd = new SqlCommand("DeleteDetailBillByIdBillAndIdBake", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@idHoaDon", SqlDbType.VarChar).Value = idHoaDon;
                    cmd.Parameters.Add("@idBanh", SqlDbType.VarChar).Value = idBanh;
                    cmd.Parameters.Add("@table", SqlDbType.VarChar).Value = "HoaDonXuatBanh";

                    cmd.ExecuteNonQuery();
                    return true;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        public bool DeleteDetailInvoiceImportBakeOut(string idHoaDon, string idBanh)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                using (SqlCommand cmd = new SqlCommand("DeleteDetailBillByIdBillAndIdBake", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@idHoaDon", SqlDbType.VarChar).Value = idHoaDon;
                    cmd.Parameters.Add("@idBanh", SqlDbType.VarChar).Value = idBanh;
                    cmd.Parameters.Add("@table", SqlDbType.VarChar).Value = "HoaDonNhapBanh";

                    cmd.ExecuteNonQuery();
                    return true;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
