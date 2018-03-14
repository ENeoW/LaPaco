using LaPaco.Repository.Contrats;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace LaPaco.Repository.EF
{
   public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
   {
      protected readonly UnitOfWork uow;
      protected readonly DbSet<TEntity> dbSet;

      public Repository(IUnitOfWork uow)
      {
         dbSet = this.uow.Db.Set<TEntity>();
      }

      public Task AddAsync(TEntity entity)
      {
         return dbSet.AddAsync(entity);
      }
      
      public Task AddRangeAsync(IEnumerable<TEntity> entities)
      {
         return dbSet.AddRangeAsync(entities);
      }      

      public Task<List<TEntity>> GetAllAsync()
      {
         return dbSet.ToListAsync();
      }

      public Task<TEntity> GetByIdAsync(object id)
      {
         return dbSet.FindAsync(id);
      }

      public void Update(TEntity entity)
      {
         dbSet.Update(entity);
      }

      public void UpdateRange(IEnumerable<TEntity> entities)
      {
         dbSet.UpdateRange(entities);
      }

      public void Remove(TEntity entity)
      {
         dbSet.Remove(entity);
      }

      public void Remove(IEnumerable<TEntity> entities)
      {
         dbSet.RemoveRange(entities);
      }
   }
}
