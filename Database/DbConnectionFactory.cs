using System;
using System.Data;
using System.Threading.Tasks;
using Repository.Database.Base;

namespace Repository.Database
{
    public abstract class DbConnectionFactoryBase : IConnectionFactory
    {
        public abstract string ConnectionString { get; }

        public abstract IDbConnection GetOpenConnection();

        public abstract  Task<IDbConnection> GetOpenConnectionAsync();
    }

}