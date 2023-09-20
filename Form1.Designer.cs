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
            inputNgaySinh = new DateTimePicker();
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
            label1.Location = new Point(28, 7);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 0;
            label1.Text = "Thông tin sinh viên";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(inputNgaySinh);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(inputHoten);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(selectQueQuan);
            panel1.Controls.Add(inputHocLuc);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(inputMSSV);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(18, 16);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 99);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // inputNgaySinh
            // 
            inputNgaySinh.Location = new Point(555, 40);
            inputNgaySinh.Margin = new Padding(3, 2, 3, 2);
            inputNgaySinh.Name = "inputNgaySinh";
            inputNgaySinh.Size = new Size(358, 23);
            inputNgaySinh.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(481, 43);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 9;
            label6.Text = "Ngày sinh";
            // 
            // inputHoten
            // 
            inputHoten.Location = new Point(556, 11);
            inputHoten.Margin = new Padding(3, 2, 3, 2);
            inputHoten.Name = "inputHoten";
            inputHoten.Size = new Size(358, 23);
            inputHoten.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(481, 16);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 7;
            label5.Text = "Họ tên";
            // 
            // selectQueQuan
            // 
            selectQueQuan.FormattingEnabled = true;
            selectQueQuan.Items.AddRange(new object[] { "Sài Gòn", "Thanh Hóa", "Nghệ An", "Long An", "Quảng Ngãi" });
            selectQueQuan.Location = new Point(135, 38);
            selectQueQuan.Margin = new Padding(3, 2, 3, 2);
            selectQueQuan.Name = "selectQueQuan";
            selectQueQuan.Size = new Size(330, 23);
            selectQueQuan.TabIndex = 6;
            selectQueQuan.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // inputHocLuc
            // 
            inputHocLuc.Location = new Point(135, 61);
            inputHocLuc.Margin = new Padding(3, 2, 3, 2);
            inputHocLuc.Name = "inputHocLuc";
            inputHocLuc.Size = new Size(330, 23);
            inputHocLuc.TabIndex = 5;
            inputHocLuc.KeyPress += inputHocLuc_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 66);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 4;
            label4.Text = "Học lực";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 41);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "Quê quán";
            // 
            // inputMSSV
            // 
            inputMSSV.Location = new Point(135, 11);
            inputMSSV.Margin = new Padding(3, 2, 3, 2);
            inputMSSV.Name = "inputMSSV";
            inputMSSV.Size = new Size(330, 23);
            inputMSSV.TabIndex = 1;
            inputMSSV.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 16);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
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
            panel2.Location = new Point(19, 128);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(933, 48);
            panel2.TabIndex = 2;
            // 
            // btnWatchPrint
            // 
            btnWatchPrint.Location = new Point(806, 6);
            btnWatchPrint.Margin = new Padding(3, 2, 3, 2);
            btnWatchPrint.Name = "btnWatchPrint";
            btnWatchPrint.Size = new Size(106, 34);
            btnWatchPrint.TabIndex = 5;
            btnWatchPrint.Text = "Xem in";
            btnWatchPrint.UseVisualStyleBackColor = true;
            btnWatchPrint.Click += button5_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(695, 6);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(106, 34);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(584, 6);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(106, 34);
            btnSave.TabIndex = 3;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(472, 6);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(106, 34);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(358, 6);
            btnRemove.Margin = new Padding(3, 2, 3, 2);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(106, 34);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Xóa";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(247, 6);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(106, 34);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 120);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 3;
            label7.Text = "Chức năng";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(board);
            panel3.Location = new Point(20, 188);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(932, 240);
            panel3.TabIndex = 4;
            // 
            // board
            // 
            board.AllowUserToOrderColumns = true;
            board.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            board.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            board.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            board.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            board.Location = new Point(7, 8);
            board.Margin = new Padding(3, 2, 3, 2);
            board.MultiSelect = false;
            board.Name = "board";
            board.ReadOnly = true;
            board.RowHeadersWidth = 51;
            board.RowTemplate.Height = 29;
            board.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            board.Size = new Size(913, 218);
            board.TabIndex = 0;
            board.CellClick += board_CellClick;
            board.CellContentClick += board_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 180);
            label8.Name = "label8";
            label8.Size = new Size(112, 15);
            label8.TabIndex = 5;
            label8.Text = "Danh sách sinh viên";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 445);
            Controls.Add(label8);
            Controls.Add(panel3);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
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
        private DateTimePicker inputNgaySinh;
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
    }
}