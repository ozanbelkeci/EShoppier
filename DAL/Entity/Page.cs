using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Page : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public string PageHtml { get; set; }
        public int Test { get; set; }
    }
}
