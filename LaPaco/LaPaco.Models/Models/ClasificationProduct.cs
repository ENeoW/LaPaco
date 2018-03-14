// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ClasificationProduct.cs" company="Home">
//   Copyright (c) 2018  Eloy Y. Pedroso Faget.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using System.Collections.Generic;

namespace LaPaco.Models
{
   public class ClasificationProduct
   {
      /// <summary>
      /// Primary key of Model.
      /// </summary>
      public int ProductClasifiationId { get; set; }

      /// <summary>
      /// Name of the clasification.
      /// </summary>
      public string Name { get; set; }

      /// <summary>
      /// Any description of the clasification.
      /// </summary>
      public string Description { get; set; }

      /// <summary>
      /// Collection of <see cref="Product"/> to belong this clasification.
      /// </summary>
      public virtual ICollection<Product> Products { get; set; }
   }
}
