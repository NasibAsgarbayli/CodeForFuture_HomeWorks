using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using fruitables_1_0_0.Models;

namespace fruitables_1_0_0.Controllers.Admin
{
    public class ProductController : Controller
    {
        private static List<Product> products = new List<Product>();
        private static List<Category> categories = new List<Category>();
        private static List<ProductImage> images = new List<ProductImage>();

        public ActionResult Index()
        {
            return View(products);
        }

        public ActionResult Create()
        {
            ViewBag.Categories = categories;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            product.Id = products.Count + 1;
            products.Add(product);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            ViewBag.Categories = categories;
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            var p = products.FirstOrDefault(x => x.Id == product.Id);
            if (p != null)
            {
                p.Name = product.Name;
                p.Description = product.Description;
                p.Price = product.Price;
                p.ImageUrl = product.ImageUrl;
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            if (product != null)
                products.Remove(product);
            return RedirectToAction("Index");
        }
    }
}