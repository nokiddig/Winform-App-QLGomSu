namespace BTLNhom01
{
    partial class FormHDB
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
            this.panelTool = new System.Windows.Forms.Panel();
            this.PanelSearch = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelDateTime = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelTien = new Guna.UI2.WinForms.Guna2Panel();
            this.txtTo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFrom = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.cmbChoice = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.SoHDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.panelTool.SuspendLayout();
            this.PanelSearch.SuspendLayout();
            this.PanelDateTime.SuspendLayout();
            this.PanelTien.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTool
            // 
            this.panelTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelTool.Controls.Add(this.PanelSearch);
            this.panelTool.Controls.Add(this.guna2Panel2);
            this.panelTool.Controls.Add(this.guna2Panel3);
            this.panelTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTool.Location = new System.Drawing.Point(0, 0);
            this.panelTool.Name = "panelTool";
            this.panelTool.Size = new System.Drawing.Size(1132, 110);
            this.panelTool.TabIndex = 4;
            // 
            // PanelSearch
            // 
            this.PanelSearch.Controls.Add(this.PanelDateTime);
            this.PanelSearch.Controls.Add(this.txtSearch);
            this.PanelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelSearch.Location = new System.Drawing.Point(225, 0);
            this.PanelSearch.Name = "PanelSearch";
            this.PanelSearch.Size = new System.Drawing.Size(633, 110);
            this.PanelSearch.TabIndex = 2;
            // 
            // PanelDateTime
            // 
            this.PanelDateTime.Controls.Add(this.PanelTien);
            this.PanelDateTime.Controls.Add(this.label7);
            this.PanelDateTime.Controls.Add(this.label5);
            this.PanelDateTime.Controls.Add(this.dtpTo);
            this.PanelDateTime.Controls.Add(this.dtpFrom);
            this.PanelDateTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDateTime.Location = new System.Drawing.Point(0, 0);
            this.PanelDateTime.Name = "PanelDateTime";
            this.PanelDateTime.Size = new System.Drawing.Size(633, 110);
            this.PanelDateTime.TabIndex = 5;
            // 
            // PanelTien
            // 
            this.PanelTien.Controls.Add(this.txtTo);
            this.PanelTien.Controls.Add(this.label8);
            this.PanelTien.Controls.Add(this.txtFrom);
            this.PanelTien.Controls.Add(this.label6);
            this.PanelTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTien.Location = new System.Drawing.Point(0, 0);
            this.PanelTien.Name = "PanelTien";
            this.PanelTien.Size = new System.Drawing.Size(633, 110);
            this.PanelTien.TabIndex = 6;
            // 
            // txtTo
            // 
            this.txtTo.BorderColor = System.Drawing.Color.Empty;
            this.txtTo.BorderRadius = 10;
            this.txtTo.BorderThickness = 2;
            this.txtTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTo.DefaultText = "";
            this.txtTo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.txtTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtTo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTo.Location = new System.Drawing.Point(353, 39);
            this.txtTo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTo.Name = "txtTo";
            this.txtTo.PasswordChar = '\0';
            this.txtTo.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtTo.PlaceholderText = "";
            this.txtTo.SelectedText = "";
            this.txtTo.Size = new System.Drawing.Size(178, 54);
            this.txtTo.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(349, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Đến";
            // 
            // txtFrom
            // 
            this.txtFrom.BorderColor = System.Drawing.Color.Empty;
            this.txtFrom.BorderRadius = 10;
            this.txtFrom.BorderThickness = 2;
            this.txtFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFrom.DefaultText = "";
            this.txtFrom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFrom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFrom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFrom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFrom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFrom.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.txtFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtFrom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFrom.Location = new System.Drawing.Point(118, 39);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(4);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.PasswordChar = '\0';
            this.txtFrom.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtFrom.PlaceholderText = "";
            this.txtFrom.SelectedText = "";
            this.txtFrom.Size = new System.Drawing.Size(178, 54);
            this.txtFrom.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(114, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tổng tiền từ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(349, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Đến ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(128, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Từ ngày";
            // 
            // dtpTo
            // 
            this.dtpTo.BorderColor = System.Drawing.Color.Transparent;
            this.dtpTo.BorderRadius = 10;
            this.dtpTo.Checked = true;
            this.dtpTo.FillColor = System.Drawing.Color.White;
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dtpTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(353, 38);
            this.dtpTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(173, 54);
            this.dtpTo.TabIndex = 5;
            this.dtpTo.Value = new System.DateTime(2022, 11, 2, 11, 52, 17, 373);
            // 
            // dtpFrom
            // 
            this.dtpFrom.BorderColor = System.Drawing.Color.Transparent;
            this.dtpFrom.BorderRadius = 10;
            this.dtpFrom.Checked = true;
            this.dtpFrom.FillColor = System.Drawing.Color.White;
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dtpFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(132, 38);
            this.dtpFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(178, 54);
            this.dtpFrom.TabIndex = 4;
            this.dtpFrom.Value = new System.DateTime(2022, 11, 2, 11, 52, 17, 373);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearch.BorderColor = System.Drawing.Color.White;
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.BorderThickness = 2;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.txtSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(132, 35);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Tìm kiếm ...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(394, 54);
            this.txtSearch.TabIndex = 4;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.cmbChoice);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(225, 110);
            this.guna2Panel2.TabIndex = 5;
            // 
            // cmbChoice
            // 
            this.cmbChoice.BackColor = System.Drawing.Color.Transparent;
            this.cmbChoice.BorderRadius = 10;
            this.cmbChoice.BorderThickness = 0;
            this.cmbChoice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChoice.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbChoice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbChoice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cmbChoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbChoice.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChoice.ItemHeight = 45;
            this.cmbChoice.Items.AddRange(new object[] {
            "Số HĐ bán",
            "Mã nhân viên",
            "Ngày bán",
            "Mã khách",
            "Tổng tiền"});
            this.cmbChoice.ItemsAppearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChoice.Location = new System.Drawing.Point(31, 38);
            this.cmbChoice.Name = "cmbChoice";
            this.cmbChoice.Size = new System.Drawing.Size(181, 51);
            this.cmbChoice.StartIndex = 0;
            this.cmbChoice.TabIndex = 0;
            this.cmbChoice.SelectedIndexChanged += new System.EventHandler(this.cmbChoice_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(27, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm theo";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.btnSearch);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel3.Location = new System.Drawing.Point(858, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(274, 110);
            this.guna2Panel3.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.BorderRadius = 10;
            this.btnSearch.BorderThickness = 2;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.Location = new System.Drawing.Point(85, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 54);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm";
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 80;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoHDB,
            this.MaNV,
            this.NgayBan,
            this.MaKhach,
            this.TongTien});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(31, 128);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.guna2DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.guna2DataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.guna2DataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.guna2DataGridView1.RowTemplate.Height = 50;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1075, 522);
            this.guna2DataGridView1.TabIndex = 7;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 80;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 50;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.DoubleClick += new System.EventHandler(this.guna2DataGridView1_DoubleClick);
            // 
            // SoHDB
            // 
            this.SoHDB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoHDB.DataPropertyName = "SoHDB";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SoHDB.DefaultCellStyle = dataGridViewCellStyle3;
            this.SoHDB.HeaderText = "Số HDB";
            this.SoHDB.MinimumWidth = 6;
            this.SoHDB.Name = "SoHDB";
            this.SoHDB.ReadOnly = true;
            // 
            // MaNV
            // 
            this.MaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNV.DataPropertyName = "TenNV";
            this.MaNV.HeaderText = "Tên nhân viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaNV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NgayBan
            // 
            this.NgayBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayBan.DataPropertyName = "NgayBan";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NgayBan.DefaultCellStyle = dataGridViewCellStyle4;
            this.NgayBan.HeaderText = "Ngày bán";
            this.NgayBan.MinimumWidth = 6;
            this.NgayBan.Name = "NgayBan";
            this.NgayBan.ReadOnly = true;
            // 
            // MaKhach
            // 
            this.MaKhach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaKhach.DataPropertyName = "TenKhach";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MaKhach.DefaultCellStyle = dataGridViewCellStyle5;
            this.MaKhach.HeaderText = "Tên khách";
            this.MaKhach.MinimumWidth = 6;
            this.MaKhach.Name = "MaKhach";
            this.MaKhach.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnAdd);
            this.guna2Panel1.Controls.Add(this.btnDelete);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 656);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1132, 87);
            this.guna2Panel1.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BorderColor = System.Drawing.Color.Teal;
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.BorderThickness = 2;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.Teal;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdd.Location = new System.Drawing.Point(999, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 54);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BorderColor = System.Drawing.Color.DarkRed;
            this.btnDelete.BorderRadius = 10;
            this.btnDelete.BorderThickness = 2;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.DarkRed;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.btnDelete.Location = new System.Drawing.Point(877, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 54);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1132, 743);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.panelTool);
            this.Name = "FormHDB";
            this.Text = "Hóa đơn bán";
            this.Load += new System.EventHandler(this.FormHDB_Load);
            this.panelTool.ResumeLayout(false);
            this.PanelSearch.ResumeLayout(false);
            this.PanelDateTime.ResumeLayout(false);
            this.PanelDateTime.PerformLayout();
            this.PanelTien.ResumeLayout(false);
            this.PanelTien.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTool;
        private Guna.UI2.WinForms.Guna2Panel PanelSearch;
        private Guna.UI2.WinForms.Guna2Panel PanelDateTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFrom;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbChoice;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private Guna.UI2.WinForms.Guna2Panel PanelTien;
        private Guna.UI2.WinForms.Guna2TextBox txtTo;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtFrom;
        private System.Windows.Forms.Label label6;
    }
}