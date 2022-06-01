using Geco.DAL;
using Geco.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Geco.ViewComponents
{
    public class ProductViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        public ProductViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int take=4,int skip=0)
        {
            List<Product> products = await _context.Products
                                        .Where(p=>p.IsDeleted==false)
                                        .Skip(skip)
                                        .Take(take)
                                        .Include(p=>p.ProductImages)
                                        .ToListAsync();
            return View(await Task.FromResult(products));
        }
    }
}
