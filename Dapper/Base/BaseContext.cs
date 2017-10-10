using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Repository.Base;

namespace Repository.Dapper.Base
{
    public class BaseContext : IDbContext
    {
        public DatabaseFacade Database => throw new NotImplementedException();

        public ChangeTracker ChangeTracker => throw new NotImplementedException();

        public IModel Model => throw new NotImplementedException();

        public IInfrastructure<IServiceProvider> ServiceProvider => throw new NotImplementedException();

        public EntityEntry Add(object entity)
        {
            throw new NotImplementedException();
        }

        public void Add<TEntity>(TEntity entity) where TEntity : EntityBase
        {
            throw new NotImplementedException();
        }

        public void AddAsync(object entity, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        public void AddAsync<TEntity>(TEntity entity, CancellationToken token) where TEntity : EntityBase
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<object> entities)
        {
            throw new NotImplementedException();
        }

        public void AddRange(object[] entities)
        {
            throw new NotImplementedException();
        }

        public void AddRangeAsync(IEnumerable<object> entities, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        public void AddRangeAsync(object[] entities)
        {
            throw new NotImplementedException();
        }

        public void Attach(object entity)
        {
            throw new NotImplementedException();
        }

        public void Attach<TEntity>(TEntity entity) where TEntity : EntityBase
        {
            throw new NotImplementedException();
        }

        public void AttachRange(IEnumerable<object> entities)
        {
            throw new NotImplementedException();
        }

        public void AttachRange(object[] entities)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Entry(object entity)
        {
            throw new NotImplementedException();
        }

        public void Entry<TEntity>(TEntity entity) where TEntity : EntityBase
        {
            throw new NotImplementedException();
        }

        public object Find(Type type, object[] entities)
        {
            throw new NotImplementedException();
        }

        public object Find<TEntity>(object[] entities) where TEntity : EntityBase
        {
            throw new NotImplementedException();
        }

        public object FindAsync(Type type, object[] entities, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> FindAsync<TEntity>(params object[] keyValues) where TEntity : EntityBase
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> FindAsync<TEntity>(object[] keyValues, CancellationToken cancellationToken) where TEntity : EntityBase
        {
            throw new NotImplementedException();
        }

        public EntityEntry Remove(object entity)
        {
            throw new NotImplementedException();
        }

        public EntityEntry<TEntity> Remove<TEntity>(TEntity entity) where TEntity : EntityBase
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<object> entities)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(object[] entities)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public DbSet<TEntity> Set<TEntity>() where TEntity : EntityBase
        {
            throw new NotImplementedException();
        }

        public EntityEntry Update(object entity)
        {
            throw new NotImplementedException();
        }

        public EntityEntry<TEntity> Update<TEntity>(TEntity entity) where TEntity : EntityBase
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(IEnumerable<object> entities)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(params object[] entities)
        {
            throw new NotImplementedException();
        }
    }
}