﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SanaDotnetAssessment.Web.Core.Domain
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ProductCategories> ProductCategories { get; set; }
    }
}