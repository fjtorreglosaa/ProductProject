using SanaDotnetAssessment.Web.Persistence.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SanaDotnetAssessment.Web.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private SanaDotnetAssessmentDbContext _context;

        public GenericRepository()
        {
            _context = new SanaDotnetAssessmentDbContext();
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
    }
}