using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace System.Data.SqlClient
{
    internal class SqlCommandImplementation : ISqlCommand
    {
        private readonly SqlCommand _sqlCommand;

        internal SqlCommandImplementation(SqlCommand sqlCommand) => _sqlCommand = sqlCommand;

        public ISqlConnection Connection { get => new SqlConnectionImplementation(_sqlCommand.Connection); set => _sqlCommand.Connection = value.ToSqlConnection(); }
        public bool DesignTimeVisible { get => _sqlCommand.DesignTimeVisible; set => _sqlCommand.DesignTimeVisible=value; }

        public ISqlParameterCollection Parameters => new SqlParameterCollectionImplementation(_sqlCommand.Parameters);

        public ISqlTransaction Transaction { get => new SqlTransactionImplementation(_sqlCommand.Transaction); set => _sqlCommand.Transaction = value.ToSqlTransaction(); }
        public string CommandText
        {
            get => _sqlCommand.CommandText;
            set => _sqlCommand.CommandText = value;
        }
        public int CommandTimeout { get => _sqlCommand.CommandTimeout;
            set => _sqlCommand.CommandTimeout = value;}
        public CommandType CommandType { get => _sqlCommand.CommandType;
            set => _sqlCommand.CommandType = value;
        }
        public UpdateRowSource UpdatedRowSource { get => _sqlCommand.UpdatedRowSource;
            set => _sqlCommand.UpdatedRowSource = value;
        }
        IDbConnection IDbCommand.Connection { get => _sqlCommand.Connection;
            set => _sqlCommand.Connection = (SqlConnection)value;
        }

        IDataParameterCollection IDbCommand.Parameters => _sqlCommand.Parameters;

        IDbTransaction IDbCommand.Transaction { get =>_sqlCommand.Transaction;
            set => _sqlCommand.Transaction = (SqlTransaction)value;
        }

        public event StatementCompletedEventHandler StatementCompleted
        {
            add => _sqlCommand.StatementCompleted += value;
            remove => _sqlCommand.StatementCompleted -= value;
        }

        public void Cancel() => _sqlCommand.Cancel();
        public ISqlParameter CreateParameter() => new SqlParameterImplementation(_sqlCommand.CreateParameter());
        public void Dispose() => _sqlCommand.Dispose();
        public int ExecuteNonQuery() => _sqlCommand.ExecuteNonQuery();
        public Task<int> ExecuteNonQueryAsync() => _sqlCommand.ExecuteNonQueryAsync();
        public ISqlDataReader ExecuteReader() => new SqlDataReaderImplementation(_sqlCommand.ExecuteReader());
        public ISqlDataReader ExecuteReader(CommandBehavior behavior) => new SqlDataReaderImplementation(_sqlCommand.ExecuteReader(behavior));

        public Task<ISqlDataReader> ExecuteReaderAsync() => throw new NotImplementedException(); //TODO: missing implementation
        public Task<ISqlDataReader> ExecuteReaderAsync(CommandBehavior behavior) => throw new NotImplementedException();//TODO: missing implementation
        public Task<ISqlDataReader> ExecuteReaderAsync(CommandBehavior behavior, CancellationToken cancellationToken) => throw new NotImplementedException();//TODO: missing implementation
        public Task<ISqlDataReader> ExecuteReaderAsync(CancellationToken cancellationToken) => throw new NotImplementedException();//TODO: missing implementation
        public object ExecuteScalar() => _sqlCommand.ExecuteScalar();

        public Task<object> ExecuteScalarAsync(CancellationToken cancellationToken) =>
            _sqlCommand.ExecuteScalarAsync(cancellationToken);

        public Task<object> ExecuteScalarAsync() => _sqlCommand.ExecuteScalarAsync();
        public XmlReader ExecuteXmlReader() => _sqlCommand.ExecuteXmlReader();
        public Task<XmlReader> ExecuteXmlReaderAsync() => _sqlCommand.ExecuteXmlReaderAsync();

        public Task<XmlReader> ExecuteXmlReaderAsync(CancellationToken cancellationToken) =>
            _sqlCommand.ExecuteXmlReaderAsync(cancellationToken);

        public void Prepare() => _sqlCommand.Prepare();
        IDbDataParameter IDbCommand.CreateParameter() => _sqlCommand.CreateParameter();
        IDataReader IDbCommand.ExecuteReader() => _sqlCommand.ExecuteReader();
        IDataReader IDbCommand.ExecuteReader(CommandBehavior behavior) => _sqlCommand.ExecuteReader(behavior);
    }
}