using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using SanaDotnetAssessment.Web.Core.Domain;

namespace SanaDotnetAssessment.Web.Persistence.EntityConfigurations
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            ToTable("Products");

            HasKey(p => p.Id);

            Property(p => p.Id)
                .HasColumnName("ProductId");

            Property(p => p.ProductName)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("varchar");

            Property(p => p.Price)
                .IsRequired();

            //HasMany(p => p.ProductCategories)
            //    .WithRequired(pc => pc.Product)
            //    .HasForeignKey(pc => pc.ProductId);
        }
    }
}