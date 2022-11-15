namespace BTLNhom01
{
    partial class FormThemNhanVien
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
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtpNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbGioiTinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDienThoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.White;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Controls.Add(this.dtpNgaySinh);
            this.guna2GroupBox1.Controls.Add(this.cmbGioiTinh);
            this.guna2GroupBox1.Controls.Add(this.label13);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label11);
            this.guna2GroupBox1.Controls.Add(this.txtDiaChi);
            this.guna2GroupBox1.Controls.Add(this.txtTenNV);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label12);
            this.guna2GroupBox1.Controls.Add(this.txtDienThoai);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(25, 35);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(532, 385);
            this.guna2GroupBox1.TabIndex = 2;
            this.guna2GroupBox1.Text = "NHÂN VIÊN MỚI";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.BorderColor = System.Drawing.Color.DimGray;
            this.dtpNgaySinh.BorderRadius = 10;
            this.dtpNgaySinh.BorderThickness = 2;
            this.dtpNgaySinh.Checked = true;
            this.dtpNgaySinh.FillColor = System.Drawing.Color.White;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(312, 205);
            this.dtpNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 47);
            this.dtpNgaySinh.TabIndex = 4;
            this.dtpNgaySinh.Value = new System.DateTime(2002, 9, 23, 0, 0, 0, 0);
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.cmbGioiTinh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbGioiTinh.BorderRadius = 10;
            this.cmbGioiTinh.BorderThickness = 2;
            this.cmbGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGioiTinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbGioiTinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbGioiTinh.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGioiTinh.ForeColor = System.Drawing.Color.DimGray;
            this.cmbGioiTinh.ItemHeight = 40;
            this.cmbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbGioiTinh.Location = new System.Drawing.Point(316, 99);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Size = new System.Drawing.Size(196, 46);
            this.cmbGioiTinh.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label13.Location = new System.Drawing.Point(233, 276);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 28);
            this.label13.TabIndex = 1;
            this.label13.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label2.Location = new System.Drawing.Point(23, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label11.Location = new System.Drawing.Point(311, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 28);
            this.label11.TabIndex = 1;
            this.label11.Text = "Ngày sinh";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiaChi.BorderRadius = 10;
            this.txtDiaChi.BorderThickness = 2;
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.DefaultText = "";
            this.txtDiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.DimGray;
            this.txtDiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Location = new System.Drawing.Point(28, 309);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(5);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtDiaChi.PlaceholderText = "Nhập địa chỉ";
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(484, 47);
            this.txtDiaChi.TabIndex = 5;
            // 
            // txtTenNV
            // 
            this.txtTenNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenNV.BorderRadius = 10;
            this.txtTenNV.BorderThickness = 2;
            this.txtTenNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNV.DefaultText = "";
            this.txtTenNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.ForeColor = System.Drawing.Color.DimGray;
            this.txtTenNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNV.Location = new System.Drawing.Point(28, 99);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenNV.Multiline = true;
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.PasswordChar = '\0';
            this.txtTenNV.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTenNV.PlaceholderText = "Nhập tên nhân viên";
            this.txtTenNV.SelectedText = "";
            this.txtTenNV.Size = new System.Drawing.Size(196, 47);
            this.txtTenNV.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label3.Location = new System.Drawing.Point(311, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giới tính";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label12.Location = new System.Drawing.Point(23, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 28);
            this.label12.TabIndex = 1;
            this.label12.Text = "Điện thoại";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDienThoai.BorderRadius = 10;
            this.txtDienThoai.BorderThickness = 2;
            this.txtDienThoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDienThoai.DefaultText = "";
            this.txtDienThoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDienThoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDienThoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDienThoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDienThoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDienThoai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienThoai.ForeColor = System.Drawing.Color.DimGray;
            this.txtDienThoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDienThoai.Location = new System.Drawing.Point(28, 205);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(5);
            this.txtDienThoai.Multiline = true;
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.PasswordChar = '\0';
            this.txtDienThoai.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtDienThoai.PlaceholderText = "Nhập SĐT";
            this.txtDienThoai.SelectedText = "";
            this.txtDienThoai.Size = new System.Drawing.Size(196, 47);
            this.txtDienThoai.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.BorderRadius = 10;
            this.btnSave.BorderThickness = 2;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnSave.Location = new System.Drawing.Point(179, 443);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(235, 54);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Thêm nhân viên";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.guna2GroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormThemNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThemNhanVien";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormThemNhanVien_FormClosed);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbGioiTinh;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtDienThoai;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaySinh;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}