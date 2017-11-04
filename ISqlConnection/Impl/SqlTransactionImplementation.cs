namespace System.Data.SqlClient
{
    internal class SqlTransactionImplementation : ISqlTransaction
    {
        private readonly SqlTransaction _sqlTransaction;

        internal SqlTransactionImplementation(SqlTransaction sqlTransaction) => _sqlTransaction = sqlTransaction;

        public ISqlConnection Connection => new SqlConnectionImplementation(_sqlTransaction.Connection);

        public IsolationLevel IsolationLevel => _sqlTransaction.IsolationLevel;

        IDbConnection IDbTransaction.Connection => _sqlTransaction.Connection;

        public void Commit() => _sqlTransaction.Commit();
        public void Dispose() => _sqlTransaction.Dispose();
        public void Rollback(string transactionName) => _sqlTransaction.Rollback(transactionName);
        public void Rollback() => _sqlTransaction.Rollback();
        public void Save(string savePointName) => _sqlTransaction.Save(savePointName);
        public SqlTransaction ToSqlTransaction() => _sqlTransaction;
    }
}