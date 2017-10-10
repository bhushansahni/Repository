using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Repository.Database.Base;

namespace Repository.Database
{
    public class SqlDBFactory : DatabaseFactoryBase
    {
        public override IDatabase Create()
        {
            return new Database(new SqlDbConnectionFactory());
        }

        public override IDatabase CreateWithExternalTransactionScope(System.Transactions.TransactionScope transactionScope)
        {
            return new Database(new SqlDbConnectionFactory(), transactionScope);
        }
    }
}    