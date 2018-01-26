// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PurchaseProduct.cs" company="Home">
//   Copyright (c) 2018  Eloy Y. Pedroso Faget.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using System;

namespace LaPaco.DTO.Models
{
   public class PurchaseProduct
    {
      /// <summary>
      /// Primary key of Model.
      /// </summary>
      public int PurchaseProductId { get; set; }

      /// <summary>
      /// Date of purchase.
      /// </summary>
      public DateTime DateOfPurchase { get; set; }

      /// <summary>
      /// Amount of product purchased
      /// </summary>
      public decimal Amount { get; set; }

      /// <summary>
      /// Weight in Kg for the purchase.
      /// </summary>
      public decimal? WeightKg { get; set; }

      /// <summary>
      /// Total import of the purchase.
      /// </summary>
      public decimal Import { get; set; }

      /// <summary>
      /// Foreign key of <see cref="Models.Color"/>
      /// </summary>
      public int? ColorId { get; set; }

      /// <summary>
      /// Foreign key of <see cref="Models.Product"/>
      /// </summary>
      public int ProductId { get; set; }

      /// <summary>
      /// Foreign key of <see cref="Models.Package"/>
      /// </summary>
      public int PackageId { get; set; }

      /// <summary>
      /// Object reference of <see cref="Models.Color"/>
      /// </summary>
      public virtual Color Color { get; set; }

      /// <summary>
      /// Object reference of <see cref="Models.Product"/>
      /// </summary>
      public virtual Product Product { get; set; }

      /// <summary>
      /// Object reference of <see cref="Models.Package"/>
      /// </summary>
      public virtual Package Package { get; set; }
   }
}
