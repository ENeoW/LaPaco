using System;
using System.Collections.Generic;
using System.Text;

namespace LaPaco.DTO.Models
{
    class PurchaseProduct
    {
      public int PurchaseProductId { get; set; }

      public DateTime DateOfPurchase { get; set; }

      public decimal Amount { get; set; }

      public decimal WeightKg { get; set; }

      public decimal Import { get; set; }
   }
}
