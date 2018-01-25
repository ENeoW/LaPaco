using System;
using System.Collections.Generic;
using System.Text;

namespace LaPaco.DTO.Models
{
    public class Color
    {
      public int ColorId { get; set; }

      public string Name { get; set; }

      public virtual ICollection<PurchaseProduct> Purchases { get; set; }

      public virtual ICollection<InventoryProduct> Inventories { get; set; }

      public virtual ICollection<Order> Orders { get; set; }
   }
}
