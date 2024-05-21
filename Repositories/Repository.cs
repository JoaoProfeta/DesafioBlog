using System.Collections.Generic;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class Repository<T> where T : class
    {
        private readonly SqlConnection _connection;

        public Repository(SqlConnection connection)
            => _connection = connection;

        public IEnumerable<T> Get() => _connection.GetAll<T>();
        public T Get(int id)
           => _connection.Get<T>(id);

        async public void Create(T model)
            => await _connection.InsertAsync<T>(model);

        async public void Update(T model)
            => await _connection.UpdateAsync<T>(model);

        async public void Delete(T model)
                => await _connection.DeleteAsync<T>(model);

        async public void Delete(int id)
        {
            var model = _connection.Get<T>(id);
            await _connection.DeleteAsync<T>(model);
        }
    }
}