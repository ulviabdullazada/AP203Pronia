using Geco.DAL;
using Geco.Models;
using Geco.Utilies;
using Geco.Utilies.File;
using Geco.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
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
            List<Product> products = await _context.Products.Include(p=>p.Category).Include(p=>p.ProductImages).ToListAsync();
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
            ViewBag.Categories = _context.Categories.ToList();
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (_context.Products.Any(p=>p.Name == product.Name))
            {
                ModelState.AddModelError("Name","This name already exist");
                return View();
            }
            if (IsPhotoOk(product.Photos) != "")
            {
                ModelState.AddModelError("Photos", IsPhotoOk(product.Photos));
                return View();
            }
            product.ProductImages = new List<ProductImage>();
            foreach (var photo in product.Photos)
            {
                ProductImage image = new ProductImage
                {
                    Image = await photo.SaveFileAsync(Path.Combine(Constant.ImageUrl, "product")),
                    IsMain= false,
                    Product = product
                };
                product.ProductImages.Add(image);
            }
            if (product.MainPhoto.CheckSize(200))
            {
                ModelState.AddModelError("Photos", "Main photo size must be less than 200kb");
                return View();
            }
            if (!product.MainPhoto.CheckType("image/"))
            {
                ModelState.AddModelError("Photos", "Main photo file type is not image");
                return View();
            }
            product.ProductImages.Add(new ProductImage { 
                Image = await product.MainPhoto.SaveFileAsync(Path.Combine(Constant.ImageUrl, "product")),
                IsMain = true,
                Product = product
            });
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Edit(int id)
        {
            Product product = _context.Products.Include(p => p.Category).Include(p => p.ProductImages).SingleOrDefault(p => p.Id == id);
            ViewBag.Categories = _context.Categories.ToList();
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Product product)
        {
            if (id != product.Id) return BadRequest();
            Product prd = _context.Products.SingleOrDefault(p=>p.Id == id);
            if (prd == null) return NotFound();
            List<ProductImage> productImages = _context.ProductImages.Where(pi => pi.ProductId == id).ToList();
            List<int> dltImg = new List<int>();
            foreach (var item in productImages)
            {
                bool isEqual = false;
                foreach (var iid in product.ImageIds)
                {
                    if (item.Id == iid)
                    {
                        isEqual = true;
                        break;
                    }
                }
                if (isEqual == false)
                {
                    dltImg.Add(item.Id);
                }
            }
            foreach (int imgId in dltImg)
            {
                FileExtension.DeleteFile(Path.Combine(Constant.ImageUrl, "product", productImages.Find(pi => pi.Id == imgId).Image));
                productImages.Remove(productImages.Find(pi => pi.Id == imgId));
            }
            if (product.Photos != null)
            {
                if (IsPhotoOk(product.Photos) != "")
                {
                    ModelState.AddModelError("Photos", IsPhotoOk(product.Photos));
                    return View();
                }
                foreach (var photo in product.Photos)
                {
                    ProductImage image = new ProductImage
                    {
                        Image = await photo.SaveFileAsync(Path.Combine(Constant.ImageUrl, "product")),
                        IsMain = false,
                        Product = prd
                    };
                    productImages.Add(image);
                }
            }
            prd.Name = product.Name;
            prd.Price = product.Price;
            prd.Raiting = product.Raiting;
            prd.StockCount = product.StockCount;
            prd.Description = product.Description;
            prd.ProductImages = productImages;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
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

        private string IsPhotoOk(IFormFileCollection photos)
        {
            foreach (var photo in photos)
            {
                if (photo.CheckSize(200))
                {
                    return $"{photo.FileName} size must be less than 200kb";
                }
                if (!photo.CheckType("image/"))
                {
                    return $"{photo.FileName} type is not image";
                }
            }
            return "";
        }
    }
}
