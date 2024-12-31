namespace QuanLyDuAn
{
    partial class BaoCaoChiTietDuAn
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
            this.chiTietDuAnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBaoCaoCT = new MaterialSkin.Controls.MaterialButton();
            this.cbxMaDuAn = new MaterialSkin.Controls.MaterialComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDuAnBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chiTietDuAnBindingSource
            // 
            this.chiTietDuAnBindingSource.DataSource = typeof(QuanLyDuAn.Request.ChiTietDuAn);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBaoCaoCT);
            this.panel1.Controls.Add(this.cbxMaDuAn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1174, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnBaoCaoCT
            // 
            this.btnBaoCaoCT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBaoCaoCT.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBaoCaoCT.Depth = 0;
            this.btnBaoCaoCT.HighEmphasis = true;
            this.btnBaoCaoCT.Icon = null;
            this.btnBaoCaoCT.Location = new System.Drawing.Point(337, 36);
            this.btnBaoCaoCT.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBaoCaoCT.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBaoCaoCT.Name = "btnBaoCaoCT";
            this.btnBaoCaoCT.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBaoCaoCT.Size = new System.Drawing.Size(83, 36);
            this.btnBaoCaoCT.TabIndex = 1;
            this.btnBaoCaoCT.Text = "Báo Cáo";
            this.btnBaoCaoCT.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBaoCaoCT.UseAccentColor = false;
            this.btnBaoCaoCT.UseVisualStyleBackColor = true;
            this.btnBaoCaoCT.Click += new System.EventHandler(this.btnBaoCaoCT_Click);
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
            this.cbxMaDuAn.Location = new System.Drawing.Point(34, 31);
            this.cbxMaDuAn.MaxDropDownItems = 4;
            this.cbxMaDuAn.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxMaDuAn.Name = "cbxMaDuAn";
            this.cbxMaDuAn.Size = new System.Drawing.Size(296, 49);
            this.cbxMaDuAn.StartIndex = 0;
            this.cbxMaDuAn.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1174, 501);
            this.panel2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.chiTietDuAnBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyDuAn.ChiTietDuAn.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1174, 501);
            this.reportViewer1.TabIndex = 0;
            // 
            // BaoCaoChiTietDuAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 601);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BaoCaoChiTietDuAn";
            this.Text = "BaoCaoChiTietDuAn";
            this.Load += new System.EventHandler(this.BaoCaoChiTietDuAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDuAnBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource chiTietDuAnBindingSource;
        private MaterialSkin.Controls.MaterialButton btnBaoCaoCT;
        private MaterialSkin.Controls.MaterialComboBox cbxMaDuAn;
    }
}