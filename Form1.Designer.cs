namespace ConnectDb
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            inputQuangDuong = new TextBox();
            label6 = new Label();
            inputHoten = new TextBox();
            label5 = new Label();
            selectQueQuan = new ComboBox();
            inputHocLuc = new TextBox();
            label4 = new Label();
            label3 = new Label();
            inputMSSV = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            btnWatchPrint = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            btnEdit = new Button();
            btnRemove = new Button();
            btnAdd = new Button();
            label7 = new Label();
            panel3 = new Panel();
            board = new DataGridView();
            label8 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)board).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 9);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 0;
            label1.Text = "Thông tin sinh viên";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(inputQuangDuong);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(inputHoten);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(selectQueQuan);
            panel1.Controls.Add(inputHocLuc);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(inputMSSV);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(21, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(1067, 131);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // inputQuangDuong
            // 
            inputQuangDuong.Location = new Point(664, 55);
            inputQuangDuong.Name = "inputQuangDuong";
            inputQuangDuong.Size = new Size(380, 27);
            inputQuangDuong.TabIndex = 10;
            inputQuangDuong.Tag = "3";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(550, 57);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 9;
            label6.Text = "Quảng đường";
            // 
            // inputHoten
            // 
            inputHoten.Location = new Point(664, 15);
            inputHoten.Name = "inputHoten";
            inputHoten.Size = new Size(380, 27);
            inputHoten.TabIndex = 8;
            inputHoten.Tag = "1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(550, 21);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 7;
            label5.Text = "Mã số đề tài";
            // 
            // selectQueQuan
            // 
            selectQueQuan.FormattingEnabled = true;
            selectQueQuan.Items.AddRange(new object[] { "Sài Gòn", "Thanh Hóa", "Nghệ An", "Long An", "Quảng Ngãi" });
            selectQueQuan.Location = new Point(154, 51);
            selectQueQuan.Name = "selectQueQuan";
            selectQueQuan.Size = new Size(377, 28);
            selectQueQuan.TabIndex = 6;
            selectQueQuan.Tag = "2";
            selectQueQuan.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // inputHocLuc
            // 
            inputHocLuc.Location = new Point(154, 81);
            inputHocLuc.Name = "inputHocLuc";
            inputHocLuc.Size = new Size(377, 27);
            inputHocLuc.TabIndex = 5;
            inputHocLuc.Tag = "4";
            inputHocLuc.KeyPress += inputHocLuc_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 88);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 4;
            label4.Text = "Kết quả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 55);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 2;
            label3.Text = "Nơi thực tập";
            // 
            // inputMSSV
            // 
            inputMSSV.Location = new Point(154, 15);
            inputMSSV.Name = "inputMSSV";
            inputMSSV.Size = new Size(377, 27);
            inputMSSV.TabIndex = 1;
            inputMSSV.Tag = "0";
            inputMSSV.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 21);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã số sinh viên";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnWatchPrint);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(btnRemove);
            panel2.Controls.Add(btnAdd);
            panel2.Location = new Point(22, 171);
            panel2.Name = "panel2";
            panel2.Size = new Size(1066, 63);
            panel2.TabIndex = 2;
            // 
            // btnWatchPrint
            // 
            btnWatchPrint.Location = new Point(921, 8);
            btnWatchPrint.Name = "btnWatchPrint";
            btnWatchPrint.Size = new Size(121, 45);
            btnWatchPrint.TabIndex = 5;
            btnWatchPrint.Text = "Xem in";
            btnWatchPrint.UseVisualStyleBackColor = true;
            btnWatchPrint.Click += button5_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(794, 8);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(121, 45);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(667, 8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(121, 45);
            btnSave.TabIndex = 3;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(539, 8);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(121, 45);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(409, 8);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(121, 45);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Xóa";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(282, 8);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(121, 45);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 160);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 3;
            label7.Text = "Chức năng";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(board);
            panel3.Location = new Point(23, 251);
            panel3.Name = "panel3";
            panel3.Size = new Size(1065, 319);
            panel3.TabIndex = 4;
            // 
            // board
            // 
            board.AllowUserToOrderColumns = true;
            board.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            board.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            board.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            board.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            board.Location = new Point(8, 11);
            board.MultiSelect = false;
            board.Name = "board";
            board.ReadOnly = true;
            board.RowHeadersWidth = 51;
            board.RowTemplate.Height = 29;
            board.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            board.Size = new Size(1043, 291);
            board.TabIndex = 0;
            board.CellClick += board_CellClick;
            board.CellContentClick += board_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 240);
            label8.Name = "label8";
            label8.Size = new Size(138, 20);
            label8.TabIndex = 5;
            label8.Text = "Danh sách sinh viên";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 593);
            Controls.Add(label8);
            Controls.Add(panel3);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)board).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private ComboBox selectQueQuan;
        private TextBox inputHocLuc;
        private Label label4;
        private Label label3;
        private TextBox inputMSSV;
        private Label label2;
        private Label label6;
        private TextBox inputHoten;
        private Label label5;
        private Panel panel2;
        private Button btnWatchPrint;
        private Button btnCancel;
        private Button btnSave;
        private Button btnEdit;
        private Button btnRemove;
        private Button btnAdd;
        private Label label7;
        private Panel panel3;
        private Label label8;
        public DataGridView board;
        private TextBox inputQuangDuong;
    }
}