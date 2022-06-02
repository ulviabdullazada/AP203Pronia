using Geco.DAL;
using Geco.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Geco.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class ColorController : Controller
    {
        private AppDbContext _context { get; }

        public ColorController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Colors);
        }
        public IActionResult Create(Color color)
        {
            if (_context.Colors.SingleOrDefault(c => c.Name == color.Name) != null) return RedirectToAction(nameof(Index));
            _context.Colors.Add(color);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
