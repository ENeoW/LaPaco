// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Client.cs" company="Home">
//   Copyright (c) 2018  Eloy Y. Pedroso Faget.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace LaPaco.DTO.Models
{
    public class Client
    {
      /// <summary>
      /// Primary key of Model.
      /// </summary>
      public int ClientId { get; set; }

      /// <summary>
      /// Name of the client.
      /// </summary>
      public string Name { get; set; }

      /// <summary>
      /// Telephone of the client.
      /// </summary>
      public string Telephone { get; set; }

      /// <summary>
      /// Cell phone of the client.
      /// </summary>
      public string CellPhone { get; set; }

      /// <summary>
      /// Personal address of the client.
      /// </summary>
      public string Address { get; set; }

      /// <summary>
      /// Email of the client.
      /// </summary>
      public string Email { get; set; }

      /// <summary>
      /// Path where the picture of the client is saved.
      /// </summary>
      public string Picture { get; set; }

      /// <summary>
      /// Any description of the client.
      /// </summary>
      public string Description { get; set; }

      /// <summary>
      /// Collection of <see cref="Order"/> made for this client.
      /// </summary>
      public virtual ICollection<Order> Orders { get; set; }

      /// <summary>
      /// Collection of <see cref="SaleProduct"/> made to this client.
      /// </summary>
      public virtual ICollection<SaleProduct> Sales { get; set; }
   }
}
