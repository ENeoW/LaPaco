using System;
using System.Collections.Generic;
using System.Text;

namespace LaPaco.DTO.Models
{
   public class Product
   {
      public int ProductId { get; set; }

      public string Name { get; set; }

      public string Image { get; set; }

      public string Description { get; set; }

      public int ClasificationProductId { get; set; }

      public virtual ClasificationProduct Clasification { get; set; }

      public virtual ICollection<InventoryProduct> Inventories { get; set; }

      public virtual ICollection<Order> Orders { get; set; }

      public virtual ICollection<PurchaseProduct> Purchases { get; set; }


   }
}
