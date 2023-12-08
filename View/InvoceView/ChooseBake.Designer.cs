namespace FinalProject_QUANLYKHO.View.InvoceExportMaterialGoView
{
    partial class ChooseBake
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBake = new ListBox();
            panel2 = new Panel();
            buttonCustom3 = new ComponentCustom.ButtonCustom();
            inputSearch = new TextBox();
            btnSelect = new ComponentCustom.ButtonCustom();
            buttonCustom1 = new ComponentCustom.ButtonCustom();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // listBake
            // 
            listBake.BackColor = Color.FromArgb(28, 38, 45);
            listBake.BorderStyle = BorderStyle.FixedSingle;
            listBake.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            listBake.ForeColor = Color.White;
            listBake.FormattingEnabled = true;
            listBake.ItemHeight = 18;
            listBake.Location = new Point(14, 83);
            listBake.Margin = new Padding(3, 4, 3, 4);
            listBake.Name = "listBake";
            listBake.Size = new Size(272, 308);
            listBake.TabIndex = 0;
            listBake.SelectedIndexChanged += listBake_SelectedIndexChanged;

            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(39, 52, 62);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(buttonCustom3);
            panel2.Controls.Add(inputSearch);
            panel2.Location = new Point(14, 40);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 31);
            panel2.TabIndex = 30;
            // 
            // buttonCustom3
            // 
            buttonCustom3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCustom3.BackColor = Color.FromArgb(39, 52, 62);
            buttonCustom3.BackgroundColor = Color.FromArgb(39, 52, 62);
            buttonCustom3.BorderColor = Color.PaleVioletRed;
            buttonCustom3.BorderRadius = 6;
            buttonCustom3.BorderSize = 0;
            buttonCustom3.FlatAppearance.BorderSize = 0;
            buttonCustom3.FlatStyle = FlatStyle.Flat;
            buttonCustom3.ForeColor = Color.Black;
            buttonCustom3.Image = Properties.Resources.search1;
            buttonCustom3.Location = new Point(-1, -1);
            buttonCustom3.Margin = new Padding(3, 4, 3, 4);
            buttonCustom3.Name = "buttonCustom3";
            buttonCustom3.Size = new Size(33, 35);
            buttonCustom3.TabIndex = 32;
            buttonCustom3.TextAlign = ContentAlignment.MiddleRight;
            buttonCustom3.TextColor = Color.Black;
            buttonCustom3.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCustom3.UseVisualStyleBackColor = false;
            // 
            // inputSearch
            // 
            inputSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputSearch.BackColor = Color.FromArgb(39, 52, 62);
            inputSearch.BorderStyle = BorderStyle.None;
            inputSearch.Cursor = Cursors.IBeam;
            inputSearch.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            inputSearch.ForeColor = Color.White;
            inputSearch.Location = new Point(35, 5);
            inputSearch.Margin = new Padding(0);
            inputSearch.Name = "inputSearch";
            inputSearch.PlaceholderText = "Nhập từ khóa";
            inputSearch.Size = new Size(235, 20);
            inputSearch.TabIndex = 31;
            inputSearch.TextChanged += inputSearch_TextChanged;
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.FromArgb(37, 114, 226);
            btnSelect.BackgroundColor = Color.FromArgb(37, 114, 226);
            btnSelect.BorderColor = Color.PaleVioletRed;
            btnSelect.BorderRadius = 6;
            btnSelect.BorderSize = 0;
            btnSelect.FlatAppearance.BorderSize = 0;
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.ForeColor = Color.White;
            btnSelect.Location = new Point(101, 413);
            btnSelect.Margin = new Padding(3, 4, 3, 4);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(86, 31);
            btnSelect.TabIndex = 31;
            btnSelect.Text = "Chọn";
            btnSelect.TextColor = Color.White;
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // buttonCustom1
            // 
            buttonCustom1.BackColor = Color.Transparent;
            buttonCustom1.BackgroundColor = Color.Transparent;
            buttonCustom1.BorderColor = Color.PaleVioletRed;
            buttonCustom1.BorderRadius = 20;
            buttonCustom1.BorderSize = 0;
            buttonCustom1.FlatAppearance.BorderSize = 0;
            buttonCustom1.FlatStyle = FlatStyle.Flat;
            buttonCustom1.ForeColor = Color.White;
            buttonCustom1.Image = Properties.Resources.icons8_close_24;
            buttonCustom1.Location = new Point(269, 4);
            buttonCustom1.Margin = new Padding(3, 4, 3, 4);
            buttonCustom1.Name = "buttonCustom1";
            buttonCustom1.Size = new Size(27, 31);
            buttonCustom1.TabIndex = 32;
            buttonCustom1.TextColor = Color.White;
            buttonCustom1.UseVisualStyleBackColor = false;
            buttonCustom1.Click += buttonCustom1_Click;
            // 
            // ChooseBake
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 38, 45);
            ClientSize = new Size(298, 456);
            Controls.Add(buttonCustom1);
            Controls.Add(btnSelect);
            Controls.Add(panel2);
            Controls.Add(listBake);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ChooseBake";
            Text = "ChooseMaterial";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBake;
        private Panel panel2;
        private ComponentCustom.ButtonCustom buttonCustom3;
        private TextBox inputSearch;
        private ComponentCustom.ButtonCustom btnSelect;
        private ComponentCustom.ButtonCustom buttonCustom1;
    }
}