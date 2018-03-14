using LaPaco.Models;
using LaPaco.Repository.Contrats;
using LaPaco.Repository.EF.DAL;

namespace LaPaco.Repository.EF
{
   public class SaleProductRepository : Repository<SaleProduct>, ISaleProductRepository
   {
      public SaleProductRepository(LaPacoContext context) : base(context)
      {
      }
   }
}
