using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SanaDotnetAssessment.Web.Core.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}