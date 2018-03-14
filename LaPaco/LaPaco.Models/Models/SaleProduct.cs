// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SaleProduct.cs" company="Home">
//   Copyright (c) 2018  Eloy Y. Pedroso Faget.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace LaPaco.Models
{
    public class SaleProduct
    {
      /// <summary>
      /// Primary key of Model.
      /// </summary>
      public int SaleProductId { get; set; }

      /// <summary>
      /// Date of the sale.
      /// </summary>
      public DateTime DateOfSale { get; set; }

      /// <summary>
      /// Amount of products sold.
      /// </summary>
      public decimal Amount { get; set; }

      /// <summary>
      /// Total import of the sale.
      /// </summary>
      public decimal Import { get; set; }

      /// <summary>
      /// Foreign key of <see cref="InventoryProduct"/>
      /// </summary>
      public int InventoryProductId { get; set; }

      /// <summary>
      /// Foreign key of <see cref="Models.Client"/>
      /// </summary>
      public int? ClientId { get; set; }

      /// <summary>
      /// Object reference of <see cref="InventoryProduct"/>
      /// </summary>
      public virtual InventoryProduct Inventory { get; set; }

      /// <summary>
      /// Object reference of <see cref="Models.Client"/>
      /// </summary>
      public virtual Client Client { get; set; }
   }
}
