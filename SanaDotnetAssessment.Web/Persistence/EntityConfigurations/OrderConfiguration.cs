using SanaDotnetAssessment.Web.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace SanaDotnetAssessment.Web.Persistence.EntityConfigurations
{
    public class OrderConfiguration : EntityTypeConfiguration<Order>
    {
        public OrderConfiguration()
        {
            ToTable("Orders");

            HasKey(o => o.Id);

            Property(o => o.Id)
                .HasColumnName("OrderId");

            Property(o => o.EmployeeName)
                .HasColumnType("varchar")
                .HasMaxLength(150)
                .IsRequired();

            Property(o => o.OrderDate)
                .IsRequired();

            HasMany(o => o.Products)
                .WithMany(p => p.Orders)
                .Map(op =>
                {
                    op.MapLeftKey("OrderId");
                    op.MapRightKey("ProductId");
                    op.ToTable("OrderProducts");
                });
        }
    }
}