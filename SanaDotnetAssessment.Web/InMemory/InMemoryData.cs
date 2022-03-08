using SanaDotnetAssessment.Web.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SanaDotnetAssessment.Web.InMemory
{
    public class InMemoryData
    {
        public static List<Product> products = new List<Product>
        {
            new Product
            {
                Id=1,
                ProductName="Yogurt",
                Price=15,
                ProductCategories = new List<ProductCategories>
                {
                    new ProductCategories
                    {
                        ProductCategoryId=1,
                        CategoryId=1,
                        ProductId=1
                    },
                    new ProductCategories
                    {
                        ProductCategoryId=2,
                        CategoryId=5,
                        ProductId=1
                    }
                }
            },
            new Product
            {
                Id=2,
                ProductName="Roast Beef 500gr",
                Price=50,
                ProductCategories = new List<ProductCategories>
                {
                    new ProductCategories
                    {
                        ProductCategoryId=3,
                        CategoryId=2,
                        ProductId=2
                    },
                    new ProductCategories
                    {
                        ProductCategoryId=4,
                        CategoryId=3,
                        ProductId=2
                    },
                    new ProductCategories
                    {
                        ProductCategoryId=5,
                        CategoryId=5,
                        ProductId=2
                    }
                }
            },
            new Product
            {
                Id=3,
                ProductName="Watermelon",
                Price=25,
                ProductCategories = new List<ProductCategories>
                {
                    new ProductCategories
                    {
                        ProductCategoryId=6,
                        CategoryId=6,
                        ProductId=3
                    },
                    new ProductCategories
                    {
                        ProductCategoryId=7,
                        CategoryId=7,
                        ProductId=3
                    }
                }
            },
        };

        public void AddProduct(Product entity)
        {
            products.Add(entity);
        }

        public List<ProductCategories> productCategories = new List<ProductCategories>();


        public List<Category> ListOfCategories = new List<Category>
        {
            new Category
            {
                Id=1,
                Name="Dairy"
            },
            new Category
            {
                Id=2,
                Name="Beef"
            },
            new Category
            {
                Id=3,
                Name="Roast"
            },
            new Category
            {
                Id=4,
                Name="Personal Care"
            },
            new Category
            {
                Id=5,
                Name="Basic Nutrition Plan"
            },
            new Category
            {
                Id=6,
                Name="Fruits"
            },
            new Category
            {
                Id=7,
                Name="Apples"
            }
        };

    }
}