using System;
using System.Collections.Generic;
using System.Text;

namespace LaPaco.DTO.Models
{
    public class Client
    {
      public int ClientId { get; set; }

      public string Name { get; set; }

      public string Telephone { get; set; }

      public string CellPhone { get; set; }

      public string Address { get; set; }

      public string Email { get; set; }

      public string Picture { get; set; }

      public string Description { get; set; }

      public virtual ICollection<Order> Orders { get; set; }

      public virtual ICollection<SaleProduct> Sales { get; set; }
   }
}
