using IdentityExample.Models;
using IdentityExample.ModelConfig;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace IdentityExample.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
       protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration<Product>(new ProductCFG());
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name="admin",NormalizedName="ADMIN"},
                new IdentityRole { Name="user",NormalizedName="USER"}
                );
        }
    }
}