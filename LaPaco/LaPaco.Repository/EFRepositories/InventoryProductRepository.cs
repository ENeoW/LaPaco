using LaPaco.DTO.Models;
using LaPaco.Repository.Contrats;
using LaPaco.Repository.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaPaco.Repository.EFRepositories
{
    public class InventoryProductRepository : Repository<InventoryProduct>, IInventoryProductRepository
    {
      public InventoryProductRepository(LaPacoContext context) : base (context)
      {
      }
    }
}
