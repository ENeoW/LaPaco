// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Package.cs" company="Home">
//   Copyright (c) 2018  Eloy Y. Pedroso Faget.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace LaPaco.DTO.Models
{
   public class Package
   {
      /// <summary>
      /// Primary key of Model.
      /// </summary>
      public int PackageId { get; set; }

      /// <summary>
      /// Name of the package.
      /// </summary>
      public string Name { get; set; }

      /// <summary>
      /// Date when it could make a trip.
      /// </summary>
      public DateTime DateOfTrip { get; set; }

      /// <summary>
      /// Name of the country of trip.
      /// </summary>
      public string CountryFrom { get; set; }

      /// <summary>
      /// The free Kg allowed by the aeroline that it can not to pay.
      /// </summary>
      public decimal AllowedFreeKg { get; set; }

      /// <summary>
      /// Price of the overweight when it pases of free allowed Kg.
      /// </summary>
      public decimal OverweightKgPrice { get; set; }
      
      /// <summary>
      /// Any description of the package.
      /// </summary>
      public string Description { get; set; }

      /// <summary>
      /// Collection of <see cref="Order"/> for this package.
      /// </summary>
      public virtual ICollection<Order> Orders { get; set; }

      /// <summary>
      /// Collection of <see cref="InventoryProduct"/> for this package.
      /// </summary>
      public virtual ICollection<InventoryProduct> Inventories { get; set; }

      /// <summary>
      /// Collection of <see cref="PurchaseProduct"/> from this package.
      /// </summary>
      public virtual ICollection<PurchaseProduct> Purchases { get; set; }
   }
}
