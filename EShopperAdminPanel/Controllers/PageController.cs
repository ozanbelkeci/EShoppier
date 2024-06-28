using Microsoft.AspNetCore.Mvc;

namespace EShopperAdminPanel.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
