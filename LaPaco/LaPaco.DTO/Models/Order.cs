using System;
using System.Collections.Generic;
using System.Text;

namespace LaPaco.DTO.Models
{
   public class Order
   {
      public int OrderId { get; set; }

      public DateTime DateOfOrder { get; set; }

      public decimal Amount { get; set; }

      public int ClientId { get; set; }

      public int ProductId { get; set; }

      public int ColorId { get; set; }

      public int PackageId { get; set; }

      public virtual Client Client { get; set; }

      public virtual Product Product { get; set; }

      public virtual Color Color { get; set; }

      public virtual Package Package { get; set; }
   }
}
