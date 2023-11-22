using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Order.Infrastructure.DbContexts
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
        {
        }

        public DbSet<Domain.AggregatesModel.OrderAggregate.Order> Order => Set<Domain.AggregatesModel.OrderAggregate.Order>();
        public DbSet<Domain.AggregatesModel.OrderItemAggregate.OrderItem> OrderItem => Set<Domain.AggregatesModel.OrderItemAggregate.OrderItem>();
        public DbSet<Domain.AggregatesModel.AddressAggregate.Address> Address => Set<Domain.AggregatesModel.AddressAggregate.Address>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Domain.AggregatesModel.OrderItemAggregate.OrderItem>()
                .Property(item => item.UnitPrice).HasPrecision(18, 2); // Hassasiyet ve ölçek belirleme

            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
