namespace System.Data.SqlClient
{
    public interface ISqlParameterCollection : IDataParameterCollection
    {
        new ISqlParameter this[int index] { get; set; }
        new ISqlParameter this[string parameterName] { get; set; }
        ISqlParameter Add(ISqlParameter value);
        ISqlParameter Add(string parameterName, SqlDbType sqlDbType);
        ISqlParameter Add(string parameterName, SqlDbType sqlDbType, int size);
        void AddRange(Array values);
        void AddRange(ISqlParameter[] values);
        ISqlParameter AddWithValue(string parameterName, object value);
        bool Contains(ISqlParameter value);
        void CopyTo(ISqlParameter[] array, int index);
        int IndexOf(ISqlParameter value);
        void Insert(int index, ISqlParameter value);
        void Remove(ISqlParameter value);
    }
}