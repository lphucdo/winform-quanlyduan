using QuanLyDuAn.Dao;
using QuanLyDuAn.Entity;
using QuanLyDuAn.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuAn
{
    public partial class LoginForm : Form
    {
        SqlConnection conn = DAO.GetConnection();
        SqlCommand cmd = null;
        SqlDataReader reader = null;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void materialMaskedTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void materialMaskedTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconPictureBox4_MouseHover(object sender, EventArgs e)
        {
            iconPictureBox1.BackColor = Color.LightGray;
            iconPictureBox1.Cursor = Cursors.Hand;
        }

        private void iconPictureBox4_MouseEnter(object sender, EventArgs e)
        {
            iconPictureBox4.BackColor = Color.LightGray;  // Thêm màu nền khi hover
            iconPictureBox4.Cursor = Cursors.Hand;
        }

        private void iconPictureBox4_MouseLeave(object sender, EventArgs e)
        {
            iconPictureBox4.BackColor = Color.Transparent; // Khôi phục màu nền
            iconPictureBox4.Cursor = Cursors.Default;
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Thoát Chương Trình", "Thực Sự Muốn Thoát Chương Trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (username == string.Empty || password == string.Empty) 
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                User user = new User(username, password);
                if (user != null) 
                {
                    string sql = "SELECT * FROM tbl_nguoidung WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhau";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@TaiKhoan", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@MatKhau", txtPassword.Text);

                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        NguoiDung nguoiDung = new NguoiDung
                        {
                            TaiKhoan = reader.GetString(reader.GetOrdinal("TaiKhoan")),
                            MatKhau = reader.GetString(reader.GetOrdinal("MatKhau")),
                            TenNguoiDung = reader.GetString(reader.GetOrdinal("TenNguoiDung")),
                            Quyen = reader.GetString(reader.GetOrdinal("MaQuyen"))
                        };

                        NguoiDung.NguoiDungInstant = nguoiDung;

                        MessageBox.Show("Xin Chào: " + nguoiDung.TenNguoiDung, "Đăng Nhập Thành Công!");

                        MessageBox.Show("USERINSSTANT: " + NguoiDung.NguoiDungInstant.TenNguoiDung);
                    }
                }
                else
                {
                    MessageBox.Show("NULL USER", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Đây là trạng thái quên mật khẩu
            // bỏ qua/ mất thời gian
        }
    }
}
