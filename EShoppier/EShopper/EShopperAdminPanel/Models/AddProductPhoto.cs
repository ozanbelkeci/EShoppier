using Microsoft.AspNetCore.Http;

namespace EShopperAdminPanel.Models
{
    public class AddProductPhoto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public bool IsApproved { get; set; }
        public IFormFile Photo { get; set; }
        public int CategoryId { get; set; }
    }
}
