// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Color.cs" company="Home">
//   Copyright (c) 2018  Eloy Y. Pedroso Faget.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using System.Collections.Generic;

namespace LaPaco.DTO.Models
{
   public class Color
    {
      /// <summary>
      /// Primary key of Model.
      /// </summary>
      public int ColorId { get; set; }

      /// <summary>
      /// Name of the color.
      /// </summary>
      public string Name { get; set; }

      /// <summary>
      /// Collection of <see cref="PurchaseProduct"/> in this color.
      /// </summary>
      public virtual ICollection<PurchaseProduct> Purchases { get; set; }

      /// <summary>
      /// Collection of <see cref="InventoryProduct"/> with this color.
      /// </summary>
      public virtual ICollection<InventoryProduct> Inventories { get; set; }

      /// <summary>
      /// Collection of <see cref="Order"/> in this color.
      /// </summary>
      public virtual ICollection<Order> Orders { get; set; }
   }
}
