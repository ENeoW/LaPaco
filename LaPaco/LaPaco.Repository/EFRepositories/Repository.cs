using LaPaco.Repository.Contrats;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace LaPaco.Repository.EFRepositories
{
   public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
   {
      protected readonly DbContext context;

      public Repository(DbContext context)
      {
         this.context = context;
      }

      public Task AddAsync(TEntity entity)
      {
         return context.AddAsync(entity);
      }
      
      public Task AddRangeAsync(IEnumerable<TEntity> entities)
      {
         return context.AddRangeAsync(entities);
      }

      public Task<List<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
      {
         return context.Set<TEntity>().Where(predicate).ToListAsync();
      }

      public Task<List<TEntity>> GetAllAsync()
      {
         return context.Set<TEntity>().ToListAsync();
      }

      public Task<TEntity> GetByIdAsync(object id)
      {
         return context.Set<TEntity>().FindAsync(id);
      }

      public void Remove(TEntity entity)
      {
         context.Set<TEntity>().Remove(entity);
      }

      public void Remove(IEnumerable<TEntity> entities)
      {
         context.Set<TEntity>().RemoveRange(entities);
      }
   }
}
