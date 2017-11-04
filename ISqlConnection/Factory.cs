namespace System.Data.SqlClient
{

    public static class Factory
    {
        public static ISqlConnection Create() => new SqlConnectionImplementation();

        public static ISqlConnection Create(string connectionString) => new SqlConnectionImplementation(connectionString);

        public static ISqlConnection Create(SqlConnection connection) => new SqlConnectionImplementation(connection);
    }
}