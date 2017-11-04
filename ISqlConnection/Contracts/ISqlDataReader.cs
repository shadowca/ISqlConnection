using System.Collections;
using System.Data.SqlTypes;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace System.Data.SqlClient
{
    public interface ISqlDataReader : IDataReader
    {
        bool HasRows { get; }
        int VisibleFieldCount { get; }
        DateTimeOffset GetDateTimeOffset(int i);
        IEnumerator GetEnumerator();
        T GetFieldValue<T>(int i);
        Task<T> GetFieldValueAsync<T>(int i, CancellationToken cancellationToken);
        Type GetProviderSpecificFieldType(int i);
        object GetProviderSpecificValue(int i);
        int GetProviderSpecificValues(object[] values);
        SqlBinary GetSqlBinary(int i);
        SqlBoolean GetSqlBoolean(int i);
        SqlByte GetSqlByte(int i);
        SqlBytes GetSqlBytes(int i);
        SqlChars GetSqlChars(int i);
        SqlDateTime GetSqlDateTime(int i);
        SqlDecimal GetSqlDecimal(int i);
        SqlDouble GetSqlDouble(int i);
        SqlGuid GetSqlGuid(int i);
        SqlInt16 GetSqlInt16(int i);
        SqlInt32 GetSqlInt32(int i);
        SqlInt64 GetSqlInt64(int i);
        SqlMoney GetSqlMoney(int i);
        SqlSingle GetSqlSingle(int i);
        SqlString GetSqlString(int i);
        object GetSqlValue(int i);
        int GetSqlValues(object[] values);
        SqlXml GetSqlXml(int i);
        Stream GetStream(int i);
        TextReader GetTextReader(int i);
        TimeSpan GetTimeSpan(int i);
        XmlReader GetXmlReader(int i);
        Task<bool> IsDBNullAsync(int i, CancellationToken cancellationToken);
        Task<bool> NextResultAsync(CancellationToken cancellationToken);
        Task<bool> ReadAsync(CancellationToken cancellationToken);
        Task GetFieldValueAsync<T>(int ordinal);
        Task<bool> IsDBNullAsync(int ordinal);
        Task<bool> NextResultAsync();
        Task<bool> ReadAsync();
    }
}