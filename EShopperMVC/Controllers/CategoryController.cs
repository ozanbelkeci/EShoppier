using DAL.Entity;
using EShopperMVC.Models;
using DAL.Operations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopperMVC.Controllers
{
    public class CategoryController : Controller
    {
        // GET: CategoryOp

        public ActionResult Index(int _categoryId)
        {
            GenericRepository<Product> repository = new GenericRepository<Product>();

            var AllProducts = repository.GetList();

            List<ProductModel> productModel = AllProducts.Select(i => new ProductModel()
            {
                Id = i.Id,
                Name = i.Name,
                Description = i.Description,
                Price = i.Price,
                Stock = i.Stock,
                IsApproved = i.IsApproved,
                CategoryId = i.CategoryId,
                Photo = i.Photo,
            }
            ).ToList();

            var products = productModel.Where(x => x.CategoryId == _categoryId).Select(i => new ProductModel()
            {
                Id = i.Id,
                Name = i.Name,
                Description = i.Description,
                Price = i.Price,
                Stock = i.Stock,
                IsApproved = i.IsApproved,
                CategoryId = i.CategoryId,
                Photo = i.Photo,
            });

            return View(products);
        }

        public async Task<JsonResult> Products(int _categoryId)
        {
            GenericRepository<Product> repository = new GenericRepository<Product>();

            var AllProducts = repository.GetList();

            List<ProductModel> productModel = AllProducts.Select(i => new ProductModel()
            {
                Id = i.Id,
                Name = i.Name,
                Description = i.Description,
                Price = i.Price,
                Stock = i.Stock,
                IsApproved = i.IsApproved,
                CategoryId = i.CategoryId,
                Photo = i.Photo,
            }
            ).ToList();

            var products = productModel.Where(x => x.CategoryId == _categoryId).Select(i => new ProductModel()
            {
                Id = i.Id,
                Name = i.Name,
                Description = i.Description,
                Price = i.Price,
                Stock = i.Stock,
                IsApproved = i.IsApproved,
                CategoryId = i.CategoryId,
                Photo = i.Photo,
            });

            return Json(products);
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
        public JsonResult CategoryFind(string categoryTitle)
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

            var categoryInfos = categoryModel.Where(x => x.Name == categoryTitle).Select(i => new CategoryModel()
            {
                Id = i.Id,
                Name = i.Name,
                Description = i.Description
            });
            
            //string returnUrl = "/Index";
            return Json(new { redirectToUrl = Url.Action("Index"), categoryInfos });
        }
    }
}
