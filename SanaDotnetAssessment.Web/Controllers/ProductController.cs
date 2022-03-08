using SanaDotnetAssessment.Web.Core.Domain;
using SanaDotnetAssessment.Web.Persistence;
using SanaDotnetAssessment.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SanaDotnetAssessment.Web.Controllers
{
    public class ProductController : Controller
    {
        private SanaDotnetAssessmentDbContext _context;

        public ProductController()
        {
            _context = new SanaDotnetAssessmentDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Product
        public ActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }

        // GET: Product/id
        public ActionResult New() 
        {
            var categories = _context.Categories.ToList();
            var categoryItems = categories.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Name
            });
            
            var viewModel = new ProductViewModel
            {
                Product = new Product(),
                Categories = categoryItems,                
            };

            return View("ProductForm",viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateProduct(ProductViewModel criteria)
        {
            if (!ModelState.IsValid)
            {
                return View("ProductForm", criteria);
            }

            var productEntity = new Product
            {
                ProductName = criteria.Product.ProductName,
                Price = criteria.Product.Price   
            };

            _context.Products.Add(productEntity);
            _context.SaveChanges();

            var productCategories = criteria.SelectedCategoryIds.Select(selectedCategoryId => new ProductCategories
            {
                ProductId = productEntity.Id,
                CategoryId = selectedCategoryId,                
            }).ToList();

            _context.ProductCategories.AddRange(productCategories);
            _context.SaveChanges();

            return RedirectToAction("Index", "Product");            
        }

        // GET: Product/id
        public ActionResult Edit(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if(product == null)
            {
                return RedirectToAction(nameof(New));
            }

            var categories = _context.Categories.ToList();
            var categoryItems = categories.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Name
            });

            var viewModel = new ProductViewModel
            {
                Product = product,
                Categories = categoryItems
            };

            return View("ProductForm", viewModel);
        }

        public ActionResult DeleteProduct(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            _context.Products.Remove(product);
            _context.SaveChanges();
            return RedirectToAction("Index", "InMemoryProduct");
        }
    }
}