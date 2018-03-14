// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryProduct.cs" company="Home">
//   Copyright (c) 2018  Eloy Y. Pedroso Faget.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using System.Collections.Generic;

namespace LaPaco.Models
{
    public class InventoryProduct
    {
      /// <summary>
      /// Primary key of Model.
      /// </summary>
      public int InventoryProductId { get; set; }

      /// <summary>
      /// Amount of this inventory.
      /// </summary>
      public decimal Stock { get; set; }

      /// <summary>
      /// Cost price of this inventory.
      /// </summary>
      public decimal CostPrice { get; set; }

      /// <summary>
      /// Sale price what possibly this products is going to be sold.
      /// </summary>
      public decimal PosibleSalePrice { get; set; }

      /// <summary>
      /// Foreign key of <see cref="Models.Color"/>.
      /// </summary>
      public int? ColorId { get; set; }

      /// <summary>
      /// Foreign key of <see cref="Models.Color"/>
      /// </summary>
      public int PackageId { get; set; }

      /// <summary>
      /// Foreign key of <see cref="Models.Product"/>
      /// </summary>
      public int ProductId { get; set; }

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

      /// <summary>
      /// Collection of <see cref="SaleProduct"/> made in this inventory
      /// </summary>
      public virtual ICollection<SaleProduct> Sales { get; set; }

      //todo check that.
      public virtual ICollection<Seller> Sellers { get; set; }
   }
}
