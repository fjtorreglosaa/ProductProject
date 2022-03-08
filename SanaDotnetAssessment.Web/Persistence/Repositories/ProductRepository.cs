using SanaDotnetAssessment.Web.Core.Domain;
using SanaDotnetAssessment.Web.Persistence.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SanaDotnetAssessment.Web.Persistence.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository<Product>
    {
    }
}