using Repository.Base;
using System.Collections.Generic;

namespace Repository.Core
{
    public class RepositoryBase<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity :EntityBase
    {
        IDbContext _context;
        public RepositoryBase(IDbContext context)
        {
            _context=context;
        }
        public IEnumerable<TEntity> GetAll()
        {
            return _context.Find(typeof(TEntity),null) as IEnumerable<TEntity>;
        }
        public void Update(TEntity entity)
        {
            _context.Update(entity);
        }
        public TEntity Get(TKey id)
        {
            return _context.Find(typeof(TEntity) ,null) as TEntity;
        }
        public void Add(TEntity entity)
        {
            _context.Add(entity);
        }
        public void Delete(TEntity entity)
        {
            _context.Remove(entity);
        }

    }
}