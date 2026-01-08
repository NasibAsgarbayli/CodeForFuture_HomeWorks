
using FruitTable.Data;
using FruitTables.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace FruitTables.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var vm = new HomeVM
            {
                Categories = await _context.Categories.ToListAsync(),
                Products = await _context.Products.Include(p => p.Category).ToListAsync()
            };

            return View(vm);
        }

    }
}
