using LaPaco.Models;
using LaPaco.Repository.Contrats;
using LaPaco.Repository.EF.DAL;

namespace LaPaco.Repository.EF
{
   public class ClientRepository : Repository<Client>, IClientRepository
   {
      public ClientRepository(LaPacoContext context) : base(context)
      {
      }
   }
}
