using SanaDotnetAssessment.Web.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace SanaDotnetAssessment.Web.Persistence.EntityConfigurations
{
    public class ProductCategoriesConfiguration : EntityTypeConfiguration<ProductCategories>
    {
        public ProductCategoriesConfiguration()
        {
            ToTable("ProductCategories");

            HasKey(c => c.ProductCategoryId);

            Property(c => c.ProductId)
                .IsRequired()
                .HasColumnName("ProductId");

            Property(c => c.CategoryId)
                .IsRequired()
               .HasColumnName("CategoryId");
        }
    }
}