using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Transactions;
using Microsoft.EntityFrameworkCore.ChangeTracking;


namespace Exps.Common
{           
    public interface IDataContext : IDisposable
    {
        EntityEntry<TEntity> Add<TEntity>(TEntity entity) where TEntity : class;

        TEntity Update<TEntity>(TEntity entity) where TEntity : class;
        EntityEntry<TEntity> Remove<TEntity>(TEntity entity) where TEntity : class;

        

        IQueryable<TEntity> Query<TEntity>() where TEntity : class;

        TEntity Find<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class;


        //IEnumerable<TEntity> AddRange<TEntity>(IEnumerable<TEntity> entity) where TEntity : class;
        //TEntity Remove<TEntity>(TEntity entity) where TEntity : class;
        //IEnumerable<TEntity> RemoveRange<TEntity>(IEnumerable<TEntity> entity) where TEntity : class;
        //TEntity Update<TEntity>(TEntity entity) where TEntity : class;
        int SaveChanges();
    }
}