using System;
using System.Data;
using System.Threading.Tasks;

namespace Repository.Database.Base
{
    public interface ICommand<out T>
    {
        /// <summary>
        /// Executes the command over provided connection and returns execution result of the specified type.
        /// Connection will be in open state and disposal is handled automatically.
        /// </summary>
        /// <param name="connection">Open connection.</param>
        T Execute(IDbConnection connection);
    }

    /// <summary>
    /// Represents a Db command, meaning that it's a db query/queries that modifies data in some way.
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Executes the command over provided connection. Connection will be in open state and disposal is handled automatically.
        /// </summary>
        /// <param name="connection">Open connection.</param>
        void Execute(IDbConnection connection);
    }
}