using server.data;
using DotNetEnv;

Env.NoClobber().TraversePath().Load();

var is_connected = await Database.TestSqlConnectionAsync();

Console.WriteLine(is_connected ? "Connect to SQL server sucessfully!" : "Failed to connect to SQL Server!");
