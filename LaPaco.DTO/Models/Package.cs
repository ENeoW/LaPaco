using System;
using System.Collections.Generic;
using System.Text;

namespace LaPaco.DTO.Models
{
    class Package
    {
      public int PackageId { get; set; }

      public string Name { get; set; }

      public DateTime DateOfTrip { get; set; }

      public string CountryFrom { get; set; }

      public string Description { get; set; }
   }
}
