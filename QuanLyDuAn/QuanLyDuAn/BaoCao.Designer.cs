namespace QuanLyDuAn
{
    partial class BaoCao
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
            this.components = new System.ComponentModel.Container();
            this.chiTietDuAnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXuatExcel = new MaterialSkin.Controls.MaterialButton();
            this.btnBaoCao = new MaterialSkin.Controls.MaterialButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCPMay = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDuAnBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chiTietDuAnBindingSource
            // 
            this.chiTietDuAnBindingSource.DataSource = typeof(QuanLyDuAn.Request.ChiTietDuAn);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1229, 107);
            this.panel2.TabIndex = 2;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXuatExcel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXuatExcel.Depth = 0;
            this.btnXuatExcel.HighEmphasis = true;
            this.btnXuatExcel.Icon = null;
            this.btnXuatExcel.Location = new System.Drawing.Point(212, 82);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXuatExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXuatExcel.Size = new System.Drawing.Size(256, 36);
            this.btnXuatExcel.TabIndex = 3;
            this.btnXuatExcel.Text = "Báo Cáo Chi Tiết Chi Phí Vật Tư";
            this.btnXuatExcel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnXuatExcel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXuatExcel.UseAccentColor = false;
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBaoCao.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBaoCao.Depth = 0;
            this.btnBaoCao.HighEmphasis = true;
            this.btnBaoCao.Icon = null;
            this.btnBaoCao.Location = new System.Drawing.Point(476, 82);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBaoCao.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBaoCao.Size = new System.Drawing.Size(193, 36);
            this.btnBaoCao.TabIndex = 1;
            this.btnBaoCao.Text = "Báo Cáo Chi Tiết Dự Án";
            this.btnBaoCao.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBaoCao.UseAccentColor = false;
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCPMay);
            this.panel3.Controls.Add(this.btnXuatExcel);
            this.panel3.Controls.Add(this.btnBaoCao);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1229, 543);
            this.panel3.TabIndex = 3;
            // 
            // btnCPMay
            // 
            this.btnCPMay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCPMay.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCPMay.Depth = 0;
            this.btnCPMay.HighEmphasis = true;
            this.btnCPMay.Icon = null;
            this.btnCPMay.Location = new System.Drawing.Point(677, 82);
            this.btnCPMay.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCPMay.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCPMay.Name = "btnCPMay";
            this.btnCPMay.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCPMay.Size = new System.Drawing.Size(236, 36);
            this.btnCPMay.TabIndex = 4;
            this.btnCPMay.Text = "Báo cáo chi tiết chi phí máy";
            this.btnCPMay.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCPMay.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCPMay.UseAccentColor = false;
            this.btnCPMay.UseVisualStyleBackColor = true;
            this.btnCPMay.Click += new System.EventHandler(this.btnCPMay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO";
            // 
            // BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "BaoCao";
            this.Size = new System.Drawing.Size(1229, 650);
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDuAnBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialButton btnXuatExcel;
        private MaterialSkin.Controls.MaterialButton btnBaoCao;
        private System.Windows.Forms.BindingSource chiTietDuAnBindingSource;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton btnCPMay;
    }
}
