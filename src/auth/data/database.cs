
using Microsoft.Data.SqlClient;

namespace auth.data;

public static class Database
{
    public static SqlConnection CreateConnection()
    {
        string connectionString =
            Environment.GetEnvironmentVariable("DRAW_GUESS_DB")
            ?? throw new InvalidOperationException(
                "Missing DRAW_GUESS_DB environment variable."
            );

        return new SqlConnection(connectionString);
    }

    public static async Task<bool> TestConnectionAsync()
    {
        try
        {
            await using var connection = CreateConnection();
            await connection.OpenAsync();

            await using var command =
                new SqlCommand("SELECT 1", connection);

            var result = await command.ExecuteScalarAsync();

            return Convert.ToInt32(result) == 1;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
