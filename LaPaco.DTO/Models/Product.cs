// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Home">
//   Copyright (c) 2018  Eloy Y. Pedroso Faget.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using System.Collections.Generic;

namespace LaPaco.DTO.Models
{
   public class Product
   {
      /// <summary>
      /// Primary key of Model.
      /// </summary>
      public int ProductId { get; set; }

      /// <summary>
      /// Name of the product.
      /// </summary>
      public string Name { get; set; }

      /// <summary>
      /// Path where the image is saved.
      /// </summary>
      public string Image { get; set; }

      /// <summary>
      /// Any description of the product.
      /// </summary>
      public string Description { get; set; }

      /// <summary>
      /// Foreign key of <see cref="ClasificationProduct"/>
      /// </summary>
      public int ClasificationProductId { get; set; }

      /// <summary>
      /// Object reference of <see cref="ClasificationProduct"/>
      /// </summary>
      public virtual ClasificationProduct Clasification { get; set; }

      /// <summary>
      /// Collection of <see cref="InventoryProduct"/> that belong to this product.
      /// </summary>
      public virtual ICollection<InventoryProduct> Inventories { get; set; }

      /// <summary>
      /// Collection of <see cref="Order"/> made for this product
      /// </summary>
      public virtual ICollection<Order> Orders { get; set; }

      /// <summary>
      /// Collection of <see cref="PurchaseProduct"/> for this product.
      /// </summary>
      public virtual ICollection<PurchaseProduct> Purchases { get; set; }


   }
}
