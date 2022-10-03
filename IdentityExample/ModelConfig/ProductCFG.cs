using IdentityExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityExample.ModelConfig
{
    public class ProductCFG : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                 new Product { ProductId = 1, ProductName = "Notebook", Category = "Office Stationery", CostPrice = 10, SellingPrice = 13 },
                new Product { ProductId = 2, ProductName = "Pencil", Category = "Office Stationery", CostPrice = 1, SellingPrice = 2 },
                new Product { ProductId = 3, ProductName = "Mouse", Category = "Computer Accessories", CostPrice = 18, SellingPrice = 25 }
                );
               
            
        }
    }
}
