using SanaDotnetAssessment.Web.Core.Domain;
using SanaDotnetAssessment.Web.Persistence.EntityConfigurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SanaDotnetAssessment.Web.Persistence
{
    public class SanaDotnetAssessmentDbContext : DbContext
    {
        public SanaDotnetAssessmentDbContext() : base("name=SanaDotnetAssessmentDbContext")
        {
        }
        
        //Instead of using 4 entities, I would created another entity called 
        //OrderDetail entity. This entity would contail all the invoice details.
        //This way I can manage a set of products of the same ID instead of
        //adding them one by one in an OrderProducts table.

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ProductCategories> ProductCategories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new OrderConfiguration());
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new ProductCategoriesConfiguration());
        }
    }
}