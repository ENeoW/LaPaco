using LaPaco.DTO.Models;
using LaPaco.Repository.Contrats;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaPaco.Repository.EF
{
   public class SellerRepository : Repository<Seller>, ISellerRepository
   {
      public SellerRepository(DbContext context) : base(context)
      {
      }
   }
}
