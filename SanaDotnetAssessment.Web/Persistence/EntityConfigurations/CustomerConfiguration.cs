using SanaDotnetAssessment.Web.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace SanaDotnetAssessment.Web.Persistence.EntityConfigurations
{
    public class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            ToTable("Customers");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .HasColumnName("CustomerId");

            Property(c => c.Address)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("varchar");

            Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("varchar");

            Property(c => c.Phone)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("varchar");

            Property(c => c.FullName)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("varchar");

            HasMany(c => c.Orders)
                .WithRequired(o => o.Customer)
                .HasForeignKey(o => o.CustomerId);
        }
    }
}