using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Asn1.Cms;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ConnectDb
{
    public partial class Form1 : Form
    {
        //Thay Source=abc. abc la ten sever sql cua may
        private readonly string connectionString = "Data Source=localhost, 1433;Initial Catalog=QUANLYTHUCTAP; User ID=sa;Password=tai2k300@@@@@";
        private SqlConnection connc = new SqlConnection("Data Source=localhost, 1433;Initial Catalog=QUANLYTHUCTAP; User ID=sa;Password=tai2k300@@@@@");
        SqlConnection connection;
        SqlDataAdapter adapter;
        bool isAddStudent = false;

        DataTable tbl = new DataTable();

        private void loadSinhVienFromDB()
        {
            board.Enabled = true;
            btnEdit.Enabled = false;
            btnRemove.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnCancel.Enabled = false;
            GetData();
        }


        private void GetData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Sinhvien";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    board.DataSource = dataTable;
                }
            }
            
        }



        private void AddStudent()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string insertQuery = "INSERT INTO Sinhvien VALUES (@Mssv, @Hotensv, @Quequan, @Ngaysinh, @Hocluc )";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Mssv", inputMSSV.Text);
                    command.Parameters.AddWithValue("@Hotensv", inputHoten.Text);
                    command.Parameters.AddWithValue("@Quequan", selectQueQuan.Text);
                    command.Parameters.AddWithValue("@Ngaysinh", inputNgaySinh.Value);
                    command.Parameters.AddWithValue("@Hocluc", inputHocLuc.Text);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        GetData();
                        MessageBox.Show("Student added successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add student.");
                    }
                }
            }

        }

        private void UpdateSinhVien()
        {
            panel1.Enabled = false;
            btnSave.Enabled = false;
            inputMSSV.Enabled = true;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string updateQuery = "UPDATE Sinhvien SET HOTENSV = @Hotensv, QUEQUAN = @Quequan, NGAYSINH = @Ngaysinh, HOCLUC = @Hocluc WHERE MSSV = @Mssv";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Mssv", inputMSSV.Text);
                    command.Parameters.AddWithValue("@Hotensv", inputHoten.Text);
                    command.Parameters.AddWithValue("@Quequan", selectQueQuan.Text);
                    command.Parameters.AddWithValue("@Ngaysinh", inputNgaySinh.Value);
                    command.Parameters.AddWithValue("@Hocluc", inputHocLuc.Text);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        GetData();
                        MessageBox.Show("Student updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update student.");
                    }
                }
            }
        }

        private void RemoveStudent(string id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string deleteQuery = "DELETE FROM Sinhvien WHERE MSSV = @Mssv";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@Mssv", id);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        GetData();
                        MessageBox.Show("Student deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete student.");
                    }
                }
            }
        }



        /// <summary>
        /// 
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            loadSinhVienFromDB();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.DocumentName = "Danh sách sinh viên";
            printDocument.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169);
            printDocument.DefaultPageSettings.Margins = new Margins(50, 50, 50, 50);

            PrintPreviewControl printPreviewControl = new PrintPreviewControl();
            printPreviewControl.Document = printDocument;
            printPreviewControl.Zoom = 1.0;

            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Sinhvien";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                int x = e.MarginBounds.Left;
                int y = e.MarginBounds.Top;
                int lineHeight = (int)Math.Ceiling(e.Graphics.MeasureString("X", Font).Height);

                foreach (DataRow row in dataTable.Rows)
                {
                    string mssv = row["MSSV"].ToString();
                    string hoten = row["HOTENSV"].ToString();
                    string quequan = row["QUEQUAN"].ToString();
                    string ngaysinh = ((DateTime)row["NGAYSINH"]).ToString("dd/MM/yyyy");
                    string hocluc = row["HOCLUC"].ToString();

                    string line = $"{mssv} - {hoten} - {quequan} - {ngaysinh} - {hocluc}";
                    e.Graphics.DrawString(line, Font, Brushes.Black, x, y);
                    y += lineHeight;
                }
            }

            e.HasMorePages = false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void board_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            btnRemove.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = false;

            board.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xoá không?", "Thông báo", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (inputMSSV.Text != "")
                {
                    RemoveStudent(inputMSSV.Text);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAddStudent = true;
            panel1.Enabled = true;
            inputMSSV.Text = "";
            inputHoten.Text = "";
            inputHocLuc.Text = "";
            inputMSSV.Focus();
            btnSave.Enabled = true;
            selectQueQuan.Text = "";
        }

        private void inputHocLuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            panel1.Enabled = false;
            btnSave.Enabled = false;
            inputHoten.Text = null;
            inputHocLuc.Text = null;
            inputMSSV.Text = null;
            inputHocLuc.Text = null;
            inputNgaySinh.Text = null;
            selectQueQuan.Text = null;
            btnRemove.Enabled = false;
            btnSave.Enabled = false;
            btnEdit.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void board_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = true;
                btnRemove.Enabled = true;
                btnCancel.Enabled = true;
                if (board.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    board.CurrentRow.Selected = true;
                    inputMSSV.Text = board.Rows[e.RowIndex].Cells["MSSV"].FormattedValue.ToString();
                    selectQueQuan.Text = board.Rows[e.RowIndex].Cells["QUEQUAN"].FormattedValue.ToString();
                    inputHocLuc.Text = board.Rows[e.RowIndex].Cells["HOCLUC"].FormattedValue.ToString();
                    inputHoten.Text = board.Rows[e.RowIndex].Cells["HOTENSV"].FormattedValue.ToString();
                    inputNgaySinh.Text = board.Rows[e.RowIndex].Cells["NGAYSINH"].FormattedValue.ToString();
                }
            }
            catch (Exception ex) { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (isAddStudent)
            {
                AddStudent();
            }
            else
            {
                UpdateSinhVien();
            }

        }

        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            isAddStudent = false;
            panel1.Enabled = true;
            inputMSSV.Enabled = false;
            btnSave.Enabled = true;
            btnAdd.Enabled = false;
            btnRemove.Enabled = false;
        }

        
    }
}