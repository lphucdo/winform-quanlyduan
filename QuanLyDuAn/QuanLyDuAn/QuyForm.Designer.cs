namespace QuanLyDuAn
{
    partial class QuyForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachQuy = new System.Windows.Forms.DataGridView();
            this.MaQuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenQuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NganHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            this.txtTimKiem = new MaterialSkin.Controls.MaterialTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnHuy = new MaterialSkin.Controls.MaterialButton();
            this.btnThemMoi = new MaterialSkin.Controls.MaterialButton();
            this.btnXoa = new MaterialSkin.Controls.MaterialButton();
            this.btnLuu = new MaterialSkin.Controls.MaterialButton();
            this.txtMaQuy = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTenQuy = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSoTK = new MaterialSkin.Controls.MaterialTextBox();
            this.cbxNganHang = new MaterialSkin.Controls.MaterialComboBox();
            this.txtSoTien = new MaterialSkin.Controls.MaterialTextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.txtSoTaiKhoan = new MaterialSkin.Controls.MaterialTextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachQuy)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 608);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(712, 500);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(712, 500);
            this.panel4.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDanhSachQuy);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(712, 500);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách quỹ đang có";
            // 
            // dgvDanhSachQuy
            // 
            this.dgvDanhSachQuy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachQuy.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDanhSachQuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachQuy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaQuy,
            this.TenQuy,
            this.SoTien,
            this.NganHang,
            this.SoTaiKhoan});
            this.dgvDanhSachQuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachQuy.Location = new System.Drawing.Point(3, 18);
            this.dgvDanhSachQuy.Name = "dgvDanhSachQuy";
            this.dgvDanhSachQuy.RowHeadersWidth = 51;
            this.dgvDanhSachQuy.RowTemplate.Height = 24;
            this.dgvDanhSachQuy.Size = new System.Drawing.Size(706, 479);
            this.dgvDanhSachQuy.TabIndex = 1;
            this.dgvDanhSachQuy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachQuy_CellContentClick);
            // 
            // MaQuy
            // 
            this.MaQuy.DataPropertyName = "MaQuy";
            this.MaQuy.HeaderText = "Mã Quỹ";
            this.MaQuy.MinimumWidth = 6;
            this.MaQuy.Name = "MaQuy";
            // 
            // TenQuy
            // 
            this.TenQuy.DataPropertyName = "TenQuy";
            this.TenQuy.HeaderText = "Tên Quỹ";
            this.TenQuy.MinimumWidth = 6;
            this.TenQuy.Name = "TenQuy";
            // 
            // SoTien
            // 
            this.SoTien.DataPropertyName = "SoTien";
            this.SoTien.HeaderText = "Số Tiền";
            this.SoTien.MinimumWidth = 6;
            this.SoTien.Name = "SoTien";
            // 
            // NganHang
            // 
            this.NganHang.DataPropertyName = "NganHang";
            this.NganHang.HeaderText = "Ngân Hàng";
            this.NganHang.MinimumWidth = 6;
            this.NganHang.Name = "NganHang";
            // 
            // SoTaiKhoan
            // 
            this.SoTaiKhoan.DataPropertyName = "SoTaiKhoan";
            this.SoTaiKhoan.HeaderText = "Số Tài Khoản";
            this.SoTaiKhoan.MinimumWidth = 6;
            this.SoTaiKhoan.Name = "SoTaiKhoan";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 108);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.80453F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.19547F));
            this.tableLayoutPanel2.Controls.Add(this.btnTimKiem, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtTimKiem, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(706, 87);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnTimKiem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTimKiem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTimKiem.Depth = 0;
            this.btnTimKiem.HighEmphasis = true;
            this.btnTimKiem.Icon = null;
            this.btnTimKiem.Location = new System.Drawing.Point(517, 25);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTimKiem.Size = new System.Drawing.Size(86, 36);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTimKiem.UseAccentColor = false;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtTimKiem.AnimateReadOnly = false;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiem.Depth = 0;
            this.txtTimKiem.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTimKiem.Hint = "Nhập từ khoá tìm kiếm";
            this.txtTimKiem.LeadingIcon = null;
            this.txtTimKiem.Location = new System.Drawing.Point(86, 18);
            this.txtTimKiem.MaxLength = 50;
            this.txtTimKiem.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTimKiem.Multiline = false;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(424, 50);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.Text = "";
            this.txtTimKiem.TrailingIcon = null;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox3);
            this.panel5.Controls.Add(this.splitter1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(712, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(358, 608);
            this.panel5.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 608);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnHuy, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnThemMoi, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnXoa, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnLuu, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtMaQuy, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTenQuy, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtSoTK, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbxNganHang, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtSoTien, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(349, 587);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHuy.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHuy.Depth = 0;
            this.btnHuy.HighEmphasis = true;
            this.btnHuy.Icon = null;
            this.btnHuy.Location = new System.Drawing.Point(14, 515);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHuy.Size = new System.Drawing.Size(74, 36);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHuy.UseAccentColor = false;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMoi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemMoi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThemMoi.Depth = 0;
            this.btnThemMoi.HighEmphasis = true;
            this.btnThemMoi.Icon = null;
            this.btnThemMoi.Location = new System.Drawing.Point(260, 515);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThemMoi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThemMoi.Size = new System.Drawing.Size(75, 36);
            this.btnThemMoi.TabIndex = 13;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThemMoi.UseAccentColor = false;
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXoa.Depth = 0;
            this.btnXoa.HighEmphasis = true;
            this.btnXoa.Icon = null;
            this.btnXoa.Location = new System.Drawing.Point(178, 515);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoa.Size = new System.Drawing.Size(74, 36);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXoa.UseAccentColor = false;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLuu.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLuu.Depth = 0;
            this.btnLuu.HighEmphasis = true;
            this.btnLuu.Icon = null;
            this.btnLuu.Location = new System.Drawing.Point(96, 515);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLuu.Size = new System.Drawing.Size(74, 36);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLuu.UseAccentColor = false;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtMaQuy
            // 
            this.txtMaQuy.AnimateReadOnly = false;
            this.txtMaQuy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txtMaQuy, 4);
            this.txtMaQuy.Depth = 0;
            this.txtMaQuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaQuy.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMaQuy.Hint = "Nhập mã quỹ (15 kí tự)";
            this.txtMaQuy.LeadingIcon = null;
            this.txtMaQuy.Location = new System.Drawing.Point(13, 93);
            this.txtMaQuy.MaxLength = 50;
            this.txtMaQuy.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaQuy.Multiline = false;
            this.txtMaQuy.Name = "txtMaQuy";
            this.txtMaQuy.Size = new System.Drawing.Size(323, 50);
            this.txtMaQuy.TabIndex = 5;
            this.txtMaQuy.Text = "";
            this.txtMaQuy.TrailingIcon = null;
            // 
            // txtTenQuy
            // 
            this.txtTenQuy.AnimateReadOnly = false;
            this.txtTenQuy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txtTenQuy, 4);
            this.txtTenQuy.Depth = 0;
            this.txtTenQuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenQuy.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTenQuy.Hint = "Nhập tên kí tự (50 kí tự)";
            this.txtTenQuy.LeadingIcon = null;
            this.txtTenQuy.Location = new System.Drawing.Point(13, 173);
            this.txtTenQuy.MaxLength = 50;
            this.txtTenQuy.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTenQuy.Multiline = false;
            this.txtTenQuy.Name = "txtTenQuy";
            this.txtTenQuy.Size = new System.Drawing.Size(323, 50);
            this.txtTenQuy.TabIndex = 6;
            this.txtTenQuy.Text = "";
            this.txtTenQuy.TrailingIcon = null;
            // 
            // txtSoTK
            // 
            this.txtSoTK.AnimateReadOnly = false;
            this.txtSoTK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txtSoTK, 4);
            this.txtSoTK.Depth = 0;
            this.txtSoTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSoTK.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSoTK.Hint = "Nhập số tài khoản";
            this.txtSoTK.LeadingIcon = null;
            this.txtSoTK.Location = new System.Drawing.Point(13, 413);
            this.txtSoTK.MaxLength = 50;
            this.txtSoTK.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSoTK.Multiline = false;
            this.txtSoTK.Name = "txtSoTK";
            this.txtSoTK.Size = new System.Drawing.Size(323, 50);
            this.txtSoTK.TabIndex = 15;
            this.txtSoTK.Text = "";
            this.txtSoTK.TrailingIcon = null;
            // 
            // cbxNganHang
            // 
            this.cbxNganHang.AutoResize = false;
            this.cbxNganHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.SetColumnSpan(this.cbxNganHang, 4);
            this.cbxNganHang.Depth = 0;
            this.cbxNganHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxNganHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxNganHang.DropDownHeight = 174;
            this.cbxNganHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNganHang.DropDownWidth = 121;
            this.cbxNganHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxNganHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxNganHang.FormattingEnabled = true;
            this.cbxNganHang.Hint = "Chọn ngân hàng";
            this.cbxNganHang.IntegralHeight = false;
            this.cbxNganHang.ItemHeight = 43;
            this.cbxNganHang.Location = new System.Drawing.Point(13, 333);
            this.cbxNganHang.MaxDropDownItems = 4;
            this.cbxNganHang.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxNganHang.Name = "cbxNganHang";
            this.cbxNganHang.Size = new System.Drawing.Size(323, 49);
            this.cbxNganHang.StartIndex = 0;
            this.cbxNganHang.TabIndex = 10;
            // 
            // txtSoTien
            // 
            this.txtSoTien.AnimateReadOnly = false;
            this.txtSoTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txtSoTien, 4);
            this.txtSoTien.Depth = 0;
            this.txtSoTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSoTien.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSoTien.Hint = "Nhập số tiền";
            this.txtSoTien.LeadingIcon = null;
            this.txtSoTien.Location = new System.Drawing.Point(13, 253);
            this.txtSoTien.MaxLength = 50;
            this.txtSoTien.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSoTien.Multiline = false;
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(323, 50);
            this.txtSoTien.TabIndex = 7;
            this.txtSoTien.Text = "";
            this.txtSoTien.TrailingIcon = null;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 608);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // txtSoTaiKhoan
            // 
            this.txtSoTaiKhoan.AnimateReadOnly = false;
            this.txtSoTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoTaiKhoan.Depth = 0;
            this.txtSoTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSoTaiKhoan.Hint = "Nhập số tài khoản";
            this.txtSoTaiKhoan.LeadingIcon = null;
            this.txtSoTaiKhoan.Location = new System.Drawing.Point(3, 225);
            this.txtSoTaiKhoan.MaxLength = 50;
            this.txtSoTaiKhoan.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSoTaiKhoan.Multiline = false;
            this.txtSoTaiKhoan.Name = "txtSoTaiKhoan";
            this.txtSoTaiKhoan.Size = new System.Drawing.Size(78, 50);
            this.txtSoTaiKhoan.TabIndex = 9;
            this.txtSoTaiKhoan.Text = "";
            this.txtSoTaiKhoan.TrailingIcon = null;
            // 
            // QuyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "QuyForm";
            this.Size = new System.Drawing.Size(1070, 608);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachQuy)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox txtTimKiem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Splitter splitter1;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private MaterialSkin.Controls.MaterialTextBox txtSoTaiKhoan;
        private MaterialSkin.Controls.MaterialTextBox txtSoTien;
        private MaterialSkin.Controls.MaterialTextBox txtTenQuy;
        private MaterialSkin.Controls.MaterialTextBox txtMaQuy;
        private MaterialSkin.Controls.MaterialButton btnXoa;
        private MaterialSkin.Controls.MaterialButton btnThemMoi;
        private MaterialSkin.Controls.MaterialButton btnLuu;
        private MaterialSkin.Controls.MaterialButton btnHuy;
        private MaterialSkin.Controls.MaterialComboBox cbxNganHang;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialTextBox txtSoTK;
        private System.Windows.Forms.DataGridView dgvDanhSachQuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaQuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenQuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NganHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTaiKhoan;
    }
}
