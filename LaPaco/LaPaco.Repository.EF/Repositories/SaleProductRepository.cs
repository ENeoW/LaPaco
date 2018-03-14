using LaPaco.DTO.Models;
using LaPaco.Repository.Contrats;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaPaco.Repository.EF
{
   public class SaleProductRepository : Repository<SaleProduct>, ISaleProductRepository
   {
      public SaleProductRepository(DbContext context) : base(context)
      {
      }
   }
}
