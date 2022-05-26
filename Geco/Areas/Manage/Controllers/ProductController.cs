using Geco.DAL;
using Geco.Models;
using Geco.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Geco.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class ProductController : Controller
    {
        private AppDbContext _context { get; }
        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        // GET: ProductController
        public async Task<ActionResult> Index()
        {
            List<Product> products = await _context.Products.Include(p=>p.Category).ToListAsync();
            return View(products);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            //ProductCategoryVM pcvm = new ProductCategoryVM();
            //pcvm.Categories = _context.Categories.ToList();
            //return View(pcvm);
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Product product)
        {
            if (!ModelState.IsValid) {
                ViewBag.Categories = _context.Categories.ToList();
                return View();
            }
            if (_context.Products.Any(p=>p.Name == product.Name))
            {
                ModelState.AddModelError("Name","This name already exist");
                ViewBag.Categories = _context.Categories.ToList();
                return View();
            }
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
