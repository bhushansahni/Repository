using System;
using System.Data;
using System.Threading.Tasks;

namespace Repository.Database.Base
{
    public interface IQuery<out T>
    {
        /// <summary>
        /// Executes the query over provided connection. Connection will be in open state and disposal is handled automatically.
        /// </summary>
        /// <param name="connection">Open connection.</param>
        T Execute(IDbConnection connection);
    }    
}
