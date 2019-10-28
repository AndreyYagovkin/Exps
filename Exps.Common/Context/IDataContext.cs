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
        //IEnumerable<TEntity> AddRange<TEntity>(IEnumerable<TEntity> entity) where TEntity : class;
        //TEntity Remove<TEntity>(TEntity entity) where TEntity : class;
        //IEnumerable<TEntity> RemoveRange<TEntity>(IEnumerable<TEntity> entity) where TEntity : class;
        //TEntity Update<TEntity>(TEntity entity) where TEntity : class;
        int SaveChanges();
    }
}