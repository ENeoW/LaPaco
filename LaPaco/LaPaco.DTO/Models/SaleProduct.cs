using System;
using System.Collections.Generic;
using System.Text;

namespace LaPaco.DTO.Models
{
    public class SaleProduct
    {
      public int SaleProductId { get; set; }

      public DateTime DateOfSale { get; set; }

      public decimal Amount { get; set; }

      public decimal Import { get; set; }

      public int InventoryProductId { get; set; }

      public int? ClientId { get; set; }

      public virtual InventoryProduct Inventory { get; set; }

      public virtual Client Client { get; set; }
   }
}
