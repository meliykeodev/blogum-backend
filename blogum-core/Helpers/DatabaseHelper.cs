using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace blogum_core.Helpers
{
    public class DatabaseHelper
    {
        private static string ConnectionString = "Server=localhost,1433; Database=blogum_db; User Id=SA; Password=!blogum2021";

        public static IDbConnection Connection => new SqlConnection(ConnectionString);
    }
}
