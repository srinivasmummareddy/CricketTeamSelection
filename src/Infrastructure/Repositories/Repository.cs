using Contracts;
using System;
using System.Data;

namespace Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly IDbConnection _connection;

        public Repository(IDbConnection connection)
        {
            _connection = connection ?? throw new ArgumentNullException(default, nameof(IDbConnection)); ;
        }

        public IDbConnection Open()
        {
            _connection.Open();

            return _connection;
        }
    }
}
