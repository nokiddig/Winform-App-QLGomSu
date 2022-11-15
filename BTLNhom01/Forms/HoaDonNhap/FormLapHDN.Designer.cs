namespace BTLNhom01.Forms.HoaDonNhap
{
    partial class FormLapHDN
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.txtSoLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbHangHoa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnThemVaoDS = new Guna.UI2.WinForms.Guna2Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGiamGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnThemHoaDon = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNhaCungCap = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblNguoiLap = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.txtDonGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label5.Location = new System.Drawing.Point(410, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 38);
            this.label5.TabIndex = 18;
            this.label5.Text = "LẬP HOÁ ĐƠN NHẬP";
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.BackColor = System.Drawing.Color.White;
            this.lblNgayLap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayLap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.lblNgayLap.Location = new System.Drawing.Point(12, 66);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(79, 20);
            this.lblNgayLap.TabIndex = 17;
            this.lblNgayLap.Text = "Ngày lập: ";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoLuong.BorderRadius = 10;
            this.txtSoLuong.BorderThickness = 2;
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuong.DefaultText = "";
            this.txtSoLuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.ForeColor = System.Drawing.Color.DimGray;
            this.txtSoLuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuong.Location = new System.Drawing.Point(536, 96);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(5);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.PasswordChar = '\0';
            this.txtSoLuong.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSoLuong.PlaceholderText = "";
            this.txtSoLuong.SelectedText = "";
            this.txtSoLuong.Size = new System.Drawing.Size(92, 47);
            this.txtSoLuong.TabIndex = 3;
            // 
            // cmbHangHoa
            // 
            this.cmbHangHoa.BackColor = System.Drawing.Color.Transparent;
            this.cmbHangHoa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbHangHoa.BorderRadius = 10;
            this.cmbHangHoa.BorderThickness = 2;
            this.cmbHangHoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHangHoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHangHoa.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbHangHoa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbHangHoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHangHoa.ForeColor = System.Drawing.Color.DimGray;
            this.cmbHangHoa.ItemHeight = 40;
            this.cmbHangHoa.Location = new System.Drawing.Point(273, 97);
            this.cmbHangHoa.Name = "cmbHangHoa";
            this.cmbHangHoa.Size = new System.Drawing.Size(241, 46);
            this.cmbHangHoa.TabIndex = 2;
            // 
            // btnThemVaoDS
            // 
            this.btnThemVaoDS.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThemVaoDS.BorderRadius = 10;
            this.btnThemVaoDS.BorderThickness = 2;
            this.btnThemVaoDS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemVaoDS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemVaoDS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemVaoDS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemVaoDS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnThemVaoDS.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemVaoDS.ForeColor = System.Drawing.Color.White;
            this.btnThemVaoDS.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnThemVaoDS.Location = new System.Drawing.Point(974, 96);
            this.btnThemVaoDS.Name = "btnThemVaoDS";
            this.btnThemVaoDS.Size = new System.Drawing.Size(96, 44);
            this.btnThemVaoDS.TabIndex = 5;
            this.btnThemVaoDS.Text = "+";
            this.btnThemVaoDS.Click += new System.EventHandler(this.btnThemVaoDS_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label14.Location = new System.Drawing.Point(814, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 28);
            this.label14.TabIndex = 1;
            this.label14.Text = "Giảm giá (%)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label7.Location = new System.Drawing.Point(320, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "Chọn sản phẩm";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGiamGia.BorderRadius = 10;
            this.txtGiamGia.BorderThickness = 2;
            this.txtGiamGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiamGia.DefaultText = "";
            this.txtGiamGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiamGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiamGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiamGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiamGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiamGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtGiamGia.ForeColor = System.Drawing.Color.DimGray;
            this.txtGiamGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiamGia.Location = new System.Drawing.Point(807, 96);
            this.txtGiamGia.Margin = new System.Windows.Forms.Padding(5);
            this.txtGiamGia.Multiline = true;
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.PasswordChar = '\0';
            this.txtGiamGia.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtGiamGia.PlaceholderText = "";
            this.txtGiamGia.SelectedText = "";
            this.txtGiamGia.Size = new System.Drawing.Size(140, 47);
            this.txtGiamGia.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label11.Location = new System.Drawing.Point(531, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 28);
            this.label11.TabIndex = 1;
            this.label11.Text = "Số lượng";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.BackColor = System.Drawing.Color.White;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.lblTongTien.Location = new System.Drawing.Point(792, 658);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(84, 20);
            this.lblTongTien.TabIndex = 1;
            this.lblTongTien.Text = "Tổng tiền: ";
            // 
            // btnThemHoaDon
            // 
            this.btnThemHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemHoaDon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThemHoaDon.BorderRadius = 10;
            this.btnThemHoaDon.BorderThickness = 2;
            this.btnThemHoaDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemHoaDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemHoaDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemHoaDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemHoaDon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnThemHoaDon.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnThemHoaDon.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnThemHoaDon.Location = new System.Drawing.Point(425, 678);
            this.btnThemHoaDon.Name = "btnThemHoaDon";
            this.btnThemHoaDon.Size = new System.Drawing.Size(252, 54);
            this.btnThemHoaDon.TabIndex = 6;
            this.btnThemHoaDon.Text = "Thêm hoá đơn";
            this.btnThemHoaDon.Click += new System.EventHandler(this.btnThemHoaDon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(40, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn nhà cung cấp";
            // 
            // cmbNhaCungCap
            // 
            this.cmbNhaCungCap.BackColor = System.Drawing.Color.Transparent;
            this.cmbNhaCungCap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbNhaCungCap.BorderRadius = 10;
            this.cmbNhaCungCap.BorderThickness = 2;
            this.cmbNhaCungCap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNhaCungCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhaCungCap.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbNhaCungCap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNhaCungCap.ForeColor = System.Drawing.Color.DimGray;
            this.cmbNhaCungCap.ItemHeight = 40;
            this.cmbNhaCungCap.Location = new System.Drawing.Point(13, 97);
            this.cmbNhaCungCap.Name = "cmbNhaCungCap";
            this.cmbNhaCungCap.Size = new System.Drawing.Size(241, 46);
            this.cmbNhaCungCap.TabIndex = 1;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeight = 80;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHang,
            this.TenHang,
            this.SoLuong,
            this.DonGia,
            this.GiamGia,
            this.ThanhTien});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv.Location = new System.Drawing.Point(12, 163);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dgv.RowTemplate.Height = 50;
            this.dgv.Size = new System.Drawing.Size(1058, 481);
            this.dgv.TabIndex = 15;
            this.dgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv.ThemeStyle.HeaderStyle.Height = 80;
            this.dgv.ThemeStyle.ReadOnly = false;
            this.dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv.ThemeStyle.RowsStyle.Height = 50;
            this.dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.White;
            this.guna2GroupBox2.Controls.Add(this.lblTongTien);
            this.guna2GroupBox2.Controls.Add(this.btnThemHoaDon);
            this.guna2GroupBox2.Controls.Add(this.label1);
            this.guna2GroupBox2.Controls.Add(this.cmbNhaCungCap);
            this.guna2GroupBox2.Controls.Add(this.dgv);
            this.guna2GroupBox2.Controls.Add(this.txtSoLuong);
            this.guna2GroupBox2.Controls.Add(this.cmbHangHoa);
            this.guna2GroupBox2.Controls.Add(this.btnThemVaoDS);
            this.guna2GroupBox2.Controls.Add(this.label2);
            this.guna2GroupBox2.Controls.Add(this.label14);
            this.guna2GroupBox2.Controls.Add(this.label7);
            this.guna2GroupBox2.Controls.Add(this.txtDonGia);
            this.guna2GroupBox2.Controls.Add(this.txtGiamGia);
            this.guna2GroupBox2.Controls.Add(this.label11);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.WhiteSmoke;
            this.guna2GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(0, 93);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(1082, 748);
            this.guna2GroupBox2.TabIndex = 21;
            this.guna2GroupBox2.Text = "Thông tin hoá đơn";
            this.guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNguoiLap
            // 
            this.lblNguoiLap.AutoSize = true;
            this.lblNguoiLap.BackColor = System.Drawing.Color.White;
            this.lblNguoiLap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguoiLap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.lblNguoiLap.Location = new System.Drawing.Point(12, 46);
            this.lblNguoiLap.Name = "lblNguoiLap";
            this.lblNguoiLap.Size = new System.Drawing.Size(86, 20);
            this.lblNguoiLap.TabIndex = 18;
            this.lblNguoiLap.Text = "Người lập: ";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.label5);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblNguoiLap);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblNgayLap);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1082, 93);
            this.guna2CustomGradientPanel1.TabIndex = 20;
            // 
            // txtDonGia
            // 
            this.txtDonGia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDonGia.BorderRadius = 10;
            this.txtDonGia.BorderThickness = 2;
            this.txtDonGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonGia.DefaultText = "";
            this.txtDonGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDonGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDonGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDonGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtDonGia.ForeColor = System.Drawing.Color.DimGray;
            this.txtDonGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDonGia.Location = new System.Drawing.Point(651, 96);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(5);
            this.txtDonGia.Multiline = true;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.PasswordChar = '\0';
            this.txtDonGia.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtDonGia.PlaceholderText = "";
            this.txtDonGia.SelectedText = "";
            this.txtDonGia.Size = new System.Drawing.Size(128, 47);
            this.txtDonGia.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label2.Location = new System.Drawing.Point(672, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn giá";
            // 
            // MaHang
            // 
            this.MaHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHang.HeaderText = "Mã Hàng";
            this.MaHang.MinimumWidth = 6;
            this.MaHang.Name = "MaHang";
            // 
            // TenHang
            // 
            this.TenHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TenHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.TenHang.HeaderText = "Tên hàng";
            this.TenHang.MinimumWidth = 6;
            this.TenHang.Name = "TenHang";
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SoLuong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            // 
            // GiamGia
            // 
            this.GiamGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GiamGia.DefaultCellStyle = dataGridViewCellStyle4;
            this.GiamGia.HeaderText = "Giảm giá";
            this.GiamGia.MinimumWidth = 6;
            this.GiamGia.Name = "GiamGia";
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ThanhTien.DefaultCellStyle = dataGridViewCellStyle5;
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            // 
            // FormLapHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1082, 841);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormLapHDN";
            this.Text = "FormLapHDN";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLapHDN_FormClosed);
            this.Load += new System.EventHandler(this.FormLapHDN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNgayLap;
        private Guna.UI2.WinForms.Guna2TextBox txtSoLuong;
        private Guna.UI2.WinForms.Guna2ComboBox cmbHangHoa;
        private Guna.UI2.WinForms.Guna2Button btnThemVaoDS;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtGiamGia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTongTien;
        private Guna.UI2.WinForms.Guna2Button btnThemHoaDon;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbNhaCungCap;
        private Guna.UI2.WinForms.Guna2DataGridView dgv;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.Label lblNguoiLap;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}