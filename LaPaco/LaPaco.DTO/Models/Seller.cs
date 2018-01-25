using System;
using System.Collections.Generic;
using System.Text;

namespace LaPaco.DTO.Models
{
   public class Seller
   {
      public int SellerId { get; set; }

      public string Name { get; set; }

      public string Telephone { get; set; }

      public string CellPhone { get; set; }

      public string Address { get; set; }

      public string Email { get; set; }

      public string Picture { get; set; }

      public string Description { get; set; }

      //todo: I do not think this is right .. check well please.
      public virtual ICollection<InventoryProduct> Inventories { get; set; }
   }
}
