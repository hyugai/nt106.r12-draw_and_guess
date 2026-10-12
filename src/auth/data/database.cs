using Microsoft.Data.SqlClient;
using DotNetEnv;

namespace auth.data;

public static class Database
{
    static Database() // initializer
    {
        Env.NoClobber().TraversePath().Load();
    }

    public static SqlConnection ConnectToSqlServer()
    {
        string connection =
            Environment.GetEnvironmentVariable("DRAW_GUESS_DB")
            ?? throw new InvalidOperationException(
                "Missing DRAW_GUESS_DB environment variable."
            );

        return new SqlConnection(connection);
    }

    // test ConnectToSqlServer
    public static async Task<bool> TestSqlConnectionAsync()
    {
        try
        {
            await using var conn = ConnectToSqlServer();

            await conn.OpenAsync();
            await using var sql_cmd = new SqlCommand("SELECT 1", conn);

            var result = await sql_cmd.ExecuteScalarAsync();

            return Convert.ToInt32(result) == 1;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);

            return false;
        }
    }
}
