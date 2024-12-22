using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace QuanLyDuAn
{
    public partial class HomeForm : MaterialForm
    {
        private Timer timer;
        private int targetWidth;
        private int step = 2;
        public HomeForm()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1;
            timer.Tick += Timer_Tick;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.LightBlue200,
                TextShade.WHITE
            );

            panel1.BackColor = System.Drawing.Color.RoyalBlue;
        }
        private void btnNCC_Click(object sender, EventArgs e)
        {

        }

        private void materialCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
            targetWidth = materialCheckbox1.Checked ? 195 : 41;

            if (!timer.Enabled)
            {
                timer.Start();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int difference = Math.Abs(panel1.Width - targetWidth);

            if (difference > 0)
            {
                int dynamicStep = Math.Max(1, difference / 5);

                if (panel1.Width < targetWidth)
                    panel1.Width += dynamicStep;
                else if (panel1.Width > targetWidth)
                    panel1.Width -= dynamicStep;
            }
            else
            {
                timer.Stop();
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            viewPanel.Controls.Clear();
            NhanVienForm nhanVienForm = new NhanVienForm();
            nhanVienForm.Dock = DockStyle.Fill;
            viewPanel.Controls.Add(nhanVienForm);
            viewPanel.Tag = nhanVienForm;
            nhanVienForm.Show();
        }

        private void btnQuy_Click(object sender, EventArgs e)
        {
            viewPanel.Controls.Clear();
            QuyForm quyForm = new QuyForm();
            quyForm.Dock = DockStyle.Fill;
            viewPanel.Controls.Add(quyForm);
        }
    }
}
