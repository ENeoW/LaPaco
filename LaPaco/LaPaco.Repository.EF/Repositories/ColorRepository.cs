using LaPaco.Models;
using LaPaco.Repository.Contrats;
using LaPaco.Repository.EF.DAL;

namespace LaPaco.Repository.EF
{
   public class ColorRepository : Repository<Color>, IColorRepository
   {
      public ColorRepository(LaPacoContext context) : base(context)
      {
      }
   }
}
