using System.Data.SqlTypes;

namespace System.Data.SqlClient
{
    public interface ISqlParameter : IDbDataParameter
    {
        SqlCompareOptions CompareInfo { get; set; }
        int LocaleId { get; set; }
        int Offset { get; set; }
        new byte Precision { get; set; }
        new byte Scale { get; set; }
        bool SourceColumnNullMapping { get; set; }
        SqlDbType SqlDbType { get; set; }
        object SqlValue { get; set; }
        string TypeName { get; set; }
        string XmlSchemaCollectionDatabase { get; set; }
        string XmlSchemaCollectionName { get; set; }
        string XmlSchemaCollectionOwningSchema { get; set; }
        void ResetDbType();
        void ResetSqlDbType();
        SqlParameter ToSqlParameter();
        string ToString();
    }
}