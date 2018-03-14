// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Seller.cs" company="Home">
//   Copyright (c) 2018  Eloy Y. Pedroso Faget.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace LaPaco.DTO.Models
{
   public class Seller
   {
      /// <summary>
      /// Primary key of Model.
      /// </summary>
      public int SellerId { get; set; }

      /// <summary>
      /// Name or the seller.
      /// </summary>
      public string Name { get; set; }

      /// <summary>
      /// Telephone of the seller.
      /// </summary>
      public string Telephone { get; set; }

      /// <summary>
      /// Cell phone of the seller.
      /// </summary>
      public string CellPhone { get; set; }

      /// <summary>
      /// Personal address of the seller.
      /// </summary>
      public string Address { get; set; }

      /// <summary>
      /// Email of the seller.
      /// </summary>
      public string Email { get; set; }

      /// <summary>
      /// Path where the picture of the seller is saved.
      /// </summary>
      public string Picture { get; set; }

      /// <summary>
      /// Any description of the seller.
      /// </summary>
      public string Description { get; set; }

      //todo: I do not think this is right .. check well please.
      public virtual ICollection<InventoryProduct> Inventories { get; set; }
   }
}
