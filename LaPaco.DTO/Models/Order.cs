using System;
using System.Collections.Generic;
using System.Text;

namespace LaPaco.DTO.Models
{
   class Order
   {
      public int OrderId { get; set; }

      public DateTime DateOfOrder { get; set; }

      public decimal Amount { get; set; }
   }
}
