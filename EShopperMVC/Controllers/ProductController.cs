using DAL.Entity;
using DAL.Operations;
using EShopperMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopperMVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult ProductDetail()
        {
            return Json(new { redirectToUrl = Url.Action("Index")});
        }
        public JsonResult Product(int _productId)
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
                Photo = i.Photo
            }
            ).ToList();

            var productInfos = productModel.Where(x => x.Id == _productId).Select(i => new ProductModel()
            {
                Id = i.Id,
                Name = i.Name,
                Description = i.Description,
                Price = i.Price,
                Stock = i.Stock,
                IsApproved = i.IsApproved,
                CategoryId = i.CategoryId,
                Photo = i.Photo
            });

            return Json(new {productInfos});
        }
    }
}
