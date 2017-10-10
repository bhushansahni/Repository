using System;
using System.Collections;
using Repository.Base;

namespace Repository.Core
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly IDbContext _context;
        public UnitOfWork(IDbContext context)
        {
            _context = context;
        }
        public IRepository<TEntity, TKey> Repository<TEntity,TKey>() where TEntity : EntityBase
        {
            var _repository = new Hashtable();

            var type = typeof(TEntity).Name;

            lock (type)
            {
                if (!_repository.ContainsKey(type))
                {
                    var repositoryType = typeof(RepositoryBase<,>);
                    Type[] arr = new Type[2];
                    arr[0]=typeof(TEntity);
                    arr[1]=typeof(TKey);
                    var repositoryInstance =
                        Activator.CreateInstance(repositoryType
                                .MakeGenericType(arr), _context);

                    _repository.Add(type, repositoryInstance);
                }
            }
            return (IRepository<TEntity,TKey>)_repository[type];
        }

    public void Save()
    {
        _context.SaveChanges();
    }
    #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }
                disposedValue = true;
            }
        }

        void IDisposable.Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}