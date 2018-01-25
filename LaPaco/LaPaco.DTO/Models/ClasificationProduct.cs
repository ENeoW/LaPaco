﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LaPaco.DTO.Models
{
   public class ClasificationProduct
   {
      public int ProductClasifiationId { get; set; }

      public string Name { get; set; }

      public string Description { get; set; }

      public virtual ICollection<Product> Products { get; set; }
   }
}
