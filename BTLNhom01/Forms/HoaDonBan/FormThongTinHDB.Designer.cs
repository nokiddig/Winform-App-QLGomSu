namespace BTLNhom01.Forms.HoaDonBan
{
    partial class FormThongTinHDB
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
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblNguoiMua = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNguoiLap = new System.Windows.Forms.Label();
            this.lblSoHoaDon = new System.Windows.Forms.Label();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.White;
            this.guna2GroupBox2.Controls.Add(this.dgv);
            this.guna2GroupBox2.Controls.Add(this.lblTongTien);
            this.guna2GroupBox2.Controls.Add(this.lblNguoiMua);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.WhiteSmoke;
            this.guna2GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(0, 122);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(1079, 727);
            this.guna2GroupBox2.TabIndex = 23;
            this.guna2GroupBox2.Text = "Danh sách mặt hàng";
            this.guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.dgv.Location = new System.Drawing.Point(0, 52);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
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
            this.dgv.Size = new System.Drawing.Size(1079, 597);
            this.dgv.TabIndex = 20;
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
            this.dgv.ThemeStyle.ReadOnly = true;
            this.dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv.ThemeStyle.RowsStyle.Height = 50;
            this.dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MaHang
            // 
            this.MaHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHang.DataPropertyName = "MaHang";
            this.MaHang.HeaderText = "Mã hàng";
            this.MaHang.MinimumWidth = 6;
            this.MaHang.Name = "MaHang";
            this.MaHang.ReadOnly = true;
            // 
            // TenHang
            // 
            this.TenHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenHang.DataPropertyName = "TenHang";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TenHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.TenHang.HeaderText = "Tên hàng";
            this.TenHang.MinimumWidth = 6;
            this.TenHang.Name = "TenHang";
            this.TenHang.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SoLuong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGiaBan";
            this.DonGia.HeaderText = "Đơn giá bán";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // GiamGia
            // 
            this.GiamGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GiamGia.DataPropertyName = "GiamGia";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GiamGia.DefaultCellStyle = dataGridViewCellStyle4;
            this.GiamGia.HeaderText = "Giảm giá";
            this.GiamGia.MinimumWidth = 6;
            this.GiamGia.Name = "GiamGia";
            this.GiamGia.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ThanhTien.DefaultCellStyle = dataGridViewCellStyle5;
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.BackColor = System.Drawing.Color.White;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.lblTongTien.Location = new System.Drawing.Point(792, 688);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(84, 20);
            this.lblTongTien.TabIndex = 1;
            this.lblTongTien.Text = "Tổng tiền: ";
            // 
            // lblNguoiMua
            // 
            this.lblNguoiMua.AutoSize = true;
            this.lblNguoiMua.BackColor = System.Drawing.Color.White;
            this.lblNguoiMua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguoiMua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.lblNguoiMua.Location = new System.Drawing.Point(792, 668);
            this.lblNguoiMua.Name = "lblNguoiMua";
            this.lblNguoiMua.Size = new System.Drawing.Size(96, 20);
            this.lblNguoiMua.TabIndex = 18;
            this.lblNguoiMua.Text = "Người mua: ";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.label5);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblNguoiLap);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblSoHoaDon);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblNgayLap);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1079, 122);
            this.guna2CustomGradientPanel1.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label5.Location = new System.Drawing.Point(355, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(383, 38);
            this.label5.TabIndex = 18;
            this.label5.Text = "THÔNG TIN HOÁ ĐƠN BÁN";
            // 
            // lblNguoiLap
            // 
            this.lblNguoiLap.AutoSize = true;
            this.lblNguoiLap.BackColor = System.Drawing.Color.White;
            this.lblNguoiLap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguoiLap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.lblNguoiLap.Location = new System.Drawing.Point(12, 72);
            this.lblNguoiLap.Name = "lblNguoiLap";
            this.lblNguoiLap.Size = new System.Drawing.Size(86, 20);
            this.lblNguoiLap.TabIndex = 18;
            this.lblNguoiLap.Text = "Người lập: ";
            // 
            // lblSoHoaDon
            // 
            this.lblSoHoaDon.AutoSize = true;
            this.lblSoHoaDon.BackColor = System.Drawing.Color.White;
            this.lblSoHoaDon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.lblSoHoaDon.Location = new System.Drawing.Point(12, 53);
            this.lblSoHoaDon.Name = "lblSoHoaDon";
            this.lblSoHoaDon.Size = new System.Drawing.Size(91, 20);
            this.lblSoHoaDon.TabIndex = 17;
            this.lblSoHoaDon.Text = "Số hoá đơn:";
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.BackColor = System.Drawing.Color.White;
            this.lblNgayLap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayLap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.lblNgayLap.Location = new System.Drawing.Point(12, 92);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(79, 20);
            this.lblNgayLap.TabIndex = 17;
            this.lblNgayLap.Text = "Ngày lập: ";
            // 
            // FormThongTinHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1079, 849);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormThongTinHDB";
            this.Text = "FormThongTinHDB";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormThongTinHDB_FormClosed);
            this.Load += new System.EventHandler(this.FormThongTinHDB_Load);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.Label lblTongTien;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNguoiLap;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.Label lblSoHoaDon;
        private System.Windows.Forms.Label lblNguoiMua;
        private Guna.UI2.WinForms.Guna2DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}