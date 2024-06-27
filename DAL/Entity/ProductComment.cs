using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class ProductComment : BaseEntity
    {
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public int Rate { get; set; }
        public string Comment { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public DateTime CommendDate { get; set; }
        public bool IsNameShow { get; set; }
    }
}
