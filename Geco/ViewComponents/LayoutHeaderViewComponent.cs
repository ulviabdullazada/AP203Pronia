using Geco.DAL;
using Geco.Models;
using Geco.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Geco.ViewComponents
{
    public class LayoutHeaderViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _accessor;
        public LayoutHeaderViewComponent(AppDbContext context, IHttpContextAccessor accessor)
        {
            _context = context;
            _accessor = accessor;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            string basketString = _accessor.HttpContext.Request.Cookies["Basket"];
            List<BasketVM> basket = new List<BasketVM>();
            List<CartVM> basketItems = new List<CartVM>();
            if (basketString != null)
            {
                basket = JsonConvert.DeserializeObject<List<BasketVM>>(basketString);
            }
            foreach (BasketVM item in basket)
            {
                Product product = await _context.Products.Include(p=>p.ProductImages).SingleOrDefaultAsync(p=> p.Id == item.ProductId);
                if (product == null) continue;
                CartVM basketItem = new CartVM
                {
                    Name = product.Name,
                    ImageUrl = product.ProductImages.FirstOrDefault(pi=>pi.IsMain).Image,
                    Price = product.Price,
                    Count = item.Count,
                    IsActive = product.StockCount > item.Count? true:false
                };
                basketItems.Add(basketItem);
            }
            return View(await Task.FromResult(basketItems));
        }
    }
}
