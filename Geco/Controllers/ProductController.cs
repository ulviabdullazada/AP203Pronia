using Geco.DAL;
using Geco.Models;
using Geco.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

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
            //ViewBag.ProductCount = products.Count();
            return View();
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
        public IActionResult Cart() 
        {
            List<BasketVM> basket = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["Basket"]);
            List<CartVM> cart = new List<CartVM>();
            foreach (var item in basket)
            {
                Product dbProduct = _context.Products.Include(p => p.ProductImages).SingleOrDefault(p=>p.Id == item.ProductId);
                if (dbProduct == null) continue;
                cart.Add(new CartVM { 
                    ProductId = dbProduct.Id,
                    Count = item.Count,
                    ImageUrl= dbProduct.ProductImages.FirstOrDefault(p=>p.IsMain).Image,
                    Name = dbProduct.Name,
                    Price = dbProduct.Price,
                    IsActive = dbProduct.StockCount > item.Count ? true:false
                });
            }
            return View(cart);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Basket(int? id)
        {
            if (id == null) return BadRequest();
            Product dbProduct = _context.Products.Find(id);
            if (dbProduct == null) return NotFound();
            List<BasketVM> basketItems = new List<BasketVM>();
            BasketVM item = new BasketVM() {
                ProductId = dbProduct.Id,
                Count = 1
            };
            if (Request.Cookies["Basket"] != null)
            {
                basketItems = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);
            }
            if (basketItems.Find(bi => bi.ProductId == dbProduct.Id) == null)
            {
                basketItems.Add(item);
            }
            else
            {
                basketItems.Find(bi => bi.ProductId == dbProduct.Id).Count++;
            }
            Response.Cookies.Append("Basket",JsonConvert.SerializeObject(basketItems));
            return RedirectToAction(nameof(Index));
        }
        public IActionResult GetBasket()
        {
            return Json(JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]));
        }
        //public IActionResult GetSession()
        //{
        //    return Json(HttpContext.Session.GetString("name")+" "+Request.Cookies["surname"]);
        //}
    }
}
