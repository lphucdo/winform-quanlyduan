namespace QuanLyDuAn
{
    partial class DuAnForm
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachDuAn = new System.Windows.Forms.DataGridView();
            this.MaDuAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDuAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTriHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTriQuyetToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            this.txtTimKiem = new MaterialSkin.Controls.MaterialTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtGiaTriHopDong = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMaDuAn = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTenDuAn = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSoHopDong = new MaterialSkin.Controls.MaterialTextBox();
            this.btnHuy = new MaterialSkin.Controls.MaterialButton();
            this.btnLuu = new MaterialSkin.Controls.MaterialButton();
            this.btnXoa = new MaterialSkin.Controls.MaterialButton();
            this.btnThemMoi = new MaterialSkin.Controls.MaterialButton();
            this.txtGiaTriQuyetToan = new MaterialSkin.Controls.MaterialTextBox();
            this.dtpNgayHopDong = new System.Windows.Forms.DateTimePicker();
            this.cbxTrangThai = new MaterialSkin.Controls.MaterialComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDuAn)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 665);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Controls.Add(this.splitter2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 146);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(790, 519);
            this.panel4.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDanhSachDuAn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(790, 516);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách dự án";
            // 
            // dgvDanhSachDuAn
            // 
            this.dgvDanhSachDuAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachDuAn.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDanhSachDuAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachDuAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDuAn,
            this.TenDuAn,
            this.SoHopDong,
            this.NgayHopDong,
            this.GiaTriHopDong,
            this.GiaTriQuyetToan,
            this.TrangThai});
            this.dgvDanhSachDuAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachDuAn.Location = new System.Drawing.Point(3, 18);
            this.dgvDanhSachDuAn.Name = "dgvDanhSachDuAn";
            this.dgvDanhSachDuAn.RowHeadersWidth = 51;
            this.dgvDanhSachDuAn.RowTemplate.Height = 24;
            this.dgvDanhSachDuAn.Size = new System.Drawing.Size(784, 495);
            this.dgvDanhSachDuAn.TabIndex = 1;
            this.dgvDanhSachDuAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachDuAn_CellClick);
            // 
            // MaDuAn
            // 
            this.MaDuAn.DataPropertyName = "MaDuAn";
            this.MaDuAn.HeaderText = "Mã DA";
            this.MaDuAn.MinimumWidth = 6;
            this.MaDuAn.Name = "MaDuAn";
            // 
            // TenDuAn
            // 
            this.TenDuAn.DataPropertyName = "TenDuAn";
            this.TenDuAn.HeaderText = "TênDA";
            this.TenDuAn.MinimumWidth = 6;
            this.TenDuAn.Name = "TenDuAn";
            // 
            // SoHopDong
            // 
            this.SoHopDong.DataPropertyName = "SoHopDong";
            this.SoHopDong.HeaderText = "Số HĐ";
            this.SoHopDong.MinimumWidth = 6;
            this.SoHopDong.Name = "SoHopDong";
            // 
            // NgayHopDong
            // 
            this.NgayHopDong.DataPropertyName = "NgayHopDong";
            this.NgayHopDong.HeaderText = "NgàyHĐ";
            this.NgayHopDong.MinimumWidth = 6;
            this.NgayHopDong.Name = "NgayHopDong";
            // 
            // GiaTriHopDong
            // 
            this.GiaTriHopDong.DataPropertyName = "GiaTriHopDong";
            this.GiaTriHopDong.HeaderText = "GtrịHĐ";
            this.GiaTriHopDong.MinimumWidth = 6;
            this.GiaTriHopDong.Name = "GiaTriHopDong";
            // 
            // GiaTriQuyetToan
            // 
            this.GiaTriQuyetToan.DataPropertyName = "GiaTriQuyetToan";
            this.GiaTriQuyetToan.HeaderText = "GTrịQtoán";
            this.GiaTriQuyetToan.MinimumWidth = 6;
            this.GiaTriQuyetToan.Name = "GiaTriQuyetToan";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(790, 3);
            this.splitter2.TabIndex = 0;
            this.splitter2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(790, 146);
            this.panel3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 146);
            this.groupBox1.TabIndex = 2;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(784, 125);
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
            this.btnTimKiem.Location = new System.Drawing.Point(574, 44);
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
            this.txtTimKiem.Location = new System.Drawing.Point(143, 37);
            this.txtTimKiem.MaxLength = 50;
            this.txtTimKiem.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTimKiem.Multiline = false;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(424, 50);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.Text = "";
            this.txtTimKiem.TrailingIcon = null;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(790, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 665);
            this.panel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 665);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.txtGiaTriHopDong, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtMaDuAn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTenDuAn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtSoHopDong, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnHuy, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.btnLuu, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.btnXoa, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.btnThemMoi, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtGiaTriQuyetToan, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.dtpNgayHopDong, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbxTrangThai, 0, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(341, 644);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // txtGiaTriHopDong
            // 
            this.txtGiaTriHopDong.AnimateReadOnly = false;
            this.txtGiaTriHopDong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txtGiaTriHopDong, 4);
            this.txtGiaTriHopDong.Depth = 0;
            this.txtGiaTriHopDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGiaTriHopDong.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtGiaTriHopDong.Hint = "Nhập giá trị hợp đồng ( tỷ tỷ không dấu)";
            this.txtGiaTriHopDong.LeadingIcon = null;
            this.txtGiaTriHopDong.Location = new System.Drawing.Point(13, 344);
            this.txtGiaTriHopDong.MaxLength = 50;
            this.txtGiaTriHopDong.MouseState = MaterialSkin.MouseState.OUT;
            this.txtGiaTriHopDong.Multiline = false;
            this.txtGiaTriHopDong.Name = "txtGiaTriHopDong";
            this.txtGiaTriHopDong.Size = new System.Drawing.Size(315, 50);
            this.txtGiaTriHopDong.TabIndex = 17;
            this.txtGiaTriHopDong.Text = "";
            this.txtGiaTriHopDong.TrailingIcon = null;
            // 
            // txtMaDuAn
            // 
            this.txtMaDuAn.AnimateReadOnly = false;
            this.txtMaDuAn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txtMaDuAn, 4);
            this.txtMaDuAn.Depth = 0;
            this.txtMaDuAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaDuAn.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMaDuAn.Hint = "Nhập mã dự án (15 kí tự)";
            this.txtMaDuAn.LeadingIcon = null;
            this.txtMaDuAn.Location = new System.Drawing.Point(13, 108);
            this.txtMaDuAn.MaxLength = 50;
            this.txtMaDuAn.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaDuAn.Multiline = false;
            this.txtMaDuAn.Name = "txtMaDuAn";
            this.txtMaDuAn.Size = new System.Drawing.Size(315, 50);
            this.txtMaDuAn.TabIndex = 5;
            this.txtMaDuAn.Text = "";
            this.txtMaDuAn.TrailingIcon = null;
            // 
            // txtTenDuAn
            // 
            this.txtTenDuAn.AnimateReadOnly = false;
            this.txtTenDuAn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txtTenDuAn, 4);
            this.txtTenDuAn.Depth = 0;
            this.txtTenDuAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenDuAn.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTenDuAn.Hint = "Nhập tên dự án(50 kí tự)";
            this.txtTenDuAn.LeadingIcon = null;
            this.txtTenDuAn.Location = new System.Drawing.Point(13, 177);
            this.txtTenDuAn.MaxLength = 50;
            this.txtTenDuAn.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTenDuAn.Multiline = false;
            this.txtTenDuAn.Name = "txtTenDuAn";
            this.txtTenDuAn.Size = new System.Drawing.Size(315, 50);
            this.txtTenDuAn.TabIndex = 6;
            this.txtTenDuAn.Text = "";
            this.txtTenDuAn.TrailingIcon = null;
            // 
            // txtSoHopDong
            // 
            this.txtSoHopDong.AnimateReadOnly = false;
            this.txtSoHopDong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txtSoHopDong, 4);
            this.txtSoHopDong.Depth = 0;
            this.txtSoHopDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSoHopDong.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSoHopDong.Hint = "Nhập số hợp đồng (20 kí tự)";
            this.txtSoHopDong.LeadingIcon = null;
            this.txtSoHopDong.Location = new System.Drawing.Point(13, 241);
            this.txtSoHopDong.MaxLength = 50;
            this.txtSoHopDong.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSoHopDong.Multiline = false;
            this.txtSoHopDong.Name = "txtSoHopDong";
            this.txtSoHopDong.Size = new System.Drawing.Size(315, 50);
            this.txtSoHopDong.TabIndex = 7;
            this.txtSoHopDong.Text = "";
            this.txtSoHopDong.TrailingIcon = null;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHuy.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHuy.Depth = 0;
            this.btnHuy.HighEmphasis = true;
            this.btnHuy.Icon = null;
            this.btnHuy.Location = new System.Drawing.Point(14, 573);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHuy.Size = new System.Drawing.Size(61, 36);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHuy.UseAccentColor = false;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLuu.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLuu.Depth = 0;
            this.btnLuu.HighEmphasis = true;
            this.btnLuu.Icon = null;
            this.btnLuu.Location = new System.Drawing.Point(83, 573);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLuu.Size = new System.Drawing.Size(62, 36);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLuu.UseAccentColor = false;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXoa.Depth = 0;
            this.btnXoa.HighEmphasis = true;
            this.btnXoa.Icon = null;
            this.btnXoa.Location = new System.Drawing.Point(153, 573);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoa.Size = new System.Drawing.Size(70, 36);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXoa.UseAccentColor = false;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMoi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemMoi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThemMoi.Depth = 0;
            this.btnThemMoi.HighEmphasis = true;
            this.btnThemMoi.Icon = null;
            this.btnThemMoi.Location = new System.Drawing.Point(231, 573);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThemMoi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThemMoi.Size = new System.Drawing.Size(96, 36);
            this.btnThemMoi.TabIndex = 13;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThemMoi.UseAccentColor = false;
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // txtGiaTriQuyetToan
            // 
            this.txtGiaTriQuyetToan.AnimateReadOnly = false;
            this.txtGiaTriQuyetToan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txtGiaTriQuyetToan, 4);
            this.txtGiaTriQuyetToan.Depth = 0;
            this.txtGiaTriQuyetToan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGiaTriQuyetToan.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtGiaTriQuyetToan.Hint = "Nhập giá trị quyết toán (tỷ tỷ không dấu)";
            this.txtGiaTriQuyetToan.LeadingIcon = null;
            this.txtGiaTriQuyetToan.Location = new System.Drawing.Point(13, 408);
            this.txtGiaTriQuyetToan.MaxLength = 50;
            this.txtGiaTriQuyetToan.MouseState = MaterialSkin.MouseState.OUT;
            this.txtGiaTriQuyetToan.Multiline = false;
            this.txtGiaTriQuyetToan.Name = "txtGiaTriQuyetToan";
            this.txtGiaTriQuyetToan.Size = new System.Drawing.Size(315, 50);
            this.txtGiaTriQuyetToan.TabIndex = 15;
            this.txtGiaTriQuyetToan.Text = "";
            this.txtGiaTriQuyetToan.TrailingIcon = null;
            // 
            // dtpNgayHopDong
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.dtpNgayHopDong, 4);
            this.dtpNgayHopDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpNgayHopDong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHopDong.Location = new System.Drawing.Point(13, 299);
            this.dtpNgayHopDong.Name = "dtpNgayHopDong";
            this.dtpNgayHopDong.Size = new System.Drawing.Size(315, 22);
            this.dtpNgayHopDong.TabIndex = 18;
            // 
            // cbxTrangThai
            // 
            this.cbxTrangThai.AutoResize = false;
            this.cbxTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.SetColumnSpan(this.cbxTrangThai, 4);
            this.cbxTrangThai.Depth = 0;
            this.cbxTrangThai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxTrangThai.DropDownHeight = 174;
            this.cbxTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTrangThai.DropDownWidth = 121;
            this.cbxTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxTrangThai.FormattingEnabled = true;
            this.cbxTrangThai.Hint = "Chọn trạng thái:";
            this.cbxTrangThai.IntegralHeight = false;
            this.cbxTrangThai.ItemHeight = 43;
            this.cbxTrangThai.Location = new System.Drawing.Point(13, 471);
            this.cbxTrangThai.MaxDropDownItems = 4;
            this.cbxTrangThai.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxTrangThai.Name = "cbxTrangThai";
            this.cbxTrangThai.Size = new System.Drawing.Size(315, 49);
            this.cbxTrangThai.StartIndex = 0;
            this.cbxTrangThai.TabIndex = 19;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 665);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // DuAnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DuAnForm";
            this.Size = new System.Drawing.Size(1140, 665);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDuAn)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private MaterialSkin.Controls.MaterialTextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDanhSachDuAn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialTextBox txtMaDuAn;
        private MaterialSkin.Controls.MaterialTextBox txtTenDuAn;
        private MaterialSkin.Controls.MaterialTextBox txtSoHopDong;
        private MaterialSkin.Controls.MaterialButton btnHuy;
        private MaterialSkin.Controls.MaterialButton btnLuu;
        private MaterialSkin.Controls.MaterialButton btnXoa;
        private MaterialSkin.Controls.MaterialButton btnThemMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDuAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDuAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTriHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTriQuyetToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private MaterialSkin.Controls.MaterialTextBox txtGiaTriHopDong;
        private MaterialSkin.Controls.MaterialTextBox txtGiaTriQuyetToan;
        private System.Windows.Forms.DateTimePicker dtpNgayHopDong;
        private MaterialSkin.Controls.MaterialComboBox cbxTrangThai;
    }
}
