using LaPaco.Models;
using Microsoft.EntityFrameworkCore;

namespace LaPaco.Repository.EF.DAL
{
   public class LaPacoContext: DbContext
    {
      public DbSet<ClasificationProduct> ClasificationsProduct{ get; set; }

      public DbSet<Client> Clients { get; set; }

      public DbSet<Color> Colors { get; set; }

      public DbSet<InventoryProduct> InventoriesProduct { get; set; }

      public DbSet<Order> Orders { get; set; }

      public DbSet<Package> Packages { get; set; }

      public DbSet<Product> Products { get; set; }

      public DbSet<PurchaseProduct> PurchasesProduct { get; set; }

      public DbSet<SaleProduct> SalesProduct { get; set; }

      public DbSet<Seller> Sellers { get; set; }

      private string databasePath { get; set; }

      public LaPacoContext(string databasePath)
      {
         Database.EnsureCreated();
         this.databasePath = databasePath;
      }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
         optionsBuilder.UseSqlite($"Filename={databasePath}");
         base.OnConfiguring(optionsBuilder);
      }
   }
}
