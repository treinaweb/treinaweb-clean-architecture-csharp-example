using System.Data;
using MySql.Data.MySqlClient;

namespace CleanArch.Infra.Db;

public static class MySQL
{
    public static IDbConnection GetDbConnection()
    {
        return new MySqlConnection("server=localhost;userid=root;pwd=root;port=3306;database=clean_arch;SslMode=None");
    }
}