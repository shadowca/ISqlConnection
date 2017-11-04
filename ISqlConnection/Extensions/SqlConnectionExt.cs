namespace System.Data.SqlClient
{
    public static class SqlConnectionExt
    {
        public static ISqlConnection ToInterface(this SqlConnection connection) => new SqlConnectionImplementation(connection);
    }
}
