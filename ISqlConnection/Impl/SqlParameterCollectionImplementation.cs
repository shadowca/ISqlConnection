using System.Collections;
using System.Linq;

namespace System.Data.SqlClient
{
    internal class SqlParameterCollectionImplementation : ISqlParameterCollection
    {
        private readonly SqlParameterCollection _parameterCollection;
        internal SqlParameterCollectionImplementation(SqlParameterCollection parameterCollection) => _parameterCollection = parameterCollection;
        public ISqlParameter this[int index] { get => new SqlParameterImplementation(_parameterCollection[index]); set => _parameterCollection[index] = value.ToSqlParameter(); }
        public ISqlParameter this[string parameterName] { get => new SqlParameterImplementation(_parameterCollection[parameterName]);
            set => _parameterCollection[parameterName] = value.ToSqlParameter();
        }
        object IDataParameterCollection.this[string parameterName] { get => new SqlParameterImplementation(_parameterCollection[parameterName]); set => _parameterCollection[parameterName] = (SqlParameter)value; }
        object IList.this[int index] { get => new SqlParameterImplementation(_parameterCollection[index]); set => _parameterCollection[index] = (SqlParameter)value; }
        public bool IsFixedSize => ((IList)_parameterCollection).IsFixedSize;
        public bool IsReadOnly => ((IList)_parameterCollection).IsReadOnly;
        public int Count => _parameterCollection.Count;
        public bool IsSynchronized => ((IList) _parameterCollection).IsSynchronized;
        public object SyncRoot => _parameterCollection.SyncRoot;
        public ISqlParameter Add(ISqlParameter value) => new SqlParameterImplementation(_parameterCollection.Add(value.ToSqlParameter()));
        public ISqlParameter Add(string parameterName, SqlDbType sqlDbType) => new SqlParameterImplementation(_parameterCollection.Add(parameterName, sqlDbType));
        public ISqlParameter Add(string parameterName, SqlDbType sqlDbType, int size) => new SqlParameterImplementation(_parameterCollection.Add(parameterName, sqlDbType, size));
        public int Add(object value) => _parameterCollection.Add(value);
        public void AddRange(Array values) => _parameterCollection.AddRange(values);
        public void AddRange(ISqlParameter[] values) => _parameterCollection.AddRange(values.Select(x => x.ToSqlParameter()).ToArray());
        public ISqlParameter AddWithValue(string parameterName, object value) => new SqlParameterImplementation(_parameterCollection.AddWithValue(parameterName, value));
        public void Clear() => _parameterCollection.Clear();
        public bool Contains(ISqlParameter value) => _parameterCollection.Contains(value.ToSqlParameter());
        public bool Contains(string parameterName) => _parameterCollection.Contains(parameterName);
        public bool Contains(object value) => _parameterCollection.Contains(value);
        public void CopyTo(ISqlParameter[] array, int index) => _parameterCollection.CopyTo(array, index);
        public void CopyTo(Array array, int index) => _parameterCollection.CopyTo(array, index);
        public IEnumerator GetEnumerator() => _parameterCollection.GetEnumerator();
        public int IndexOf(ISqlParameter value) => _parameterCollection.IndexOf(value.ToSqlParameter());
        public int IndexOf(string parameterName) => _parameterCollection.IndexOf(parameterName);
        public int IndexOf(object value) => _parameterCollection.IndexOf(value);
        public void Insert(int index, ISqlParameter value) => _parameterCollection.Insert(index, value.ToSqlParameter());
        public void Insert(int index, object value) => _parameterCollection.Insert(index, value);
        public void Remove(ISqlParameter value) => _parameterCollection.Remove(value.ToSqlParameter());
        public void Remove(object value) => _parameterCollection.Remove(value);
        public void RemoveAt(string parameterName) => _parameterCollection.RemoveAt(parameterName);
        public void RemoveAt(int index) => _parameterCollection.RemoveAt(index);
    }
}