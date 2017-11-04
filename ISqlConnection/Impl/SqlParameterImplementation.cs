using System.Data.SqlTypes;

namespace System.Data.SqlClient
{
    internal class SqlParameterImplementation : ISqlParameter
    {
        private readonly SqlParameter _sqlParameter;

        internal SqlParameterImplementation(SqlParameter sqlParameter) => _sqlParameter = sqlParameter;

        public SqlCompareOptions CompareInfo { get => _sqlParameter.CompareInfo; set => _sqlParameter.CompareInfo = value; }
        public int LocaleId
        {
            get => _sqlParameter.LocaleId;
            set => _sqlParameter.LocaleId = value;
        }
        public int Offset
        {
            get => _sqlParameter.Offset;
            set => _sqlParameter.Offset = value;
        }
        public byte Precision
        {
            get => _sqlParameter.Precision;
            set => _sqlParameter.Precision = value;
        }
        public byte Scale
        {
            get => _sqlParameter.Scale;
            set => _sqlParameter.Scale = value;
        }
        public bool SourceColumnNullMapping
        {
            get => _sqlParameter.SourceColumnNullMapping;
            set => _sqlParameter.SourceColumnNullMapping = value;
        }
        public SqlDbType SqlDbType
        {
            get => _sqlParameter.SqlDbType;
            set => _sqlParameter.SqlDbType = value;
        }
        public object SqlValue
        {
            get => _sqlParameter.SqlValue;
            set => _sqlParameter.SqlValue = value;
        }
        public string TypeName
        {
            get => _sqlParameter.TypeName;
            set => _sqlParameter.TypeName = value;
        }
        public string XmlSchemaCollectionDatabase
        {
            get => _sqlParameter.XmlSchemaCollectionDatabase;
            set => _sqlParameter.XmlSchemaCollectionDatabase = value;
        }
        public string XmlSchemaCollectionName
        {
            get => _sqlParameter.XmlSchemaCollectionName;
            set => _sqlParameter.XmlSchemaCollectionName = value;
        }
        public string XmlSchemaCollectionOwningSchema
        {
            get => _sqlParameter.XmlSchemaCollectionOwningSchema;
            set => _sqlParameter.XmlSchemaCollectionOwningSchema = value;
        }
        public int Size
        {
            get => _sqlParameter.Size;
            set => _sqlParameter.Size = value;
        }
        public DbType DbType
        {
            get => _sqlParameter.DbType;
            set => _sqlParameter.DbType = value;
        }
        public ParameterDirection Direction
        {
            get => _sqlParameter.Direction;
            set => _sqlParameter.Direction = value;
        }

        public bool IsNullable => _sqlParameter.IsNullable;

        public string ParameterName
        {
            get => _sqlParameter.ParameterName;
            set => _sqlParameter.ParameterName = value;
        }
        public string SourceColumn
        {
            get => _sqlParameter.SourceColumn;
            set => _sqlParameter.SourceColumn = value;
        }
        public DataRowVersion SourceVersion { get => ((IDataParameter)_sqlParameter).SourceVersion;
            set => ((IDataParameter) _sqlParameter).SourceVersion = value;
        }
        public object Value
        {
            get => _sqlParameter.Value;
            set => _sqlParameter.Value = value;
        }

        public void ResetDbType() => _sqlParameter.ResetDbType();
        public void ResetSqlDbType() => _sqlParameter.ResetSqlDbType();
        public SqlParameter ToSqlParameter() => _sqlParameter;
    }
}