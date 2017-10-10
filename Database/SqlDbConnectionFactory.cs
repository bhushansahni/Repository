using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Repository.Database.Base;

namespace Repository.Database
{
    public class SqlDbConnectionFactory: DbConnectionFactoryBase
    {
        string _connectionString;
        public override string ConnectionString { get
            {
                return _connectionString;
            } }
        public SqlDbConnectionFactory(string connectionString)
        {
            _connectionString=connectionString;
        }
        public SqlDbConnectionFactory()
        {
        }
        
        public override IDbConnection GetOpenConnection()
        {
            var connection = new SqlConnection(ConnectionString);
            connection.Open();
            return connection;
        }

        public override async Task<IDbConnection> GetOpenConnectionAsync()
        {
            var connection = new SqlConnection(ConnectionString);
            await connection.OpenAsync();
            return connection;
        }
    }
}