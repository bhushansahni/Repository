using System;
using System.Data;
using System.Threading.Tasks;

namespace Repository.Database.Base
{
    public interface IConnectionFactory
    {
        IDbConnection GetOpenConnection();
        Task<IDbConnection> GetOpenConnectionAsync();
    }
}