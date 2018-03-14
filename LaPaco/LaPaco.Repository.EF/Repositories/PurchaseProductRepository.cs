using LaPaco.Models;
using LaPaco.Repository.Contrats;
using Microsoft.EntityFrameworkCore;

namespace LaPaco.Repository.EF
{
   public class PurchaseProductRepository : Repository<PurchaseProduct>, IPurchaseProductRepository
   {
      public PurchaseProductRepository(DbContext context) : base(context)
      {
      }
   }
}
