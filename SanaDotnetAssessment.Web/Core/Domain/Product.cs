using SanaDotnetAssessment.Web.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SanaDotnetAssessment.Web.Core.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        [PriceValidation]
        public decimal Price { get; set; }
        public ICollection<ProductCategories> ProductCategories { get; set; }
        public ICollection<Order>  Orders { get; set; }
    }
}