using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using auth.services;
using Microsoft.Data.SqlClient;
namespace client.forms;

public partial class LoginForm : Form
{
    private readonly AuthService _auth = new();
    public LoginForm()
    {
        InitializeComponent();
    }
    private const int VONG_LAP = 600_000;

    public static bool KiemTra(string matKhau, string saltLuu, string bamLuu)
    {
        byte[] salt = Convert.FromBase64String(saltLuu);
        byte[] bamCu = Convert.FromBase64String(bamLuu);
        byte[] bamMoi = Rfc2898DeriveBytes.Pbkdf2(
            matKhau, salt, VONG_LAP, HashAlgorithmName.SHA256, 32);
        return CryptographicOperations.FixedTimeEquals(bamCu, bamMoi);
    }
    private void LoginForm_Load(object sender, EventArgs e)
    {
        txtDangNhap.Focus();
    }


    private async void btnDangNhap_Click(object sender, EventArgs e)
    {
        label4.Text = "";
        label5.Text = "";
        label6.Text = "";

        string tenDangNhap = txtDangNhap.Text.Trim();
        string matKhau = txtMatKhau.Text;
        bool Empty = false;
        if (string.IsNullOrEmpty(tenDangNhap))
        {
            label5.Text = "Chưa nhập tên đăng nhập";
            Empty = true;
        }
        if (string.IsNullOrEmpty(matKhau))
        {
            label6.Text = "Chưa nhập mật khẩu";
            Empty = true;
        }
        if (Empty) return;
        string originalText = btnDangNhap.Text;
        btnDangNhap.Enabled = false;
        btnDangNhap.Text = "Đang xử lý...";

        try
        {
            bool success = await _auth.LoginAsync(tenDangNhap, matKhau);
            if (success)
            {
                MessageBox.Show(
                    "Đăng nhập thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                txtDangNhap.Clear();
                txtMatKhau.Clear();
            }
            else
            {
                label4.Text = "Tên đăng nhập hoặc mật khẩu không chính xác.";
                txtMatKhau.Clear();
                txtMatKhau.Focus();
            }
        }
        catch (SqlException)
        {
            MessageBox.Show(
                "Không thể truy cập cơ sở dữ liệu. Vui lòng thử lại.",
                "Lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
        catch (Exception)
        {
            MessageBox.Show(
                "Hệ thống đang gặp sự cố. Vui lòng thử lại sau.",
                "Lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
        finally
        {
            btnDangNhap.Enabled = true;
            btnDangNhap.Text = originalText;
        }
    }

    private void btnDangKy_Click(object sender, EventArgs e)
    {
        this.Hide();
        using (RegisterForm dangky = new RegisterForm())
        {
            dangky.ShowDialog();
        }
        this.Show();
        txtMatKhau.Clear();
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        MessageBox.Show(
            "Chức năng ghi nhớ mật khẩu đang được phát triển.",
            "Thông báo",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
    }

    private void btnQuenMatKhau_Click(object sender, EventArgs e)
    {
        MessageBox.Show(
            "Chức năng quên mật khẩu đang được phát triển.",
            "Thông báo",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
    }

    private void label4_Click(object sender, EventArgs e)
    {

    }
}
