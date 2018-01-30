using LaPaco.DTO.Models;
using LaPaco.Repository.EFRepositories;
using LaPaco.Repository.DAL;
using LaPaco.Repository.Contrats;

namespace LaPaco.Repository.EFRepositories
{
   public class ClasificacionProductRepository : Repository<ClasificationProduct>, IClasificationProductRepository
   {
      public ClasificacionProductRepository(LaPacoContext context) : base(context)
      {
      }
   }
}
