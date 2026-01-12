using Fiorello.Data;
using Fiorello.Models;
using Fiorello.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fiorello.Controllers
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
    HomeVM homeVM = new()
    {
        Sliders = await _context.Sliders.ToListAsync(),
        SliderDetail = await _context.SlidersDetails.FirstOrDefaultAsync() ?? new SliderDetail(),
        Products = await _context.Products
            .Include(p => p.ProductImages)
            .Take(4)
            .ToListAsync(),
        Categories = await _context.Categories.ToListAsync()
    };

    ViewBag.ProductCount = await _context.Products.CountAsync();
    return View(homeVM);
}

        public async Task<IActionResult> LoadMore(int skip)
        {
            var products = await _context.Products.Include(p => p.ProductImages).Skip(skip).Take(4).ToListAsync();
            return PartialView("_ProductPartial", products);
        }
      

    }
}
