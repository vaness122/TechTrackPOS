using ByteTech.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace ByteTech.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users => Set<User>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<OrderItem> OrderItems => Set<OrderItem>();
        public DbSet<Payment> Payments => Set<Payment>();
        public DbSet<Discount> Discounts => Set<Discount>();
        public DbSet <Location> Locations => Set<Location>();
        public DbSet<Inventory> Inventories => Set<Inventory>();
        
        public DbSet<Material> Materials => Set<Material>();



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>(entity => {
                entity.Property(p => p.Cost).HasPrecision(18, 2);
                entity.Property(p => p.RegularPrice).HasPrecision(18, 2);
                entity.Property(p => p.WholeSalePrice).HasPrecision(18, 2);
                entity.Property(p => p.PriceA).HasPrecision(18, 2);
                entity.Property(p => p.PriceB).HasPrecision(18, 2);
                entity.Property(p => p.PriceC).HasPrecision(18, 2);
                entity.Property(p => p.CostPrice).HasPrecision(18, 2);
                entity.Property(p => p.SellingPrice).HasPrecision(18, 2);
            });


            modelBuilder.Entity<Discount>(entity => {
                entity.Property(d => d.MaximumDiscountAmount).HasPrecision(18, 2);
                entity.Property(d => d.MinimumOrderAmount).HasPrecision(18, 2);
                entity.Property(d => d.Value).HasPrecision(18, 2);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(c => c.CreditLimit).HasPrecision(18, 2);
                entity.Property(c => c.Balance).HasPrecision(18, 2);
                entity.Property(c => c.Picture).HasColumnType("varbinary(max)");
                entity.HasIndex(c => c.Name);
            });

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Discount)
                .WithMany(d => d.Orders)
                .HasForeignKey("DiscountId")
                .OnDelete(DeleteBehavior.SetNull);


            //////////////////////
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>()
                .HasMany(p => p.OrderItems)
                .WithOne(oi => oi.Product)
                .HasForeignKey(oi => oi.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Customer)
                .WithMany()
                .HasForeignKey(o => o.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Discount)
                .WithMany(d => d.Orders) 
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderItems)
                .WithOne(oi => oi.Order)
                .HasForeignKey(oi => oi.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Order>()
                .HasMany(o => o.Payments)
                .WithOne(p => p.Order)
                .HasForeignKey(p => p.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OrderItem>()
                .Property(oi => oi.DiscountApplied)
                .HasPrecision(18, 2);

            modelBuilder.Entity<User>()
                .Property(u => u.CreditLimit)
                .HasPrecision(18, 2);

            modelBuilder.Entity<User>()
                .Property(u => u.CreditUsed)
                .HasPrecision(18, 2);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<User>()
                .HasIndex(u => u.UserName)
                .IsUnique();
    

            modelBuilder.Entity<Product>()
                .HasIndex(p => p.SKU)
                .IsUnique();

            modelBuilder.Entity<Product>()
                .HasIndex(p => p.LookupCode)
                .IsUnique();

            modelBuilder.Entity<Product>()
                .HasIndex(p => p.Barcode)
                .IsUnique()
                .HasFilter("[Barcode] IS NOT NULL");






            modelBuilder.Entity<Category>()
                .HasIndex(c => c.Name)
                .IsUnique();

            modelBuilder.Entity<Discount>()
                .HasIndex(d => d.Code)
                .IsUnique();

            modelBuilder.Entity<Order>()
                .HasIndex(o => o.OrderNumber)
                .IsUnique();

            modelBuilder.Entity<Product>()
                .Property(p => p.CostPrice)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Product>()
                .Property(p => p.SellingPrice)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Order>()
                .Property(o => o.SubTotal)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Order>()
                .Property(o => o.TaxAmount)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Order>()
                .Property(o => o.DiscountAmount)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Order>()
                .Property(o => o.TotalAmount)
                .HasPrecision(18, 2);

            modelBuilder.Entity<OrderItem>()
                .Property(oi => oi.UnitPrice)
                .HasPrecision(18, 2);

            modelBuilder.Entity<OrderItem>()
                .Property(oi => oi.TotalPrice)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Payment>()
                .Property(p => p.Amount)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Discount>()
                .Property(d => d.Value)
                .HasPrecision(18, 2);


            //location
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Location)
                .WithMany()
                .HasForeignKey(p => p.LocationId)
                .OnDelete(DeleteBehavior.Cascade);

         modelBuilder.Entity<Product>()
        .HasOne(p => p.Material)
        .WithMany()
        .HasForeignKey(p => p.MaterialId)
        .OnDelete(DeleteBehavior.SetNull);

         modelBuilder.Entity<Location>()
        .HasIndex(l => l.Name)
        .IsUnique();

            modelBuilder.Entity<Material>()
            .HasIndex(m => m.Name)
            .IsUnique();

            modelBuilder.Entity<Material>()
       .Property(m => m.Cost)
       .HasPrecision(18, 2);

            //inventory

            modelBuilder.Entity<Inventory>()
        .HasIndex(i => new { i.ProductId, i.LocationId })
        .IsUnique();

            modelBuilder.Entity<Inventory>()
                .Property(i => i.Quantity)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Inventory>()
                .HasOne(i => i.Product)
                .WithMany()
                .HasForeignKey(i => i.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Inventory>()
                .HasOne(i => i.Location)
                .WithMany()
                .HasForeignKey(i => i.LocationId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Customer>()
                .Property(c => c.CreditLimit)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Customer>()
                .Property(c => c.Balance)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Customer>()
                .HasIndex(c => c.Name);






        }
    }
}