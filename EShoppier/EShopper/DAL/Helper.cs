using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Helper
    {
        public static string GetConnectionString()
        {
            //return "Data Source=(localdb)\\Anil;Initial Catalog=EShoppier;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            return "Server=(localdb)\\Anil;Database=EShoppier;Trusted_Connection=True;";
        }
    }
}
