using System.Collections.Generic;

namespace EShopperMVC.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<ProductModel> Products { get; set; }
    }
}
