using System.Collections;
using System.Data.SqlTypes;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace System.Data.SqlClient
{
    public class SqlDataReaderImplementation : ISqlDataReader
    {
        private readonly SqlDataReader _reader;

        internal SqlDataReaderImplementation(SqlDataReader reader) => _reader = reader;

        public object this[int i] => _reader[i];

        public object this[string name] => _reader[name];

        public bool HasRows => _reader.HasRows;

        public int VisibleFieldCount => _reader.VisibleFieldCount;

        public int Depth => _reader.Depth;

        public bool IsClosed => _reader.IsClosed;

        public int RecordsAffected => _reader.RecordsAffected;

        public int FieldCount => _reader.FieldCount;

        public void Close() => ((IDataReader) _reader).Close();
        public void Dispose() => _reader.Dispose();
        public bool GetBoolean(int i) => _reader.GetBoolean(i);
        public byte GetByte(int i) => _reader.GetByte(i);

        public long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length) =>
            _reader.GetBytes(i, fieldOffset, buffer, bufferoffset, length);

        public char GetChar(int i) => _reader.GetChar(i);

        public long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length) =>
            _reader.GetChars(i, fieldoffset, buffer, bufferoffset, length);

        public IDataReader GetData(int i) => _reader.GetData(i);
        public string GetDataTypeName(int i) => _reader.GetDataTypeName(i);
        public DateTime GetDateTime(int i) => _reader.GetDateTime(i);
        public DateTimeOffset GetDateTimeOffset(int i) => _reader.GetDateTimeOffset(i);
        public decimal GetDecimal(int i) => _reader.GetDecimal(i);
        public double GetDouble(int i) => _reader.GetDouble(i);
        public IEnumerator GetEnumerator() => _reader.GetEnumerator();
        public Type GetFieldType(int i) => _reader.GetFieldType(i);
        public T GetFieldValue<T>(int i) => _reader.GetFieldValue<T>(i);

        public Task<T> GetFieldValueAsync<T>(int i, CancellationToken cancellationToken) =>
            _reader.GetFieldValueAsync<T>(i, cancellationToken);

        public Task GetFieldValueAsync<T>(int ordinal) => _reader.GetFieldValueAsync<T>(ordinal);
        public float GetFloat(int i) => _reader.GetFloat(i);
        public Guid GetGuid(int i) => _reader.GetGuid(i);
        public short GetInt16(int i) => _reader.GetInt16(i);
        public int GetInt32(int i) => _reader.GetInt32(i);
        public long GetInt64(int i) => _reader.GetInt64(i);
        public string GetName(int i) => _reader.GetName(i);
        public int GetOrdinal(string name) => _reader.GetOrdinal(name);
        public Type GetProviderSpecificFieldType(int i) => _reader.GetProviderSpecificFieldType(i);
        public object GetProviderSpecificValue(int i) => _reader.GetProviderSpecificValue(i);
        public int GetProviderSpecificValues(object[] values) => _reader.GetProviderSpecificValues(values);
        public DataTable GetSchemaTable() => ((IDataReader) _reader).GetSchemaTable();
        public SqlBinary GetSqlBinary(int i) => _reader.GetSqlBinary(i);
        public SqlBoolean GetSqlBoolean(int i) => _reader.GetSqlBoolean(i);
        public SqlByte GetSqlByte(int i) => _reader.GetSqlByte(i);
        public SqlBytes GetSqlBytes(int i) => _reader.GetSqlBytes(i);
        public SqlChars GetSqlChars(int i) => _reader.GetSqlChars(i);
        public SqlDateTime GetSqlDateTime(int i) => _reader.GetSqlDateTime(i);
        public SqlDecimal GetSqlDecimal(int i) => _reader.GetSqlDecimal(i);
        public SqlDouble GetSqlDouble(int i) => _reader.GetSqlDouble(i);
        public SqlGuid GetSqlGuid(int i) => _reader.GetSqlGuid(i);
        public SqlInt16 GetSqlInt16(int i) => _reader.GetSqlInt16(i);
        public SqlInt32 GetSqlInt32(int i) => _reader.GetSqlInt32(i);
        public SqlInt64 GetSqlInt64(int i) => _reader.GetSqlInt64(i);
        public SqlMoney GetSqlMoney(int i) => _reader.GetSqlMoney(i);
        public SqlSingle GetSqlSingle(int i) => _reader.GetSqlSingle(i);
        public SqlString GetSqlString(int i) => _reader.GetSqlString(i);
        public object GetSqlValue(int i) => _reader.GetSqlValue(i);
        public int GetSqlValues(object[] values) => _reader.GetSqlValues(values);
        public SqlXml GetSqlXml(int i) => _reader.GetSqlXml(i);
        public Stream GetStream(int i) => _reader.GetStream(i);
        public string GetString(int i) => _reader.GetString(i);
        public TextReader GetTextReader(int i) => _reader.GetTextReader(i);
        public TimeSpan GetTimeSpan(int i) => _reader.GetTimeSpan(i);
        public object GetValue(int i) => _reader.GetValue(i);
        public int GetValues(object[] values) => _reader.GetValues(values);
        public XmlReader GetXmlReader(int i) => _reader.GetXmlReader(i);
        public bool IsDBNull(int i) => _reader.IsDBNull(i);

        public Task<bool> IsDBNullAsync(int i, CancellationToken cancellationToken) =>
            _reader.IsDBNullAsync(i, cancellationToken);

        public Task<bool> IsDBNullAsync(int ordinal) => _reader.IsDBNullAsync(ordinal);
        public bool NextResult() => _reader.NextResult();

        public Task<bool> NextResultAsync(CancellationToken cancellationToken) =>
            _reader.NextResultAsync(cancellationToken);

        public Task<bool> NextResultAsync() => _reader.NextResultAsync();
        public bool Read() => _reader.Read();
        public Task<bool> ReadAsync(CancellationToken cancellationToken) => _reader.ReadAsync(cancellationToken);
        public Task<bool> ReadAsync() => _reader.ReadAsync();
    }
}