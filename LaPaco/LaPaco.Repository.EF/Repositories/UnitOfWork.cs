using LaPaco.Repository.Contrats;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LaPaco.Repository.EF
{
   public class UnitOfWork : IUnitOfWork
   {
      private readonly DbContext db;

      public DbContext Db {  get => this.db; }

      public UnitOfWork(DbContext db)
      {
         this.db = db;
      }

      public void Dispose()
      {
         db.Dispose();
      }

      public Task SaveChanges()
      {
         return db.SaveChangesAsync();
      }
   }
}
