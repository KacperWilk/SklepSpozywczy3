using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Net;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Microsoft.Ajax.Utilities;
using SklepSpozywczy3.Models;
using SklepSpozywczy3.ViewModels;

namespace SklepSpozywczy3.Controllers
{
    
    public class ProductsController : Controller
    {
        private ApplicationDbContext _context;

        public ProductsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            var categoryTypes = _context.CategoryTypes.ToList();
            var viewModel = new ProductFormViewModel()
            {
                CategoryTypes = categoryTypes
            };
            return View("ProductForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Product product)
        {
            var categoryTypes = _context.CategoryTypes.ToList();
            var viewModel = new ProductFormViewModel(product)
            {
                CategoryTypes = categoryTypes
            };
            if (product.Id == 0)
            {
                _context.Products.Add(product);
            }
            else
            {
                var productInDb = _context.Products.Single(p => p.Id == product.Id);

                productInDb.Name = product.Name;
                productInDb.Description = product.Description;
                productInDb.Quantity = product.Quantity;
                productInDb.CategoryTypeId = product.CategoryTypeId;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Products");
        }

        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            var product = _context.Products.Include(p => p.CategoryType).FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        public ActionResult Edit(int id)
        {
            var product = _context.Products.SingleOrDefault(p => p.Id == id);

            if (product == null)
            {
                return HttpNotFound();
            }

            var viewModel = new ProductFormViewModel(product)
            {
                CategoryTypes = _context.CategoryTypes.ToList()
            };


            return View("ProductForm", viewModel);
        }
    }
}