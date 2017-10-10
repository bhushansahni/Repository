using System;
using System.Data;
using System.Threading.Tasks;

namespace Repository.Database.Base
{
    public interface IQueryAsync<T>
    {
        Task<T> ExecuteAsync(IDbConnection connection);
    }
}