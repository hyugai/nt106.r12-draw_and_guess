using System.Text.RegularExpressions;
using auth.services;
using Microsoft.Data.SqlClient;

namespace client.forms;

public partial class RegisterForm : Form
{
    private readonly AuthService _auth = new();

    private const int MIN_USERNAME = 4;
    private const int MAX_USERNAME = 20;
    private const int MIN_PASSWORD = 6;

    private static readonly Regex UsernameRegex =
        new(@"^[A-Za-z_][A-Za-z0-9_]*\z");

    private static readonly Regex EmailRegex =
        new(@"^[^@\s]+@[^@\s]+\.[^@\s]+\z");

    public RegisterForm()
    {
        InitializeComponent();
    }

    private void ClearErrors()
    {
        lblLoiTenDangNhap.Text = "";
        lblLoiHoTen.Text = "";
        lblLoiEmailSdt.Text = "";
        lblLoiMatKhau.Text = "";
        lblLoiXacNhan.Text = "";
    }

    private bool ValidateInput()
    {
        bool isValid = true;
        Control? firstInvalidControl = null;

        void ShowError(Label label, Control control, string message)
        {
            label.Text = message;
            isValid = false;
            firstInvalidControl ??= control;
        }

        // Username
        string username = txtTenDangNhap.Text.Trim();

        if (username.Length == 0)
            ShowError(lblLoiTenDangNhap, txtTenDangNhap,
                "Vui lòng nhập tài khoản");
        else if (username.Length < MIN_USERNAME)
            ShowError(lblLoiTenDangNhap, txtTenDangNhap,
                "Tài khoản phải có ít nhất 4 ký tự");
        else if (username.Length > MAX_USERNAME)
            ShowError(lblLoiTenDangNhap, txtTenDangNhap,
                "Tài khoản không được vượt quá 20 ký tự");
        else if (!UsernameRegex.IsMatch(username))
            ShowError(lblLoiTenDangNhap, txtTenDangNhap,
                "Tài khoản chỉ được chứa chữ, số, dấu gạch dưới và không bắt đầu bằng số");

        // Full name
        string fullName = txtHoTen.Text.Trim();

        if (string.IsNullOrWhiteSpace(fullName))
            ShowError(lblLoiHoTen, txtHoTen,
                "Vui lòng nhập họ tên");
        else if (fullName.Length > 50)
            ShowError(lblLoiHoTen, txtHoTen,
                "Họ tên không được vượt quá 50 ký tự");

        // Email (optional)
        string email = txtEmailSdt.Text.Trim();

        if (email.Length > 100)
            ShowError(lblLoiEmailSdt, txtEmailSdt,
                "Email không được vượt quá 100 ký tự");
        else if (email.Length > 0 && !EmailRegex.IsMatch(email))
            ShowError(lblLoiEmailSdt, txtEmailSdt,
                "Email không hợp lệ");

        // Password
        string password = txtMatKhau.Text;

        if (password.Length == 0)
            ShowError(lblLoiMatKhau, txtMatKhau,
                "Vui lòng nhập mật khẩu");
        else if (password.Length < MIN_PASSWORD)
            ShowError(lblLoiMatKhau, txtMatKhau,
                "Mật khẩu phải có ít nhất 6 ký tự");
        else if (!password.Any(char.IsUpper))
            ShowError(lblLoiMatKhau, txtMatKhau,
                "Mật khẩu cần ít nhất 1 chữ in hoa");
        else if (!password.Any(char.IsDigit))
            ShowError(lblLoiMatKhau, txtMatKhau,
                "Mật khẩu cần ít nhất 1 chữ số");
        else if (password.Any(char.IsWhiteSpace))
            ShowError(lblLoiMatKhau, txtMatKhau,
                "Mật khẩu không được chứa khoảng trắng");

        // Confirm password
        string confirmation = txtXacNhanMatKhau.Text;

        if (confirmation.Length == 0)
            ShowError(lblLoiXacNhan, txtXacNhanMatKhau,
                "Vui lòng nhập lại mật khẩu");
        else if (confirmation != password)
            ShowError(lblLoiXacNhan, txtXacNhanMatKhau,
                "Mật khẩu xác nhận không khớp");

        firstInvalidControl?.Focus();

        return isValid;
    }

    private async void register_button_Click(object? sender, EventArgs e)
    {
        ClearErrors();

        if (!ValidateInput())
            return;

        string originalText = btnDangKy.Text;

        btnDangKy.Enabled = false;
        btnDangKy.Text = "Đang xử lý...";

        try
        {
            bool success = await _auth.RegisterAsync(
                txtTenDangNhap.Text.Trim(),
                txtMatKhau.Text,
                txtHoTen.Text.Trim(),
                string.IsNullOrWhiteSpace(txtEmailSdt.Text)
                    ? null
                    : txtEmailSdt.Text.Trim()
            );

            if (success)
            {
                MessageBox.Show(
                    "Đăng ký thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                ClearInputs();
            }
            else
            {
                lblLoiTenDangNhap.Text =
                    "Đăng ký thất bại. Tài khoản có thể đã tồn tại.";

                txtTenDangNhap.Focus();
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
            btnDangKy.Enabled = true;
            btnDangKy.Text = originalText;
        }
    }

    private void ClearInputs()
    {
        ClearErrors();

        txtTenDangNhap.Clear();
        txtHoTen.Clear();
        txtEmailSdt.Clear();
        txtMatKhau.Clear();
        txtXacNhanMatKhau.Clear();

        txtTenDangNhap.Focus();
    }

    private void cancel_button_Click(object? sender, EventArgs e)
    {
        ClearInputs();
    }

    private void login_button_Click(object? sender, EventArgs e)
    {
        MessageBox.Show(
            "Chức năng đăng nhập đang được phát triển.",
            "Thông báo",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
    }
}

