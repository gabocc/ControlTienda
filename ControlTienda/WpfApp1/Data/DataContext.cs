

namespace WpfApp1.Data
{
    using System.Data.Entity;
    using WpfApp1.Data.Entities;

    public class DataContext:DbContext
    {
        public DbSet<Cash> Cashes { set; get; }
        public DbSet<CashFlow> CashFlows { set; get; }
        public DbSet<Category> Categories { set; get; }
        public DbSet<PurchaseDetail> PurchaseDetails { set; get; }
        public DbSet<SaleDetail> SaleDetails { set; get; }
        public DbSet<Sale> Sales { set; get; }
        public DbSet<Refount> Refounts { set; get; }
        public DbSet<Rol> Rols { set; get; }
        public DbSet<User> Users { set; get; }
        public DbSet<Purchase> Purchases { set; get; }
        public DbSet<Login> Logins { set; get; }
        public DbSet<Product> Products { set; get; }
    }
}
