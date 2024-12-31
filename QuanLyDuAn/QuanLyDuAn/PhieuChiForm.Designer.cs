namespace QuanLyDuAn
{
    partial class PhieuChiForm
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
            this.dgvDanhSachPhieuChi = new System.Windows.Forms.DataGridView();
            this.SoPhieuChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaQuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiamDocDuyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            this.txtTimKiem = new MaterialSkin.Controls.MaterialTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSoPhieuChi = new MaterialSkin.Controls.MaterialTextBox();
            this.txtLyDo = new MaterialSkin.Controls.MaterialTextBox();
            this.txtGiamDocDuyet = new MaterialSkin.Controls.MaterialTextBox();
            this.btnHuy = new MaterialSkin.Controls.MaterialButton();
            this.btnLuu = new MaterialSkin.Controls.MaterialButton();
            this.btnXoa = new MaterialSkin.Controls.MaterialButton();
            this.btnThemMoi = new MaterialSkin.Controls.MaterialButton();
            this.txtSoTien = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMaQuy = new MaterialSkin.Controls.MaterialTextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuChi)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 634);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 140);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(874, 494);
            this.panel4.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDanhSachPhieuChi);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(874, 494);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhà cung cấp";
            // 
            // dgvDanhSachPhieuChi
            // 
            this.dgvDanhSachPhieuChi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachPhieuChi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDanhSachPhieuChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPhieuChi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhieuChi,
            this.LyDo,
            this.SoTien,
            this.MaQuy,
            this.GiamDocDuyet});
            this.dgvDanhSachPhieuChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachPhieuChi.Location = new System.Drawing.Point(3, 18);
            this.dgvDanhSachPhieuChi.Name = "dgvDanhSachPhieuChi";
            this.dgvDanhSachPhieuChi.RowHeadersWidth = 51;
            this.dgvDanhSachPhieuChi.RowTemplate.Height = 24;
            this.dgvDanhSachPhieuChi.Size = new System.Drawing.Size(868, 473);
            this.dgvDanhSachPhieuChi.TabIndex = 1;
            // 
            // SoPhieuChi
            // 
            this.SoPhieuChi.DataPropertyName = "SoPhieuChi";
            this.SoPhieuChi.HeaderText = "Số P.CHI";
            this.SoPhieuChi.MinimumWidth = 6;
            this.SoPhieuChi.Name = "SoPhieuChi";
            // 
            // LyDo
            // 
            this.LyDo.DataPropertyName = "LyDo";
            this.LyDo.HeaderText = "Lý Do";
            this.LyDo.MinimumWidth = 6;
            this.LyDo.Name = "LyDo";
            // 
            // SoTien
            // 
            this.SoTien.DataPropertyName = "SoTien";
            this.SoTien.HeaderText = "Số Tiền";
            this.SoTien.MinimumWidth = 6;
            this.SoTien.Name = "SoTien";
            // 
            // MaQuy
            // 
            this.MaQuy.DataPropertyName = "MaQuy";
            this.MaQuy.HeaderText = "Mã Quỹ";
            this.MaQuy.MinimumWidth = 6;
            this.MaQuy.Name = "MaQuy";
            // 
            // GiamDocDuyet
            // 
            this.GiamDocDuyet.DataPropertyName = "GiamDocDuyet";
            this.GiamDocDuyet.HeaderText = "Giám Đốc Duyệt";
            this.GiamDocDuyet.MinimumWidth = 6;
            this.GiamDocDuyet.Name = "GiamDocDuyet";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(874, 140);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(874, 140);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(868, 119);
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
            this.btnTimKiem.Location = new System.Drawing.Point(635, 41);
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
            this.txtTimKiem.Location = new System.Drawing.Point(204, 34);
            this.txtTimKiem.MaxLength = 50;
            this.txtTimKiem.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTimKiem.Multiline = false;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(424, 50);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.Text = "";
            this.txtTimKiem.TrailingIcon = null;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(874, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 634);
            this.panel3.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 634);
            this.groupBox3.TabIndex = 3;
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
            this.tableLayoutPanel1.Controls.Add(this.txtSoPhieuChi, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtLyDo, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtGiamDocDuyet, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnHuy, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnLuu, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnXoa, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnThemMoi, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtSoTien, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtMaQuy, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(318, 613);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // txtSoPhieuChi
            // 
            this.txtSoPhieuChi.AnimateReadOnly = false;
            this.txtSoPhieuChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txtSoPhieuChi, 4);
            this.txtSoPhieuChi.Depth = 0;
            this.txtSoPhieuChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSoPhieuChi.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSoPhieuChi.Hint = "Nhập số phiếu chi";
            this.txtSoPhieuChi.LeadingIcon = null;
            this.txtSoPhieuChi.Location = new System.Drawing.Point(13, 87);
            this.txtSoPhieuChi.MaxLength = 50;
            this.txtSoPhieuChi.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSoPhieuChi.Multiline = false;
            this.txtSoPhieuChi.Name = "txtSoPhieuChi";
            this.txtSoPhieuChi.Size = new System.Drawing.Size(292, 50);
            this.txtSoPhieuChi.TabIndex = 5;
            this.txtSoPhieuChi.Text = "";
            this.txtSoPhieuChi.TrailingIcon = null;
            // 
            // txtLyDo
            // 
            this.txtLyDo.AnimateReadOnly = false;
            this.txtLyDo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txtLyDo, 4);
            this.txtLyDo.Depth = 0;
            this.txtLyDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLyDo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLyDo.Hint = "Nhập lý do";
            this.txtLyDo.LeadingIcon = null;
            this.txtLyDo.Location = new System.Drawing.Point(13, 161);
            this.txtLyDo.MaxLength = 50;
            this.txtLyDo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLyDo.Multiline = false;
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(292, 50);
            this.txtLyDo.TabIndex = 6;
            this.txtLyDo.Text = "";
            this.txtLyDo.TrailingIcon = null;
            // 
            // txtGiamDocDuyet
            // 
            this.txtGiamDocDuyet.AnimateReadOnly = false;
            this.txtGiamDocDuyet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txtGiamDocDuyet, 4);
            this.txtGiamDocDuyet.Depth = 0;
            this.txtGiamDocDuyet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGiamDocDuyet.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtGiamDocDuyet.Hint = "Nhập số điện thoại (10 kí tự)";
            this.txtGiamDocDuyet.LeadingIcon = null;
            this.txtGiamDocDuyet.Location = new System.Drawing.Point(13, 383);
            this.txtGiamDocDuyet.MaxLength = 50;
            this.txtGiamDocDuyet.MouseState = MaterialSkin.MouseState.OUT;
            this.txtGiamDocDuyet.Multiline = false;
            this.txtGiamDocDuyet.Name = "txtGiamDocDuyet";
            this.txtGiamDocDuyet.Size = new System.Drawing.Size(292, 50);
            this.txtGiamDocDuyet.TabIndex = 7;
            this.txtGiamDocDuyet.Text = "";
            this.txtGiamDocDuyet.TrailingIcon = null;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHuy.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHuy.Depth = 0;
            this.btnHuy.HighEmphasis = true;
            this.btnHuy.Icon = null;
            this.btnHuy.Location = new System.Drawing.Point(14, 473);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHuy.Size = new System.Drawing.Size(66, 36);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHuy.UseAccentColor = false;
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLuu.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLuu.Depth = 0;
            this.btnLuu.HighEmphasis = true;
            this.btnLuu.Icon = null;
            this.btnLuu.Location = new System.Drawing.Point(88, 473);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLuu.Size = new System.Drawing.Size(66, 36);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLuu.UseAccentColor = false;
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXoa.Depth = 0;
            this.btnXoa.HighEmphasis = true;
            this.btnXoa.Icon = null;
            this.btnXoa.Location = new System.Drawing.Point(162, 473);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoa.Size = new System.Drawing.Size(66, 36);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXoa.UseAccentColor = false;
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMoi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemMoi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThemMoi.Depth = 0;
            this.btnThemMoi.HighEmphasis = true;
            this.btnThemMoi.Icon = null;
            this.btnThemMoi.Location = new System.Drawing.Point(236, 473);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThemMoi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThemMoi.Size = new System.Drawing.Size(68, 36);
            this.btnThemMoi.TabIndex = 13;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThemMoi.UseAccentColor = false;
            this.btnThemMoi.UseVisualStyleBackColor = true;
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
            this.txtSoTien.Location = new System.Drawing.Point(13, 235);
            this.txtSoTien.MaxLength = 50;
            this.txtSoTien.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSoTien.Multiline = false;
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(292, 50);
            this.txtSoTien.TabIndex = 15;
            this.txtSoTien.Text = "";
            this.txtSoTien.TrailingIcon = null;
            // 
            // txtMaQuy
            // 
            this.txtMaQuy.AnimateReadOnly = false;
            this.txtMaQuy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txtMaQuy, 4);
            this.txtMaQuy.Depth = 0;
            this.txtMaQuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaQuy.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMaQuy.Hint = "Nhập mã quỹ";
            this.txtMaQuy.LeadingIcon = null;
            this.txtMaQuy.Location = new System.Drawing.Point(13, 309);
            this.txtMaQuy.MaxLength = 50;
            this.txtMaQuy.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaQuy.Multiline = false;
            this.txtMaQuy.Name = "txtMaQuy";
            this.txtMaQuy.Size = new System.Drawing.Size(292, 50);
            this.txtMaQuy.TabIndex = 16;
            this.txtMaQuy.Text = "";
            this.txtMaQuy.TrailingIcon = null;
            // 
            // PhieuChiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "PhieuChiForm";
            this.Size = new System.Drawing.Size(1198, 634);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuChi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private MaterialSkin.Controls.MaterialTextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDanhSachPhieuChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhieuChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaQuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiamDocDuyet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialTextBox txtSoPhieuChi;
        private MaterialSkin.Controls.MaterialTextBox txtLyDo;
        private MaterialSkin.Controls.MaterialTextBox txtGiamDocDuyet;
        private MaterialSkin.Controls.MaterialButton btnHuy;
        private MaterialSkin.Controls.MaterialButton btnLuu;
        private MaterialSkin.Controls.MaterialButton btnXoa;
        private MaterialSkin.Controls.MaterialButton btnThemMoi;
        private MaterialSkin.Controls.MaterialTextBox txtSoTien;
        private MaterialSkin.Controls.MaterialTextBox txtMaQuy;
    }
}
