using DAL.Entity;
using DAL.Operations;
using EShopperAdminPanel.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EShopperAdminPanel.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Index()
        {
            GenericRepository<Page> repository = new GenericRepository<Page>();

            var products = repository.GetList();

            List<PageModel> pageModel = products.Select(i => new PageModel()
            {
                Name = i.Name,
                Description = i.Description,
                PageHtml = i.PageHtml
            }).ToList();
            return View(pageModel);
        }

        public IActionResult CreatePage(string _pageName, string _desc, string _pageHtml)
        {
            string envStr = System.IO.Directory.GetCurrentDirectory();
            string prjStr = Directory.GetParent(envStr).FullName;

            var cshtmlcontent = @"@{Layout = ""~/Views/Shared/_Layout.cshtml"";ViewData[""{0}""] = ""Page Title"";} " + _pageHtml;
            System.IO.File.WriteAllText(prjStr + @"\EShopperMVC\Views\Home\" + _pageName + ".cshtml", cshtmlcontent);

            var page = new Page();
            page.Name = _pageName;
            page.Description = _desc;
            page.PageHtml = _pageHtml;
            GenericRepository<Page> repository = new GenericRepository<Page>();
            var result = repository.Create(page);

            var pageModel = new PageModel()
            {
                Id = result.Id,
                Name= result.Name,
                Description= result.Description,
                PageHtml = result.PageHtml
            };

            return Json(pageModel);
        }
    }
}
