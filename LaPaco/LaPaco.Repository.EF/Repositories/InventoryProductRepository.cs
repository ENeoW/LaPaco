using LaPaco.Models;
using LaPaco.Repository.Contrats;
using LaPaco.Repository.EF.DAL;

namespace LaPaco.Repository.EF
{
   public class InventoryProductRepository : Repository<InventoryProduct>, IInventoryProductRepository
    {
      public InventoryProductRepository(LaPacoContext context) : base (context)
      {
      }
    }
}
