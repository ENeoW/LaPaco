using LaPaco.Models;
using LaPaco.Repository.Contrats;
using Microsoft.EntityFrameworkCore;

namespace LaPaco.Repository.EF
{
   public class PackageRepository : Repository<Package>, IPackageRepository
   {
      public PackageRepository(DbContext context) : base(context)
      {
      }
   }
}
