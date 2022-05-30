using Geco.DAL;
using Geco.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Geco.Controllers
{
    public class ProductController : Controller
    {
        private AppDbContext _context { get; }
        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IQueryable <Product> products = _context.Products.Where(p => p.IsDeleted == false).AsQueryable();
            ViewBag.ProductCount = products.Count();
            return View(products.Take(8).Include(p=>p.ProductImages).Include(p=>p.Category));
        }
        public IActionResult LoadMore(int skip)
        {
            if (_context.Products.Where(p => p.IsDeleted == false).Count() <= skip)
            {
                return Json(new {
                    message="agilli ol"
                });
            }
            return PartialView("_ProductPartial",_context.Products
                                                .Where(p => p.IsDeleted == false)
                                                .OrderByDescending(p=>p.Id)
                                                .Skip(skip).Take(8)
                                                .Include(p => p.ProductImages)
                                                .Include(p => p.Category));
        }
    }
}
