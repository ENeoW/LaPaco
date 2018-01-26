﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LaPaco.Repository.Contrats
{
   public interface IRepository<TEntity> where TEntity : class
   {
      Task AddAsync(TEntity entity);

      Task AddRangeAsync(IEnumerable<TEntity> entities);

      Task<List<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);

      Task<List<TEntity>> GetAllAsync();

      Task<TEntity> GetByIdAsync(object id);

      void Remove(TEntity entity);

      void Remove(IEnumerable<TEntity> entities);
   }
}
