// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Order.cs" company="Home">
//   Copyright (c) 2018  Eloy Y. Pedroso Faget.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using System;

namespace LaPaco.Models
{
   public class Order
   {
      /// <summary>
      /// Primary key of Model.
      /// </summary>
      public int OrderId { get; set; }

      /// <summary>
      /// Date when the order was made.
      /// </summary>
      public DateTime DateOfOrder { get; set; }

      /// <summary>
      /// Amount of this product.
      /// </summary>
      public decimal Amount { get; set; }

      /// <summary>
      /// Foreign key of <see cref="Models.Client"/>
      /// </summary>
      public int ClientId { get; set; }

      /// <summary>
      /// Foreign key of <see cref="Models.Product"/>
      /// </summary>
      public int ProductId { get; set; }

      /// <summary>
      /// Foreign key of <see cref="Models.Color"/>
      /// </summary>
      public int? ColorId { get; set; }

      /// <summary>
      /// Foreign key of <see cref="Models.Package"/>
      /// </summary>
      public int PackageId { get; set; }

      /// <summary>
      /// Object reference of <see cref="Models.Client"/>
      /// </summary>
      public virtual Client Client { get; set; }

      /// <summary>
      /// Object reference of <see cref="Models.Product"/>
      /// </summary>
      public virtual Product Product { get; set; }

      /// <summary>
      /// Object reference of <see cref="Models.Color"/>
      /// </summary>
      public virtual Color Color { get; set; }

      /// <summary>
      /// Object reference of <see cref="Models.Package"/>
      /// </summary>
      public virtual Package Package { get; set; }
   }
}
