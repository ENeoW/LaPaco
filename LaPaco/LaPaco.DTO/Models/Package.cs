// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Package.cs" company="">
//   Pricetravel Holding
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace LaPaco.DTO.Models
{
   public class Package
   {
      public int PackageId { get; set; }

      public string Name { get; set; }

      public DateTime DateOfTrip { get; set; }

      public string CountryFrom { get; set; }

      public decimal AllowedFreeKg { get; set; }

      public decimal OverweightKgPrice { get; set; }

      public string Description { get; set; }

      public int OrderId { get; set; }

      public virtual Order Order { get; set; }

      public virtual ICollection<InventoryProduct> Inventories { get; set; }

      public virtual ICollection<PurchaseProduct> Purchases { get; set; }
   }
}
