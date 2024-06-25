using DAL.Entity;
using DAL.Operations;
using EShopperMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EShopperMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }
        public JsonResult Categories()
        {

            GenericRepository<Category> repository = new GenericRepository<Category>();

            var categories = repository.GetList();

            List<CategoryModel> categoryModel = categories.Select(i => new CategoryModel()
            {
                Id = i.Id,
                Name = i.Name,
                Description = i.Description
            }
            ).ToList();


            return Json(categoryModel);
        }
        public ActionResult CategoryFind()
        {
            //string returnUrl = "/Index";
            //return RedirectToAction("Index", "CategoryOp");
            return RedirectToAction("Category");
        }
    }
}
