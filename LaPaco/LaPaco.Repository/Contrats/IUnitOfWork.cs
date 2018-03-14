using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LaPaco.Repository.Contrats
{
    public interface IUnitOfWork : IDisposable
    {
      Task SaveChanges();
    }
}
