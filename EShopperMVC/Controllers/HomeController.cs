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
        public IActionResult CreateLandingPage(string viewName)
        {
            var cshtmlcontent = @"@{Layout = ""~/Views/Shared/_Layout.cshtml"";ViewData[""Title""] = ""Page Title"";}
            <table class=""table table table-bordered"">
                <thead>
                    <tr>
                        <th>Book Id
                        <th>Title
                        <th>Description
                        <th>Author Name
                    </tr>
                </thead>
                <tbody>
                    @foreach (var item in Model)
                    {
                        <tr>
                            <td>@item.Id</td>
                            <td>@item.Title</td>
                            <td>@item.Description</td>
                            <td>@item.Author?.Name</td>
                        </tr>
                    }
                </tbody>
            </table>";
            System.IO.File.WriteAllText(@"EShoppier\EShopperMVC\Views\Home\"+viewName+".cshtml", cshtmlcontent);
            return Json(new { redirectToUrl = Url.Action(viewName) });
        }
        public IActionResult HandleCshtml(string file = "Index")
        {
            return View("Views/Home/"+file+".cshtml");
        }
        
    }
}
