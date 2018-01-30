using LaPaco.DTO.Models;
using LaPaco.Repository.Contrats;
using LaPaco.Repository.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaPaco.Repository.EFRepositories
{
   public class ColorRepository : Repository<Color>, IColorRepository
   {
      public ColorRepository(LaPacoContext context) : base(context)
      {
      }
   }
}
