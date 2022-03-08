using SanaDotnetAssessment.Web.Core.Domain;
using SanaDotnetAssessment.Web.InMemory;
using SanaDotnetAssessment.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SanaDotnetAssessment.Web.Controllers
{
    public class InMemoryProductController : Controller
    {
        InMemoryData _context = new InMemoryData();
        public ActionResult Index()
        {
            var products = InMemoryData.products;
            return View(products);
        }

        public ActionResult New()
        {
            var categories = _context.ListOfCategories;
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

            return View("ProductForm", viewModel);
        }

        [HttpPost]
        public ActionResult CreateProduct(ProductViewModel criteria)
        {
            if (!ModelState.IsValid)
            {
                return View("ProductForm", criteria);
            }

            var productEntity = new Product
            {
                Id = InMemoryData.products.Count+1,
                ProductName = criteria.Product.ProductName,
                Price = criteria.Product.Price
            };

            InMemoryData.products.Add(productEntity);

            var productCategories = criteria.SelectedCategoryIds.Select(selectedCategoryId => new ProductCategories
            {
                ProductCategoryId = _context.productCategories.Count + 1,
                ProductId = productEntity.Id,
                CategoryId = selectedCategoryId
            }).ToList();

            foreach (var item in productCategories)
            {
                _context.productCategories.Add(item);
            }

            return RedirectToAction("Index", "InMemoryProduct");
        }

        public ActionResult DeleteProduct(int id)
        {
            var product = InMemoryData.products.FirstOrDefault(p => p.Id == id);
            InMemoryData.products.Remove(product);
            return RedirectToAction("Index", "InMemoryProduct");
        }
    }
}