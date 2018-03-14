using LaPaco.DTO.Models;
using LaPaco.Repository.Contrats;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaPaco.Repository.EF
{
   public class ProductRepository : Repository<Product>, IProductRepository
   {
      public ProductRepository(DbContext context) : base(context)
      {
      }
   }
}
