using DotNetEnv;
//using auth.data;
using client.forms;

namespace client;

internal static class Program
{
    [STAThread]
    static async Task Main()
    {
        ApplicationConfiguration.Initialize();

        // Load .env
        Env.NoClobber().TraversePath().Load();

        // Check environment variable
        //string? connectionString =
        //    Environment.GetEnvironmentVariable("DRAW_GUESS_DB");

        //if (string.IsNullOrWhiteSpace(connectionString))
        //{
        //    MessageBox.Show(
        //        "DRAW_GUESS_DB is missing. Check your .env file.",
        //        "Configuration Error"
        //    );

        //    return;
        //}

        // Test SQL Server connection
        //bool connected = await Database.TestConnectionAsync();

        //MessageBox.Show(
        //    connected
        //        ? "Database connection successful!"
        //        : "Database connection failed!",
        //    "Database Test"
        //);

        //if (!connected)
        //    return;

        // Open RegisterForm only when database connection succeeds
        Application.Run(new RegisterForm());
    }
}
