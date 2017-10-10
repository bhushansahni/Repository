using System;

namespace Repository.Base
{
    public interface IUnitOfWork:IDisposable
    {
        void Save();
        IRepository<TEntity, TKey> Repository<TEntity,TKey>() where TEntity : EntityBase;
    }
}