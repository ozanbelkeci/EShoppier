using DAL.Entity;
using DAL.Operations;
using EShopperMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
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
            Response.Cookies.Delete("Categories");
            GenericRepository<Category> repository = new GenericRepository<Category>();

            var categories = repository.GetList();

            List<CategoryModel> categoryModel = categories.Select(i => new CategoryModel()
            {
                Id = i.Id,
                Name = i.Name,
                Description = i.Description
            }
            ).ToList();

            CookieOptions option = new CookieOptions();
            int expireTime = 20;
            if (expireTime != 0)
            {
                option.Expires = DateTime.Now.AddMinutes(20);
            }
            else
            {
                option.Expires = DateTime.Now.AddMinutes(80);
            }
            string json = JsonConvert.SerializeObject(categoryModel);
            Response.Cookies.Append("Categories", json.ToString(), option);
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
                                    <div id=""pageBody""></div>
                                 ";
            System.IO.File.WriteAllText(@"EShoppier\EShopperMVC\Views\Home\"+viewName+".cshtml", cshtmlcontent);
            return Json(new { redirectToUrl = Url.Action(viewName) });
        }
        public IActionResult HandleCshtml(string file = "Index")
        {
            return View("Views/Home/"+file+".cshtml");
        }
        
    }
}
