using System.Collections.Generic;
using System.Web.Mvc;
using fruitables_1_0_0.Models;

namespace fruitables_1_0_0.Controllers
{
    public class ShopController : Controller
    {
        public ActionResult Index()
        {
            // Demo məhsullar
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Alma", Description = "Təzə alma", Price = 1.2M, ImageUrl = "/img/apple.jpg" },
                new Product { Id = 2, Name = "Armud", Description = "Şirin armud", Price = 1.5M, ImageUrl = "/img/pear.jpg" }
            };
            return View(products);
        }

        public ActionResult Detail(int id)
        {
            // Demo məhsul tapılması
            var product = new Product { Id = id, Name = "Alma", Description = "Təzə alma", Price = 1.2M, ImageUrl = "/img/apple.jpg" };
            return View(product);
        }
    }
}