using LaPaco.Models;
using LaPaco.Repository.Contrats;
using LaPaco.Repository.EF.DAL;

namespace LaPaco.Repository.EF
{
   public class OrderRepository : Repository<Order>, IOrderRepository
   {
      public OrderRepository(LaPacoContext context) : base(context)
      {
      }
   }
}
