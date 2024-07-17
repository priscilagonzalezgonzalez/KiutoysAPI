using DB.Models;
using Microsoft.EntityFrameworkCore;

namespace DB;

public class KiutoysContext : DbContext
{
  public KiutoysContext(DbContextOptions<KiutoysContext> options)
    : base(options)
  {
    
  }

  public DbSet<Address> Addresses { get; set; }
  public DbSet<CartItem> CartItems { get; set; }
  public DbSet<DeliveryInfo> DeliveryInfos { get; set; }
  public DbSet<Order> Orders { get; set; }
  public DbSet<OrderItem> OrderItems { get; set; }
  public DbSet<OrderStatus> OrderStatuses { get; set; }
  public DbSet<Payment> Payments { get; set; }
  public DbSet<PaymentMethod> PaymentMethods { get; set; }
  public DbSet<Product> Products { get; set; }
  public DbSet<ProductCategory> ProductCategories { get; set; }
  public DbSet<ProductCategoryRelation> ProductCategoryRelations { get; set; }
  public DbSet<UserAccount> UserAccounts { get; set; }
}
