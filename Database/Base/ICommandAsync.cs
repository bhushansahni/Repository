using System;
using System.Data;
using System.Threading.Tasks;

namespace Repository.Database.Base
{
    public interface ICommandAsync<T>
    {
        Task<T> ExecuteAsync(IDbConnection connection);
    }

    public interface ICommandAsync
    {
        Task ExecuteAsync(IDbConnection connection);
    }
}