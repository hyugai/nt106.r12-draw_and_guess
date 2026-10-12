using System.Data;
using Microsoft.Data.SqlClient;

namespace auth.data;

public record User(
    int UserId,
    string TenDangNhap,
    string MatKhauBam,
    string Salt,
    string HoTen,
    string? Email,
    DateTime NgayTao,
    DateTime? LanDangNhapCuoi
);

public class UserDao
{
    public async Task<bool> ExistsByUsernameAsync(string username)
    {
        const string sql = """
            SELECT 1
            FROM dbo.Users
            WHERE TenDangNhap = @username
            """;

        await using var connection = Database.CreateConnection();
        await connection.OpenAsync();

        await using var command = new SqlCommand(sql, connection);

        command.Parameters.Add("@username", SqlDbType.NVarChar, 20)
            .Value = username;

        return await command.ExecuteScalarAsync() != null;
    }

    public async Task<User?> GetByUsernameAsync(string username)
    {
        const string sql = """
            SELECT UserId, TenDangNhap, MatKhauBam,
                   Salt, HoTen, Email, NgayTao,
                   LanDangNhapCuoi
            FROM dbo.Users
            WHERE TenDangNhap = @username
            """;

        await using var connection = Database.CreateConnection();
        await connection.OpenAsync();

        await using var command = new SqlCommand(sql, connection);

        command.Parameters.Add("@username", SqlDbType.NVarChar, 20)
            .Value = username;

        await using var reader = await command.ExecuteReaderAsync();

        if (!await reader.ReadAsync())
            return null;

        return ReadUser(reader);
    }

    public async Task<User?> GetByIdAsync(int userId)
    {
        const string sql = """
            SELECT UserId, TenDangNhap, MatKhauBam,
                   Salt, HoTen, Email, NgayTao,
                   LanDangNhapCuoi
            FROM dbo.Users
            WHERE UserId = @userId
            """;

        await using var connection = Database.CreateConnection();
        await connection.OpenAsync();

        await using var command = new SqlCommand(sql, connection);

        command.Parameters.Add("@userId", SqlDbType.Int)
            .Value = userId;

        await using var reader = await command.ExecuteReaderAsync();

        if (!await reader.ReadAsync())
            return null;

        return ReadUser(reader);
    }

    public async Task<int> CreateAsync(
        string username,
        string passwordHash,
        string salt,
        string fullName,
        string? email = null)
    {
        const string sql = """
            INSERT INTO dbo.Users
                (TenDangNhap, MatKhauBam, Salt, HoTen, Email)
            OUTPUT INSERTED.UserId
            VALUES
                (@username, @hash, @salt, @fullName, @email)
            """;

        await using var connection = Database.CreateConnection();
        await connection.OpenAsync();

        await using var command = new SqlCommand(sql, connection);

        command.Parameters.Add("@username", SqlDbType.NVarChar, 20)
            .Value = username;

        command.Parameters.Add("@hash", SqlDbType.NVarChar, 64)
            .Value = passwordHash;

        command.Parameters.Add("@salt", SqlDbType.NVarChar, 32)
            .Value = salt;

        command.Parameters.Add("@fullName", SqlDbType.NVarChar, 50)
            .Value = fullName;

        command.Parameters.Add("@email", SqlDbType.NVarChar, 100)
            .Value = (object?)email ?? DBNull.Value;

        var result = await command.ExecuteScalarAsync();

        return Convert.ToInt32(result);
    }

    public async Task UpdateLastLoginAsync(int userId)
    {
        const string sql = """
            UPDATE dbo.Users
            SET LanDangNhapCuoi = SYSDATETIME()
            WHERE UserId = @userId
            """;

        await using var connection = Database.CreateConnection();
        await connection.OpenAsync();

        await using var command = new SqlCommand(sql, connection);

        command.Parameters.Add("@userId", SqlDbType.Int)
            .Value = userId;

        await command.ExecuteNonQueryAsync();
    }

    private static User ReadUser(SqlDataReader reader)
    {
        return new User(
            reader.GetInt32(0),
            reader.GetString(1),
            reader.GetString(2),
            reader.GetString(3),
            reader.GetString(4),
            reader.IsDBNull(5) ? null : reader.GetString(5),
            reader.GetDateTime(6),
            reader.IsDBNull(7) ? null : reader.GetDateTime(7)
        );
    }
}

