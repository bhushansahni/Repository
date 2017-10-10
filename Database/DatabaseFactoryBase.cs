using Repository.Database.Base;

namespace Repository.Database
{
    public abstract class DatabaseFactoryBase
    {
        public abstract IDatabase Create();
        public abstract IDatabase CreateWithExternalTransactionScope(System.Transactions.TransactionScope transactionScope);
    }    
}