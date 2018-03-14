using LaPaco.Models;
using LaPaco.Repository.Contrats;
using LaPaco.Repository.EF.DAL;

namespace LaPaco.Repository.EF
{
   public class SellerRepository : Repository<Seller>, ISellerRepository
   {
      public SellerRepository(LaPacoContext context) : base(context)
      {
      }
   }
}
