using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using fruitables_1_0_0.Models;

namespace fruitables_1_0_0.Controllers.Admin
{
    public class CategoryController : Controller
    {
        private static List<Category> categories = new List<Category>();

        public ActionResult Index()
        {
            return View(categories);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            category.Id = categories.Count + 1;
            categories.Add(category);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var category = categories.FirstOrDefault(x => x.Id == id);
            return View(category);
        }

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            var c = categories.FirstOrDefault(x => x.Id == category.Id);
            if (c != null)
            {
                c.Name = category.Name;
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var category = categories.FirstOrDefault(x => x.Id == id);
            if (category != null)
                categories.Remove(category);
            return RedirectToAction("Index");
        }
    }
}