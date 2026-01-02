using System.Web.Mvc;
using fruitables_1_0_0.Models;
using System.Collections.Generic;

namespace fruitables_1_0_0.Controllers
{
    public class BasketController : Controller
    {
        // Demo səbət
        private static Basket basket = new Basket();

        public ActionResult Index()
        {
            return View(basket);
        }

        public ActionResult Add(int productId)
        {
            // Demo məhsul əlavə et
            basket.Products.Add(new Product { Id = productId, Name = "Alma", Description = "Təzə alma", Price = 1.2M, ImageUrl = "/img/apple.jpg" });
            return RedirectToAction("Index");
        }
    }
}