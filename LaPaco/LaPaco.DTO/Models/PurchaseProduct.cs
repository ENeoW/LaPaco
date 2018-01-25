using System;
using System.Collections.Generic;
using System.Text;

namespace LaPaco.DTO.Models
{
    public class PurchaseProduct
    {
      public int PurchaseProductId { get; set; }

      public DateTime DateOfPurchase { get; set; }

      public decimal Amount { get; set; }

      public decimal WeightKg { get; set; }

      public decimal Import { get; set; }

      public int ColorId { get; set; }

      public int ProductId { get; set; }

      public int PackageId { get; set; }

      public virtual Color Color { get; set; }

      public virtual Product Product { get; set; }

      public virtual Package Package { get; set; }
   }
}
