using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Asn1.Cms;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ConnectDb
{   //Bai 2
    public partial class Form1 : Form
    {
        //Thay Source=abc. abc la ten sever sql cua may
        private readonly string connectionString = "Data Source=ADMIN-PC;Initial Catalog=QUANLYTHUCTAP;Integrated Security=True";
        private SqlConnection connc = new SqlConnection("Data Source=ADMIN-PC;Initial Catalog=QUANLYTHUCTAP;Integrated Security=True");
        SqlConnection connection;
        SqlDataAdapter adapter;
        bool isAddStudent = false;

        DataTable tbl = new DataTable();

        private void loadSinhVienFromDB()
        {
            board.Enabled = true;
            btnEdit.Enabled = false;
            btnRemove.Enabled = false;
            btnSave.Enabled = false; ;
            GetData();
        }


        private void GetData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * from Detai";

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
                string insertQuery = "INSERT INTO detai VALUES (@Msdt, @TenDT, @ChuNhiem, @KinhPhi )";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Msdt", inputMSDT.Text);
                    command.Parameters.AddWithValue("@TenDT", inputTenDeTai.Text);
                    command.Parameters.AddWithValue("@ChuNhiem", selectChuNhiem.Text);
                    command.Parameters.AddWithValue("@KinhPhi", inputKinhPhi.Text);

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
            inputMSDT.Enabled = true;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string updateQuery = "UPDATE Detai SET TENDT = @Tendt, CHUNHIEM = @Chunhiem, KINHPHI= @Kinhphi WHERE MSDT = @Msdt";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Tendt", inputTenDeTai.Text);
                    command.Parameters.AddWithValue("@Chunhiem", selectChuNhiem.Text);
                    command.Parameters.AddWithValue("@Kinhphi", inputKinhPhi.Text);

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
                string deleteQuery = "DELETE FROM detai WHERE MSDT = @Msdt";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@Msdt", id);

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
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xoá không?", "Thông báo", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (inputMSDT.Text != "")
                {
                    RemoveStudent(inputMSDT.Text);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAddStudent = true;
            panel1.Enabled = true;
            inputMSDT.Text = "";
            inputTenDeTai.Text = "";
            inputMSDT.Focus();
            btnSave.Enabled = true;
            selectChuNhiem.Text = "";
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            panel1.Enabled = false;
            btnSave.Enabled = false;
            btnEdit.Enabled = false;
            inputTenDeTai.Text = null;
            inputMSDT.Text = null;
            selectChuNhiem.Text = null;
            inputKinhPhi.Text = null;
            btnRemove.Enabled = false;
        }

        private void board_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnEdit.Enabled = true;
                btnRemove.Enabled = true;
                if (board.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    board.CurrentRow.Selected = true;
                    inputMSDT.Text = board.Rows[e.RowIndex].Cells["MSDT"].FormattedValue.ToString();
                    selectChuNhiem.Text = board.Rows[e.RowIndex].Cells["CHUNHIEM"].FormattedValue.ToString();
                    inputTenDeTai.Text = board.Rows[e.RowIndex].Cells["TENDT"].FormattedValue.ToString();
                    inputKinhPhi.Text = board.Rows[e.RowIndex].Cells["KINHPHI"].FormattedValue.ToString();
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
            inputMSDT.Enabled = false;
            btnSave.Enabled = true;
            inputTenDeTai.Focus();
        }


    }
}