namespace QuanLyDuAn
{
    partial class BaoCaoChiTietVatTu
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBaoCaoCT = new MaterialSkin.Controls.MaterialButton();
            this.cbxMaDuAn = new MaterialSkin.Controls.MaterialComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.chiPhiVatTuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chiPhiVatTuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBaoCaoCT);
            this.panel1.Controls.Add(this.cbxMaDuAn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 108);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1203, 522);
            this.panel2.TabIndex = 1;
            // 
            // btnBaoCaoCT
            // 
            this.btnBaoCaoCT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBaoCaoCT.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBaoCaoCT.Depth = 0;
            this.btnBaoCaoCT.HighEmphasis = true;
            this.btnBaoCaoCT.Icon = null;
            this.btnBaoCaoCT.Location = new System.Drawing.Point(1102, 32);
            this.btnBaoCaoCT.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBaoCaoCT.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBaoCaoCT.Name = "btnBaoCaoCT";
            this.btnBaoCaoCT.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBaoCaoCT.Size = new System.Drawing.Size(83, 36);
            this.btnBaoCaoCT.TabIndex = 3;
            this.btnBaoCaoCT.Text = "Báo Cáo";
            this.btnBaoCaoCT.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBaoCaoCT.UseAccentColor = false;
            this.btnBaoCaoCT.UseVisualStyleBackColor = true;
            // 
            // cbxMaDuAn
            // 
            this.cbxMaDuAn.AutoResize = false;
            this.cbxMaDuAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxMaDuAn.Depth = 0;
            this.cbxMaDuAn.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxMaDuAn.DropDownHeight = 174;
            this.cbxMaDuAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMaDuAn.DropDownWidth = 121;
            this.cbxMaDuAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxMaDuAn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxMaDuAn.FormattingEnabled = true;
            this.cbxMaDuAn.IntegralHeight = false;
            this.cbxMaDuAn.ItemHeight = 43;
            this.cbxMaDuAn.Location = new System.Drawing.Point(799, 27);
            this.cbxMaDuAn.MaxDropDownItems = 4;
            this.cbxMaDuAn.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxMaDuAn.Name = "cbxMaDuAn";
            this.cbxMaDuAn.Size = new System.Drawing.Size(296, 49);
            this.cbxMaDuAn.StartIndex = 0;
            this.cbxMaDuAn.TabIndex = 2;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "chiphivattu_dataset";
            reportDataSource1.Value = this.chiPhiVatTuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyDuAn.ChiPhiVatTu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1203, 522);
            this.reportViewer1.TabIndex = 0;
            // 
            // chiPhiVatTuBindingSource
            // 
            this.chiPhiVatTuBindingSource.DataSource = typeof(QuanLyDuAn.Request.ChiPhiVatTu);
            // 
            // BaoCaoChiTietVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 630);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BaoCaoChiTietVatTu";
            this.Text = "BaoCaoChiTietVatTu";
            this.Load += new System.EventHandler(this.BaoCaoChiTietVatTu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chiPhiVatTuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialButton btnBaoCaoCT;
        private MaterialSkin.Controls.MaterialComboBox cbxMaDuAn;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource chiPhiVatTuBindingSource;
    }
}