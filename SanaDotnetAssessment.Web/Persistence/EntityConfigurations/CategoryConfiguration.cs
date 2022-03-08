using SanaDotnetAssessment.Web.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace SanaDotnetAssessment.Web.Persistence.EntityConfigurations
{
    public class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            ToTable("Categories");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .HasColumnName("CategoryId");

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("varchar")
                .HasColumnName("CategoryName");

            //HasMany(c => c.ProductCategories)
            //    .WithRequired(pc => pc.Category)
            //    .HasForeignKey(pc => pc.CategoryId);
        }
    }
}