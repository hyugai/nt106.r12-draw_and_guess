using auth.data;
using client.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace client
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private readonly string _currentUsername;
        private readonly UserDao _userDao = new();


        public HomeForm(string currentUsername)
        {
            InitializeComponent();
            _currentUsername = currentUsername;
        }

        private async void HomeForm_Load(object sender, EventArgs e)
        {
            try
            {

                User? user = await _userDao.GetByUsernameAsync(_currentUsername);

                if (user is null)
                {
                    MessageBox.Show("Không tìm thấy thông tin tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                lblTenDangNhap.Text = user.TenDangNhap;
                lblEmail.Text = user.Email ?? "Chưa có email";
                lblThoiGianLogin.Text = user.LanDangNhapCuoi.HasValue
                    ? user.LanDangNhapCuoi.Value.ToString("dd/MM/yyyy HH:mm:ss")
                    : "Lần đầu đăng nhập";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thông tin: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
