using LaPaco.DTO.Models;
using LaPaco.Repository.Contrats;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaPaco.Repository.EFRepositories
{
   public class PurchaseProductRepository : Repository<PurchaseProduct>, IPurchaseProductRepository
   {
      public PurchaseProductRepository(DbContext context) : base(context)
      {
      }
   }
}
