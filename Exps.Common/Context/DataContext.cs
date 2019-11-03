using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Exps.Common.Context
{
    public class DataContext : DbContext, IDataContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }
        public new TEntity Update<TEntity>(TEntity entity) where TEntity : class
        {
            Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public new EntityEntry<TEntity> Remove<TEntity>(TEntity entity) where TEntity : class
        {
            return Set<TEntity>().Remove(entity);
        }

        public new IQueryable<TEntity> Query<TEntity>() where TEntity : class
        {
            return Set<TEntity>();
        }

        public TEntity Find<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class
        {
            return Set<TEntity>().FirstOrDefault(predicate);
        }

        //public override EntityEntry<TEntity> Add<TEntity>(TEntity entity)
        //{
        //    return Set<TEntity>().Add(entity);
        //}

        //public IEnumerable<TEntity> AddRange<TEntity>(IEnumerable<TEntity> entity) where TEntity : class
        //{
        //    return Set<TEntity>().AddRange(entity);
        //}

        //public TEntity Remove<TEntity>(TEntity entity) where TEntity : class
        //{
        //    return Set<TEntity>().Remove(entity);
        //}

        //public IEnumerable<TEntity> RemoveRange<TEntity>(IEnumerable<TEntity> entity) where TEntity : class
        //{
        //    return Set<TEntity>()
        //        .RemoveRange(entity);
        //}

        //public TEntity Update<TEntity>(TEntity entity) where TEntity : class
        //{
        //    Entry(entity).State = EntityState.Modified;
        //    return entity;
        //}

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

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~DataContext()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public new void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
