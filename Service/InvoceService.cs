using FinalProject_QUANLYKHO.DB;
using FinalProject_QUANLYKHO.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject_QUANLYKHO.Service
{

    internal class InvoceService
    {

        private SqlConnection connection;
        private const string CREATE_INVOCE = "InsertHoaDon";
        private const string CREATE_INVOCE_DETAIL = "InsertHoaDonXuatNguyenLieu";
        private const string GET_ALL_INVOCE_CANCEL_MATERIAL = "GetInvoiceGoByDate";
        private const string GET_ALL_INVOCE_CANCEL_BAKE = "GetInvoiceGoByDate";
        private const string GET_DETAIL_INVOICE_MATERIAL_CANCEL = "GetInvoiceDetails";
        private const string RMEOVE_INVOCE = "RemoveHoaDon";
        private const string REMOVE_INVOICE_EXPORT_MATERIAL = "RemoveHoaDonExportMaterial";
        private const string UPDATE_INVOICE_EXPORT_MATERIAL = "UpdateHoaDonExportMaterial";


        public InvoceService()
        {
            ConfigDB config = ConfigDB.Instance;
            connection = config.GetConnection();
        }

        public Invoice CreateInvoceMaterial(Invoice invoce)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(CREATE_INVOCE, connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@idBoPhanXuat", SqlDbType.VarChar).Value = invoce.idBoPhanXuat;
                cmd.Parameters.Add("@idLoaiHoaDon", SqlDbType.VarChar).Value = invoce.idLoaiHoaDon;
                cmd.Parameters.Add("@ngayXuat", SqlDbType.Date).Value = invoce.ngayXuat;
                cmd.Parameters.Add("@idTaiKhoan", SqlDbType.VarChar).Value = invoce.idTaiKhoan;
                cmd.Parameters.Add("@tongtien", SqlDbType.Float).Value = invoce.tongTien;
                cmd.Parameters.Add("@soLuong", SqlDbType.Int).Value = invoce.soLuong;

                SqlParameter idHoaDonParam = new SqlParameter("@idHoaDon", SqlDbType.VarChar, 255);
                idHoaDonParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(idHoaDonParam);

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                cmd.ExecuteNonQuery();
                invoce.idHoaDon = idHoaDonParam.Value.ToString();

                return invoce;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                MessageBox.Show(ex.Message);
                return null; // Handle the exception appropriately, and return null or throw an exception
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        public Invoice CreateInvoiceBake(Invoice invoce)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(CREATE_INVOCE, connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@idBoPhanXuat", SqlDbType.VarChar).Value = invoce.idBoPhanXuat;
                cmd.Parameters.Add("@idLoaiHoaDon", SqlDbType.VarChar).Value = invoce.idLoaiHoaDon;
                cmd.Parameters.Add("@ngayXuat", SqlDbType.Date).Value = invoce.ngayXuat.Date;
                cmd.Parameters.Add("@idTaiKhoan", SqlDbType.VarChar).Value = invoce.idTaiKhoan;
                cmd.Parameters.Add("@tongtien", SqlDbType.Float).Value = invoce.tongTien;
                cmd.Parameters.Add("@soLuong", SqlDbType.Int).Value = invoce.soLuong;

                SqlParameter idHoaDonParam = new SqlParameter("@idHoaDon", SqlDbType.VarChar, 255);
                idHoaDonParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(idHoaDonParam);

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                cmd.ExecuteNonQuery();
                invoce.idHoaDon = idHoaDonParam.Value.ToString();

                return invoce;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                MessageBox.Show(ex.Message);
                return null; // Handle the exception appropriately, and return null or throw an exception
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        public Invoice GetInvoice(string id)
        {
            Invoice invoice = new Invoice();

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand("GetHoaDon", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@idHoaDon", SqlDbType.VarChar).Value = id;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            invoice.soLuong = int.Parse(reader["soLuongHoaDon"].ToString());
                            invoice.idHoaDon = reader["idHoaDon"].ToString();
                            invoice.idLoaiHoaDon = reader["idLoaiHoaDon"].ToString();
                            invoice.tongTien = double.Parse(reader["tongTienHoaDon"].ToString());
                            invoice.ngayXuat = DateTime.Parse(reader["ngayXuat"].ToString());
                            invoice.idTaiKhoan = reader["idTaiKhoan"].ToString();
                            invoice.tenBoPhanXuat = reader["tenBoPhanXuat"].ToString();

                            return invoice;
                        }
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
            return invoice;
        }

        public bool CreateDetailInvoceMaterial(InvoiceDetail invoceDetail)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(CREATE_INVOCE_DETAIL, connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@idHoaDon", SqlDbType.VarChar).Value = invoceDetail.idHoaDon;
                cmd.Parameters.Add("@idNguyenLieu", SqlDbType.VarChar).Value = invoceDetail.idNguyenLieu;
                cmd.Parameters.Add("@sl", SqlDbType.Int).Value = invoceDetail.sl;
                cmd.Parameters.Add("@tongTien", SqlDbType.Float).Value = invoceDetail.tongTien;

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
        
        public bool UpdateDetailInvoceMaterial(InvoiceDetail invoceDetail)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(UPDATE_INVOICE_EXPORT_MATERIAL, connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@idChiTietHoaDon", SqlDbType.VarChar, 255).Value = invoceDetail.idChiTietHoaDon;
                cmd.Parameters.Add("@newSl", SqlDbType.VarChar, 255).Value = invoceDetail.sl;
                cmd.Parameters.Add("@newTongTien", SqlDbType.Int).Value = invoceDetail.tongTien;
                cmd.Parameters.Add("@idNguyenLieu", SqlDbType.VarChar, 255).Value = invoceDetail.idNguyenLieu;
                SqlParameter result = new SqlParameter("@Result", SqlDbType.Int);
                result.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(result);
                // Open the connection if it's not already open
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                cmd.ExecuteNonQuery();

                // Retrieve the value from the output parameter
                int resultInt = (int)result.Value;
                return resultInt == 1;
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

        public bool RemoveDetailInvoice(InvoiceDetail invoceDetail)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(REMOVE_INVOICE_EXPORT_MATERIAL, connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@idChiTietHoaDon", SqlDbType.VarChar, 255).Value = invoceDetail.idChiTietHoaDon;
                SqlParameter result = new SqlParameter("@Result", SqlDbType.Int);
                result.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(result);

                // Open the connection if it's not already open
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                cmd.ExecuteNonQuery();

                // Retrieve the value from the output parameter
                int resultInt = (int)result.Value;
                return resultInt == 1;
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

        public List<Invoice> GetAllCancelledInvoicesByDate(DateTime dateOfInvoice)
        {
            List<Invoice> invoices = new List<Invoice>();

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(GET_ALL_INVOCE_CANCEL_MATERIAL, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@dateOfInvoice", SqlDbType.Date).Value = dateOfInvoice;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Invoice invoice = new Invoice();
                            invoice.soLuong = int.Parse(reader["soLuongHoaDon"].ToString());
                            invoice.idHoaDon = reader["idHoaDon"].ToString();
                            invoice.idLoaiHoaDon = reader["idLoaiHoaDon"].ToString();
                            invoice.tongTien = double.Parse(reader["tongTienHoaDon"].ToString());
                            invoice.ngayXuat = DateTime.Parse(reader["ngayXuat"].ToString());
                            invoice.idTaiKhoan = reader["idTaiKhoan"].ToString();
                            invoice.tenBoPhanXuat = reader["tenBoPhanXuat"].ToString();

                            invoices.Add(invoice);
                        }
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

            return invoices;
        }
        
        public List<Invoice> GetAllInvoicesByDateAndType(DateTime dateOfInvoice,string type)
        {
            List<Invoice> invoices = new List<Invoice>();

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand("GetInvoiceGoByDateCUATRUONG", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@dateOfInvoice", SqlDbType.Date).Value = dateOfInvoice;
                    command.Parameters.Add("@typeInvoice", SqlDbType.VarChar).Value = type;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Invoice invoice = new Invoice();
                            invoice.soLuong = int.Parse(reader["soLuongHoaDon"].ToString());
                            invoice.idHoaDon = reader["idHoaDon"].ToString();
                            invoice.idLoaiHoaDon = reader["idLoaiHoaDon"].ToString();
                            invoice.tongTien = double.Parse(reader["tongTienHoaDon"].ToString());
                            invoice.ngayXuat = DateTime.Parse(reader["ngayXuat"].ToString());
                            invoice.idTaiKhoan = reader["idTaiKhoan"].ToString();
                            invoice.tenBoPhanXuat = reader["tenBoPhanXuat"].ToString();
                            invoice.idBoPhanXuat = reader["idBoPhanXuat"].ToString();

                            invoices.Add(invoice);
                        }
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

            return invoices;
        }
        public List<InvoiceDetail> GetInvoiceDetails(string idHoaDon)
        {
            List<InvoiceDetail> invoiceDetails = new List<InvoiceDetail>();

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(GET_DETAIL_INVOICE_MATERIAL_CANCEL, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    command.Parameters.Add("@InputIdHoaDon", SqlDbType.VarChar).Value = idHoaDon;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            InvoiceDetail invoiceDetail = new InvoiceDetail();

                            invoiceDetail.idNguyenLieu = reader["HXNL_idNguyenLieu"].ToString();
                            invoiceDetail.idHoaDon = reader["idHoaDon"].ToString();
                            invoiceDetail.sl = Convert.ToInt32(reader["sl"]);
                            invoiceDetail.tongTien = double.Parse(reader["tongTien"].ToString());
                            invoiceDetail.idChiTietHoaDon = reader["id"].ToString();

                            Material material = new Material();
                            material.tenNguyenLieu = reader["tenNguyenLieu"].ToString();
                            material.idLoaiNguyenLieu = reader["idLoaiNguyenLieu"].ToString();
                            material.tenLoaiNguyenLieu = reader["tenLoaiNguyenlieu"].ToString();
                            material.donVi = reader["donVi"].ToString();
                            material.sl = Convert.ToInt32(reader["tonKho"]);
                            material.donVi = reader["donvi"].ToString();
                            material.giaTien = Convert.ToSingle(reader["giaTien"]);

                            invoiceDetail.material = material;

                            invoiceDetails.Add(invoiceDetail);
                        }
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

        public bool RemoveInvoice(Invoice invoice)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand(RMEOVE_INVOCE, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@idHoaDon", SqlDbType.VarChar, 255).Value = invoice.idHoaDon;

                    SqlParameter result = new SqlParameter("@Result", SqlDbType.Int);
                    result.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(result);

                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    cmd.ExecuteNonQuery();

                    return int.Parse(result.Value.ToString()) == 1;
                }
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
        public void DeleteInvoice(Invoice invoice)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("DeleteHoaDon", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@idHoaDon", SqlDbType.VarChar, 255).Value = invoice.idHoaDon;


                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    cmd.ExecuteNonQuery();

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
        }
        

        /*  public void Update(Material material)
          {
              try
              {
                  SqlCommand cmd = new SqlCommand(QUERY_UPDATE_MATERIAL, connection);

                  cmd.CommandType = CommandType.StoredProcedure;

                  // Input parameters
                  cmd.Parameters.Add("@idNguyenLieu",SqlDbType.VarChar).Value = material.idNguyenLieu;
                  cmd.Parameters.Add("@idLoaiNguyenLieu", SqlDbType.VarChar).Value = material.idLoaiNguyenLieu;
                  cmd.Parameters.Add("@tenNguyenLieu", SqlDbType.NVarChar).Value = material.tenNguyenLieu;
                  cmd.Parameters.Add("@sl", SqlDbType.Int).Value = material.sl;
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
          }*/

    }
}
