using System.Text.RegularExpressions;

namespace auth.validation;

public static class UserValidator
{
    public static string? ValidateUsername(string username)
    {
        username = username?.Trim() ?? "";

        if (username.Length == 0)
            return "Vui lòng nhập tài khoản";

        if (username.Length < 4 || username.Length > 20)
            return "Tài khoản phải có từ 4 đến 20 ký tự";

        if (!Regex.IsMatch(username, @"^[A-Za-z_][A-Za-z0-9_]*\z"))
            return "Tài khoản không đúng định dạng";

        return null;
    }

    public static string? ValidatePassword(string password)
    {
        if (string.IsNullOrEmpty(password))
            return "Vui lòng nhập mật khẩu";

        if (password.Length < 6)
            return "Mật khẩu phải có ít nhất 6 ký tự";

        if (!password.Any(char.IsUpper) || !password.Any(char.IsDigit))
            return "Mật khẩu cần chữ in hoa và chữ số";

        if (password.Any(char.IsWhiteSpace))
            return "Mật khẩu không được chứa khoảng trắng";

        return null;
    }

    public static string? ValidateLogin(
        string username,
        string password)
    {
        if (string.IsNullOrWhiteSpace(username))
            return "Vui lòng nhập tài khoản";

        if (string.IsNullOrEmpty(password))
            return "Vui lòng nhập mật khẩu";

        return null;
    }

    public static string? ValidateEmail(string? email)
    {
        if (string.IsNullOrWhiteSpace(email))
            return null; // Email is optional

        if (email.Length > 100 ||
            !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+\z"))
            return "Email không hợp lệ";

        return null;
    }
}
