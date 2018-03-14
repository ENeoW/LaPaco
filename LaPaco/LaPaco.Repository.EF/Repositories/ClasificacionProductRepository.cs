using LaPaco.Models;
using LaPaco.Repository.Contrats;
using LaPaco.Repository.EF.DAL;

namespace LaPaco.Repository.EF
{
   public class ClasificacionProductRepository : Repository<ClasificationProduct>, IClasificationProductRepository
   {
      public ClasificacionProductRepository(LaPacoContext context) : base(context)
      {
      }
   }
}
