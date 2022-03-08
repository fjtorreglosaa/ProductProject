using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SanaDotnetAssessment.Web.Core.Domain
{
    public class ProductCategories
    {
        public int ProductCategoryId { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public Product Product { get; set; }
        public Category Category { get; set; }
    }
}