using System.Text.RegularExpressions;
using auth.data;
using Microsoft.Data.SqlClient;

namespace auth.services;

public class AuthService
{
    private readonly UserDao _users = new();

    public async Task<bool> RegisterAsync(
        string username,
        string password,
        string fullName,
        string? email = null)
    {
        username = username?.Trim() ?? "";
        fullName = fullName?.Trim() ?? "";
        email = email?.Trim();

        if (string.IsNullOrWhiteSpace(username) ||
            username.Length < 4 ||
            username.Length > 20 ||
            !Regex.IsMatch(username, @"^[A-Za-z_][A-Za-z0-9_]*\z") ||
            string.IsNullOrEmpty(password) ||
            password.Length < 6 ||
            !password.Any(char.IsUpper) ||
            !password.Any(char.IsDigit) ||
            password.Any(char.IsWhiteSpace) ||
            string.IsNullOrWhiteSpace(fullName) ||
            fullName.Length > 50 ||
            email?.Length > 100)
        {
            return false;
        }

        if (!string.IsNullOrEmpty(email) &&
            !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+\z"))
        {
            return false;
        }

        if (await _users.ExistsByUsernameAsync(username))
            return false;

        var (hash, salt) = await Task.Run(
            () => PasswordHasher.HashPassword(password)
        );

        try
        {
            await _users.CreateAsync(
                username,
                hash,
                salt,
                fullName,
                string.IsNullOrWhiteSpace(email) ? null : email
            );

            return true;
        }
        catch (SqlException ex) when (ex.Number is 2601 or 2627)
        {
            return false;
        }
    }

    public async Task<bool> LoginAsync(
        string username,
        string password)
    {
        if (string.IsNullOrWhiteSpace(username) ||
            string.IsNullOrEmpty(password))
        {
            return false;
        }

        User? user = await _users.GetByUsernameAsync(username.Trim());

        if (user == null)
            return false;

        bool valid = await Task.Run(
            () => PasswordHasher.VerifyPassword(
                password,
                user.MatKhauBam,
                user.Salt
            )
        );

        if (!valid)
            return false;

        await _users.UpdateLastLoginAsync(user.UserId);

        return true;
    }
}
