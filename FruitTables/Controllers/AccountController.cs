using System.Web.Mvc;
using fruitables_1_0_0.Models;

namespace fruitables_1_0_0.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}