using System.Collections;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.SqlClient
{
    internal class SqlConnectionImplementation : ISqlConnection
    {
        private readonly SqlConnection _connection;
        internal SqlConnectionImplementation() : this(new SqlConnection()) { }
        internal SqlConnectionImplementation(string connectionString) : this(new SqlConnection(connectionString)) { }

        internal SqlConnectionImplementation(SqlConnection connection) => _connection = connection;

        public Guid ClientConnectionId => _connection.ClientConnectionId;

        public string DataSource => _connection.DataSource;

        public bool FireInfoMessageEventOnUserErrors { get => _connection.FireInfoMessageEventOnUserErrors;
            set => _connection.FireInfoMessageEventOnUserErrors = value;
        }

        public int PacketSize => _connection.PacketSize;

        public string ServerVersion => _connection.ServerVersion;

        public bool StatisticsEnabled
        {
            get => _connection.StatisticsEnabled;
            set => _connection.StatisticsEnabled = value;
        }

        public string WorkstationId => _connection.WorkstationId;

        public string ConnectionString
        {
            get => _connection.ConnectionString;
            set => _connection.ConnectionString = value;
        }

        public int ConnectionTimeout => _connection.ConnectionTimeout;

        public string Database => _connection.Database;

        public ConnectionState State => _connection.State;

        event SqlInfoMessageEventHandler ISqlConnection.InfoMessage
        {
            add => _connection.InfoMessage += value;
            remove => _connection.InfoMessage -= value;
        }

        public event StateChangeEventHandler StateChange
        {
            add => _connection.StateChange += value;
            remove => _connection.StateChange -= value;
        }

        public ISqlTransaction BeginTransaction() => new SqlTransactionImplementation(_connection.BeginTransaction());

        public ISqlTransaction BeginTransaction(IsolationLevel iso) =>
            new SqlTransactionImplementation(_connection.BeginTransaction(iso));
        public ISqlTransaction BeginTransaction(IsolationLevel iso, string transactionName) =>
            new SqlTransactionImplementation(_connection.BeginTransaction(iso, transactionName));
        public ISqlTransaction BeginTransaction(string transactionName) =>
            new SqlTransactionImplementation(_connection.BeginTransaction(transactionName));

        public void ChangeDatabase(string databaseName) => _connection.ChangeDatabase(databaseName);
        public void Close() => _connection.Close();
        public ISqlCommand CreateCommand() => new SqlCommandImplementation(_connection.CreateCommand());
        public void Dispose() => _connection.Dispose();
        public void Open() => _connection.Open();
        public Task OpenAsync(CancellationToken cancellationToken) => _connection.OpenAsync(cancellationToken);
        public Task OpenAsync() => _connection.OpenAsync();
        public void ResetStatistics() => _connection.ResetStatistics();
        public IDictionary RetrieveStatistics() => _connection.RetrieveStatistics();
        IDbTransaction IDbConnection.BeginTransaction() => _connection.BeginTransaction();
        IDbTransaction IDbConnection.BeginTransaction(IsolationLevel il) => _connection.BeginTransaction(il);
        IDbCommand IDbConnection.CreateCommand() => _connection.CreateCommand();
        public SqlConnection ToSqlConnection() => _connection;
    }
}