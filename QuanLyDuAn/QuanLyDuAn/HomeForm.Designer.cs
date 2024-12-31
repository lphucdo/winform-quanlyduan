namespace QuanLyDuAn
{
    partial class HomeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQLUS = new MaterialSkin.Controls.MaterialButton();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.btnBaoCao = new MaterialSkin.Controls.MaterialButton();
            this.btnQuy = new MaterialSkin.Controls.MaterialButton();
            this.btnPhieuThuChi = new MaterialSkin.Controls.MaterialButton();
            this.btnNhaCungCap = new MaterialSkin.Controls.MaterialButton();
            this.btnHangMuc = new MaterialSkin.Controls.MaterialButton();
            this.btnDuAn = new MaterialSkin.Controls.MaterialButton();
            this.btnHome = new MaterialSkin.Controls.MaterialButton();
            this.btnNhanVien = new MaterialSkin.Controls.MaterialButton();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.lblThongBao = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.viewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btnQLUS);
            this.panel1.Controls.Add(this.materialCheckbox1);
            this.panel1.Controls.Add(this.btnBaoCao);
            this.panel1.Controls.Add(this.btnQuy);
            this.panel1.Controls.Add(this.btnPhieuThuChi);
            this.panel1.Controls.Add(this.btnNhaCungCap);
            this.panel1.Controls.Add(this.btnHangMuc);
            this.panel1.Controls.Add(this.btnDuAn);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnNhanVien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 702);
            this.panel1.TabIndex = 0;
            // 
            // btnQLUS
            // 
            this.btnQLUS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQLUS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLUS.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnQLUS.Depth = 0;
            this.btnQLUS.HighEmphasis = true;
            this.btnQLUS.Icon = global::QuanLyDuAn.Properties.Resources.home_lock_custom;
            this.btnQLUS.Image = global::QuanLyDuAn.Properties.Resources.home_lock_custom;
            this.btnQLUS.Location = new System.Drawing.Point(0, 461);
            this.btnQLUS.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnQLUS.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQLUS.Name = "btnQLUS";
            this.btnQLUS.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnQLUS.Size = new System.Drawing.Size(150, 36);
            this.btnQLUS.TabIndex = 17;
            this.btnQLUS.Text = "Quản Lý User";
            this.btnQLUS.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnQLUS.UseAccentColor = false;
            this.btnQLUS.UseVisualStyleBackColor = true;
            this.btnQLUS.Click += new System.EventHandler(this.btnQLUS_Click);
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.AutoSize = true;
            this.materialCheckbox1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialCheckbox1.Checked = true;
            this.materialCheckbox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckbox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Location = new System.Drawing.Point(2, 517);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.ReadOnly = false;
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(35, 37);
            this.materialCheckbox1.TabIndex = 16;
            this.materialCheckbox1.ThreeState = true;
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            this.materialCheckbox1.CheckedChanged += new System.EventHandler(this.materialCheckbox1_CheckedChanged);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaoCao.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBaoCao.Depth = 0;
            this.btnBaoCao.HighEmphasis = true;
            this.btnBaoCao.Icon = global::QuanLyDuAn.Properties.Resources.finance_custom;
            this.btnBaoCao.Location = new System.Drawing.Point(3, 404);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBaoCao.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBaoCao.Size = new System.Drawing.Size(111, 36);
            this.btnBaoCao.TabIndex = 15;
            this.btnBaoCao.Text = "Báo Cáo";
            this.btnBaoCao.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBaoCao.UseAccentColor = false;
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnQuy
            // 
            this.btnQuy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuy.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnQuy.Depth = 0;
            this.btnQuy.HighEmphasis = true;
            this.btnQuy.Icon = global::QuanLyDuAn.Properties.Resources.cash_multiple_custom;
            this.btnQuy.Location = new System.Drawing.Point(3, 348);
            this.btnQuy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnQuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQuy.Name = "btnQuy";
            this.btnQuy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnQuy.Size = new System.Drawing.Size(78, 36);
            this.btnQuy.TabIndex = 14;
            this.btnQuy.Text = "Quỹ";
            this.btnQuy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnQuy.UseAccentColor = false;
            this.btnQuy.UseVisualStyleBackColor = true;
            this.btnQuy.Click += new System.EventHandler(this.btnQuy_Click);
            // 
            // btnPhieuThuChi
            // 
            this.btnPhieuThuChi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPhieuThuChi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhieuThuChi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPhieuThuChi.Depth = 0;
            this.btnPhieuThuChi.HighEmphasis = true;
            this.btnPhieuThuChi.Icon = global::QuanLyDuAn.Properties.Resources.receipt_text_custom;
            this.btnPhieuThuChi.Location = new System.Drawing.Point(3, 292);
            this.btnPhieuThuChi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPhieuThuChi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPhieuThuChi.Name = "btnPhieuThuChi";
            this.btnPhieuThuChi.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPhieuThuChi.Size = new System.Drawing.Size(119, 36);
            this.btnPhieuThuChi.TabIndex = 13;
            this.btnPhieuThuChi.Text = "Phiếu Chi";
            this.btnPhieuThuChi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPhieuThuChi.UseAccentColor = false;
            this.btnPhieuThuChi.UseVisualStyleBackColor = true;
            this.btnPhieuThuChi.Click += new System.EventHandler(this.btnPhieuThuChi_Click);
            // 
            // btnNhaCungCap
            // 
            this.btnNhaCungCap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNhaCungCap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhaCungCap.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNhaCungCap.Depth = 0;
            this.btnNhaCungCap.HighEmphasis = true;
            this.btnNhaCungCap.Icon = global::QuanLyDuAn.Properties.Resources.store_marker_custom;
            this.btnNhaCungCap.Location = new System.Drawing.Point(3, 122);
            this.btnNhaCungCap.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNhaCungCap.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNhaCungCap.Name = "btnNhaCungCap";
            this.btnNhaCungCap.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNhaCungCap.Size = new System.Drawing.Size(156, 36);
            this.btnNhaCungCap.TabIndex = 12;
            this.btnNhaCungCap.Text = "Nhà cung cấp";
            this.btnNhaCungCap.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNhaCungCap.UseAccentColor = false;
            this.btnNhaCungCap.UseVisualStyleBackColor = true;
            this.btnNhaCungCap.Click += new System.EventHandler(this.btnNhaCungCap_Click);
            // 
            // btnHangMuc
            // 
            this.btnHangMuc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHangMuc.BackColor = System.Drawing.Color.AliceBlue;
            this.btnHangMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHangMuc.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHangMuc.Depth = 0;
            this.btnHangMuc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHangMuc.HighEmphasis = true;
            this.btnHangMuc.Icon = global::QuanLyDuAn.Properties.Resources.format_list_bulleted_custom;
            this.btnHangMuc.Image = global::QuanLyDuAn.Properties.Resources.account_multiple_custom;
            this.btnHangMuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHangMuc.Location = new System.Drawing.Point(3, 234);
            this.btnHangMuc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHangMuc.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHangMuc.Name = "btnHangMuc";
            this.btnHangMuc.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHangMuc.Size = new System.Drawing.Size(126, 36);
            this.btnHangMuc.TabIndex = 11;
            this.btnHangMuc.Text = "Hạng mục";
            this.btnHangMuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHangMuc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnHangMuc.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHangMuc.UseAccentColor = false;
            this.btnHangMuc.UseVisualStyleBackColor = false;
            this.btnHangMuc.Click += new System.EventHandler(this.btnHangMuc_Click);
            // 
            // btnDuAn
            // 
            this.btnDuAn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDuAn.BackColor = System.Drawing.Color.AliceBlue;
            this.btnDuAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDuAn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDuAn.Depth = 0;
            this.btnDuAn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDuAn.HighEmphasis = true;
            this.btnDuAn.Icon = global::QuanLyDuAn.Properties.Resources.folder_multiple_plus_custom;
            this.btnDuAn.Image = global::QuanLyDuAn.Properties.Resources.account_multiple_custom;
            this.btnDuAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDuAn.Location = new System.Drawing.Point(3, 178);
            this.btnDuAn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDuAn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDuAn.Name = "btnDuAn";
            this.btnDuAn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDuAn.Size = new System.Drawing.Size(93, 36);
            this.btnDuAn.TabIndex = 10;
            this.btnDuAn.Text = "Dự Án";
            this.btnDuAn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDuAn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnDuAn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDuAn.UseAccentColor = false;
            this.btnDuAn.UseVisualStyleBackColor = false;
            this.btnDuAn.Click += new System.EventHandler(this.btnDuAn_Click);
            // 
            // btnHome
            // 
            this.btnHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHome.BackColor = System.Drawing.Color.AliceBlue;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHome.Depth = 0;
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHome.HighEmphasis = true;
            this.btnHome.Icon = global::QuanLyDuAn.Properties.Resources.home_custom;
            this.btnHome.Image = global::QuanLyDuAn.Properties.Resources.account_multiple_custom;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(3, 10);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHome.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHome.Name = "btnHome";
            this.btnHome.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHome.Size = new System.Drawing.Size(131, 36);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "Trang Chủ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnHome.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHome.UseAccentColor = false;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNhanVien.BackColor = System.Drawing.Color.AliceBlue;
            this.btnNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanVien.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNhanVien.Depth = 0;
            this.btnNhanVien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNhanVien.HighEmphasis = true;
            this.btnNhanVien.Icon = global::QuanLyDuAn.Properties.Resources.account_multiple_custom;
            this.btnNhanVien.Image = global::QuanLyDuAn.Properties.Resources.account_multiple_custom;
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(3, 66);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNhanVien.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNhanVien.Size = new System.Drawing.Size(127, 36);
            this.btnNhanVien.TabIndex = 8;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnNhanVien.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNhanVien.UseAccentColor = false;
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // viewPanel
            // 
            this.viewPanel.BackColor = System.Drawing.SystemColors.Control;
            this.viewPanel.Controls.Add(this.lblThongBao);
            this.viewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPanel.Location = new System.Drawing.Point(165, 72);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(1071, 702);
            this.viewPanel.TabIndex = 1;
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Depth = 0;
            this.lblThongBao.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblThongBao.Location = new System.Drawing.Point(17, 10);
            this.lblThongBao.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(100, 19);
            this.lblThongBao.TabIndex = 2;
            this.lblThongBao.Text = "Xin Chào User";
            this.lblThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 774);
            this.Controls.Add(this.viewPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeForm";
            this.Padding = new System.Windows.Forms.Padding(0, 72, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Dự Án";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.viewPanel.ResumeLayout(false);
            this.viewPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton btnNhanVien;
        private MaterialSkin.Controls.MaterialButton btnBaoCao;
        private MaterialSkin.Controls.MaterialButton btnQuy;
        private MaterialSkin.Controls.MaterialButton btnPhieuThuChi;
        private MaterialSkin.Controls.MaterialButton btnNhaCungCap;
        private MaterialSkin.Controls.MaterialButton btnHangMuc;
        private MaterialSkin.Controls.MaterialButton btnDuAn;
        private MaterialSkin.Controls.MaterialButton btnHome;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private System.Windows.Forms.Panel viewPanel;
        private MaterialSkin.Controls.MaterialLabel lblThongBao;
        private MaterialSkin.Controls.MaterialButton btnQLUS;
    }
}