using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Exps.Common.Context
{
    public interface IDataContext : IDisposable
    {
        int SaveChanges();

        IQueryable<TEntity> Query<TEntity>() where TEntity : class;

        EntityEntry<TEntity> Add<TEntity>(TEntity entity) where TEntity : class;

        TEntity Update<TEntity>(TEntity entity) where TEntity : class;

        EntityEntry<TEntity> Remove<TEntity>(TEntity entity) where TEntity : class;

        TEntity Find<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class;
    }
}