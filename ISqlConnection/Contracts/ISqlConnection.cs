using System.Collections;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.SqlClient
{
    public interface ISqlConnection : IDbConnection
    {
        Guid ClientConnectionId { get; }
        SqlConnection ToSqlConnection();
        string DataSource { get; }
        bool FireInfoMessageEventOnUserErrors { get; set; }
        int PacketSize { get; }
        string ServerVersion { get; }
        bool StatisticsEnabled { get; set; }
        string WorkstationId { get; }
        event SqlInfoMessageEventHandler InfoMessage;
        new ISqlTransaction BeginTransaction();
        new ISqlTransaction BeginTransaction(IsolationLevel iso);
        ISqlTransaction BeginTransaction(IsolationLevel iso, string transactionName);
        ISqlTransaction BeginTransaction(string transactionName);
        new ISqlCommand CreateCommand();
        Task OpenAsync(CancellationToken cancellationToken);
        void ResetStatistics();
        IDictionary RetrieveStatistics();
        Task OpenAsync();
        event StateChangeEventHandler StateChange;
    }
}