using LaPaco.DTO.Models;
using LaPaco.Repository.Contrats;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaPaco.Repository.EF
{ 
   public class OrderRepository : Repository<Order>, IOrderRepository
   {
      public OrderRepository(DbContext context) : base(context)
      {
      }
   }
}
