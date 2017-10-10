using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Repository.Base;

namespace Repository.Base
{
    public interface IDbContext
    {
        DatabaseFacade Database { get; }
        ChangeTracker ChangeTracker { get; }
        IModel Model {get;}
        EntityEntry Add(object entity);
        void Add<TEntity>(TEntity entity) where TEntity : EntityBase;
        void AddAsync(Object entity, CancellationToken token);
        void AddAsync<TEntity>(TEntity entity, CancellationToken token) where TEntity : EntityBase;
        void AddRange(IEnumerable<Object> entities);
        void AddRange(Object[] entities);
        void AddRangeAsync(IEnumerable<Object> entities, CancellationToken token);
        void AddRangeAsync(Object[] entities);
        void Attach(Object entity);
        void Attach<TEntity>(TEntity entity) where TEntity : EntityBase;
        void AttachRange(IEnumerable<Object> entities);
        void AttachRange(Object[] entities);
        void Dispose();
        void Entry(Object entity);
        void Entry<TEntity>(TEntity entity) where TEntity : EntityBase;
        object Find(Type type, Object[] entities);
        object Find<TEntity>(Object[] entities) where TEntity : EntityBase;
        object FindAsync(Type type, Object[] entities, CancellationToken token);
        Task<TEntity> FindAsync<TEntity>(params object[] keyValues) where TEntity : EntityBase;
        Task<TEntity> FindAsync<TEntity>(object[] keyValues, CancellationToken cancellationToken) where TEntity : EntityBase;
        EntityEntry Remove(object entity);
        EntityEntry<TEntity> Remove<TEntity>(TEntity entity) where TEntity : EntityBase;
        void RemoveRange(IEnumerable<object> entities); 
        void RemoveRange(Object[] entities);
        int SaveChanges();
        int SaveChanges(bool acceptAllChangesOnSuccess);
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        DbSet<TEntity> Set<TEntity>() where TEntity : EntityBase;
        EntityEntry Update(object entity);
        EntityEntry<TEntity> Update<TEntity>(TEntity entity) where TEntity : EntityBase;
        void UpdateRange(IEnumerable<object> entities);
        void UpdateRange(params object[] entities);
        IInfrastructure<IServiceProvider> ServiceProvider { get; }
    }
}