using SanaDotnetAssessment.Web.Core.Domain;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SanaDotnetAssessment.Web.ViewModels
{
    public class ProductViewModel
    {
        public Product Product { get; set; }
        public Category Category { get; set; }
        public IEnumerable<SelectListItem> Categories { get; set; }
        public IEnumerable<int> SelectedCategoryIds { get; set; }
    }
}