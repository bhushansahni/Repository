using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Repository.Base;

namespace Repository.Core
{
    public class DbContextBase<TEntity> : DbContext,IDbContext where TEntity:EntityBase
    {

        DbConnection _connection;
        public DbContextBase(IDbConnection connection)
        {
            _connection = connection as DbConnection;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder _contextOptions)
        {
            _contextOptions.UseSqlServer(_connection);
        }
        public DbSet<TEntity> Entities { get; set; }
        public DatabaseFacade Database {get; private set;}

        public ChangeTracker ChangeTracker {get; private set;}

        public IModel Model {get; private set;}

        public IInfrastructure<IServiceProvider> ServiceProvider {get; private set;}

        public EntityEntry Add(object entity)
        {
            return base.Add(entity);
        }

        public void Add<TEntity>(TEntity entity)where TEntity : EntityBase
        {
             base.Add<TEntity>(entity);
        }

        public void AddAsync(object entity, CancellationToken token)
        {
            base.AddAsync(entity, token);
        }

        public void AddAsync<TEntity>(TEntity entity, CancellationToken token) where TEntity : EntityBase
        {
            base.AddAsync(entity,token);
        }

        public void AddRange(IEnumerable<object> entities)
        {
            base.AddRange(entities);
        }

        public void AddRange(object[] entities)
        {
            base.AddRange(entities);
        }

        public void AddRangeAsync(IEnumerable<object> entities, CancellationToken token)
        {
            base.AddRangeAsync(entities,token);
        }

        public void AddRangeAsync(object[] entities)
        {
            base.AddRangeAsync(entities);
        }

        public void Attach(object entity)
        {
            base.Attach(entity);
        }

        public void Attach<TEntity>(TEntity entity) where TEntity:EntityBase
        {
            base.Attach(entity);
        }

        public void AttachRange(IEnumerable<object> entities)
        {
            base.AttachRange(entities);
        }

        public void AttachRange(object[] entities)
        {
            base.AttachRange(entities);
        }

        public void Dispose()
        {
            base.Dispose();
        }

        public void Entry(object entity)
        {
            base.Entry(entity);
        }

        public void Entry<TEntity>(TEntity entity) where TEntity:EntityBase
        {
            base.Entry(entity);
        }

        public object Find(Type type, object[] entities)
        {
            return base.Find(type,entities);
        }

        public object Find<TEntity>(object[] entities) where TEntity : EntityBase
        {
            return base.Find<TEntity>(entities);
        }

        public object FindAsync(Type type, object[] entities, CancellationToken token)
        {
            return base.FindAsync(type, entities, token);
        }

        public Task<TEntity> FindAsync<TEntity>(object[] keyValues, CancellationToken cancellationToken) where TEntity : EntityBase
        {
            return base.FindAsync<TEntity>(keyValues, cancellationToken);
        }

        public Task<TEntity> FindAsync<TEntity>(params object[] keyValues) where TEntity : EntityBase
        {
            return base.FindAsync<TEntity>(keyValues);
        }

        public EntityEntry Remove(object entity)
        {
            return base.Remove(entity);
        }

        public EntityEntry<TEntity> Remove<TEntity>(TEntity entity) where TEntity : EntityBase
        {
            return base.Remove<TEntity>(entity);
        }

        public void RemoveRange(IEnumerable<object> entities)
        {
            base.RemoveRange(entities);
        }

        public void RemoveRange(object[] entities)
        {
            base.RemoveRange(entities);
        }

        public int SaveChanges()
        {
            return base.SaveChanges();
        }

        public int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken)
        {
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return base.SaveChangesAsync(cancellationToken);
        }

        public DbSet<TEntity> Set<TEntity>() where TEntity : EntityBase
        {
            return base.Set<TEntity>();
        }

        public EntityEntry Update(object entity)
        {
            return base.Update(entity);
        }

        public EntityEntry<TEntity> Update<TEntity>(TEntity entity) where TEntity : EntityBase
        {
            return base.Update(entity);
        }

        public void UpdateRange(IEnumerable<object> entities)
        {
            base.UpdateRange(entities);
        }

        public void UpdateRange(params object[] entities)
        {
            base.UpdateRange(entities);
        }
    }
}