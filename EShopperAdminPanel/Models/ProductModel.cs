namespace EShopperAdminPanel.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DescriptionSecond { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public bool IsApproved { get; set; }
        public string Photo { get; set; }
        public CategoryModel Category { get; set; }
        public int CategoryId { get; set; }
    }
}
