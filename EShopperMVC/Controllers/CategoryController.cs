using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShopperMVC.Controllers
{
    public class CategoryController : Controller
    {
        // GET: CategoryOp
        public ActionResult Index()
        {
            return View();
        }

        // GET: CategoryOp/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoryOp/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryOp/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryOp/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoryOp/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryOp/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoryOp/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public JsonResult CategoryFind()
        {
            //string returnUrl = "/Index";
            return Json(new { redirectToUrl = Url.Action("Index", "CategoryOp") });
        }
    }
}
