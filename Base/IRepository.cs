using System;
using System.Collections.Generic;
using System.Collections;
namespace Repository.Base
{
    public interface IRepository<TEntity, in TKey> where TEntity : EntityBase
    {
        IEnumerable<TEntity> GetAll();
        void Update(TEntity entity);
        TEntity Get(TKey id);
        void Add(TEntity entity);
        void Delete(TEntity entity);
    }
}