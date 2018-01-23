using System;
using System.Collections.Generic;
using System.Text;

namespace LaPaco.DTO.Models
{
    class InventoryProduct
    {
      public int InventoryProductId { get; set; }

      public decimal Stock { get; set; }

      public decimal CostPrice { get; set; }

      public decimal PosibleSalePrice { get; set; }
   }
}
