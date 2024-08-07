using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

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

  /* protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>()
            .HasMany(p => p.productCategoryRelations)
            .WithOne(pcr => pcr.Product)
            .HasForeignKey(pcr => pcr.ProductId);

        modelBuilder.Entity<ProductCategory>()
            .HasMany(pc => pc.productCategoryRelations)
            .WithOne(pcr => pcr.ProductCategory)
            .HasForeignKey(pcr => pcr.ProductCategoryId);
    }  */
}
