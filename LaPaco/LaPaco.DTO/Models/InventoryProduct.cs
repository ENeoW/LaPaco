using System;
using System.Collections.Generic;
using System.Text;

namespace LaPaco.DTO.Models
{
    public class InventoryProduct
    {
      public int InventoryProductId { get; set; }

      public decimal Stock { get; set; }

      public decimal CostPrice { get; set; }

      public decimal PosibleSalePrice { get; set; }

      public int ColorId { get; set; }

      public int PackageId { get; set; }

      public int ProductId { get; set; }

      public virtual Color Color { get; set; }

      public virtual Product Product { get; set; }

      public virtual Package Package { get; set; }

      public virtual ICollection<SaleProduct> Sales { get; set; }

      //todo check that.
      public virtual ICollection<Seller> Sellers { get; set; }
   }
}
