using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string LoginName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string IsActive{ get; set; }
        public string Photo { get; set; }
        public string Language { get; set; }
    }
}
