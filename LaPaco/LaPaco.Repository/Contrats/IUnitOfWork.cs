using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LaPaco.Repository.Contrats
{
    public interface IUnitOfWork : IDisposable
    {

      IClasificationProductRepository clasificationProductRepository { get; }
      IClientRepository clientRepository { get; }
      IColorRepository colorRepository { get; }
      IInventoryProductRepository inventoryProductRepository { get; }
      IOrderRepository orderRepository { get; }
      IPackageRepository packageRepository { get; }
      IProductRepository productRepository { get; }
      IPurchaseProductRepository purchaseProductRepository { get; }
      ISaleProductRepository saleProductRepository { get; }
      ISellerRepository sellerRepository { get; }
      
      Task SaveChanges();
    }
}
