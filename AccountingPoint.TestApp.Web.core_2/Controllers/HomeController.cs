using Microsoft.AspNetCore.Mvc;

namespace AccountingPoint.TestApp.Web.core_2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
