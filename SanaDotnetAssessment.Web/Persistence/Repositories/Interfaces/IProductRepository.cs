using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaDotnetAssessment.Web.Persistence.Repositories.Interfaces
{
    public interface IProductRepository<T>: IGenericRepository<T> where T:class
    {
    }
}
