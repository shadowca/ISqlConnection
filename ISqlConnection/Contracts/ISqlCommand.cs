using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace System.Data.SqlClient
{
    public interface ISqlCommand : IDbCommand
    {
        new ISqlConnection Connection { get; set; }
        bool DesignTimeVisible { get; set; }
        new ISqlParameterCollection Parameters { get; }
        new ISqlTransaction Transaction { get; set; }
        event StatementCompletedEventHandler StatementCompleted;
        new ISqlParameter CreateParameter();
        new ISqlDataReader ExecuteReader();
        new ISqlDataReader ExecuteReader(CommandBehavior behavior);
        Task<ISqlDataReader> ExecuteReaderAsync();
        Task<ISqlDataReader> ExecuteReaderAsync(CommandBehavior behavior);
        Task<ISqlDataReader> ExecuteReaderAsync(CommandBehavior behavior, CancellationToken cancellationToken);
        Task<ISqlDataReader> ExecuteReaderAsync(CancellationToken cancellationToken);
        Task<object> ExecuteScalarAsync(CancellationToken cancellationToken);
        XmlReader ExecuteXmlReader();
        Task<XmlReader> ExecuteXmlReaderAsync();
        Task<XmlReader> ExecuteXmlReaderAsync(CancellationToken cancellationToken);
        Task<int> ExecuteNonQueryAsync();
        Task<object> ExecuteScalarAsync();
    }
}