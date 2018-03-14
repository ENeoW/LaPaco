using LaPaco.Models;
using LaPaco.Repository.Contrats;
using Microsoft.EntityFrameworkCore;

namespace LaPaco.Repository.EF
{
   public class ProductRepository : Repository<Product>, IProductRepository
   {
      public ProductRepository(DbContext context) : base(context)
      {
      }
   }
}
