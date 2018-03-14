using LaPaco.Repository.Contrats;
using LaPaco.Repository.EF.DAL;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LaPaco.Repository.EF
{
   public class UnitOfWork : IUnitOfWork
   {
      private readonly LaPacoContext db;

      public LaPacoContext Db {  get => this.db; }

      public IClasificationProductRepository clasificationProductRepository { get; }

      public IClientRepository clientRepository { get; }

      public IColorRepository colorRepository { get; }

      public IInventoryProductRepository inventoryProductRepository { get; }

      public IOrderRepository orderRepository { get; }

      public IPackageRepository packageRepository { get; }

      public IProductRepository productRepository { get; }

      public IPurchaseProductRepository purchaseProductRepository { get; }

      public ISaleProductRepository saleProductRepository { get; }

      public ISellerRepository sellerRepository { get; }

      public UnitOfWork(LaPacoContext db)
      {
         this.db = db;
      }

      public void Dispose()
      {
         db.Dispose();
      }

      public Task SaveChanges()
      {
         return db.SaveChangesAsync();
      }
   }
}
