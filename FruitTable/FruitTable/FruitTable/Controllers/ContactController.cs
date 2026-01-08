using Microsoft.AspNetCore.Mvc;

namespace FruitTables.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
