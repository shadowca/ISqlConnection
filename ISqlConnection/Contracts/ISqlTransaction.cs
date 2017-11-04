namespace System.Data.SqlClient
{
    public interface ISqlTransaction : IDbTransaction
    {
        new ISqlConnection Connection { get; }
        SqlTransaction ToSqlTransaction();
        void Rollback(string transactionName);
        void Save(string savePointName);
    }
}