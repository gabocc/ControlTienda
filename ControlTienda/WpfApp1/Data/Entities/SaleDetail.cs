using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Data.Entities
{
   public class SaleDetail
    {
        public int Id { set; get; }
        public string Date_and_time { set; get; }
        public int Unit_amount { set; get; }
        public int Total_amount { set; get; }
        public int Stock { set; get; }
    }
}
