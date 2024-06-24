using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<WebShop> WebShops { get; set; }

        public DbSet<IdentityWebShop> Identities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityWebShop>()
                .HasOne(i => i.WebShop)
                .WithMany()
                .HasForeignKey(i => i.WebShopId);
        }
    }

}
