using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Data.Entities
{
   public class Purchase
    {
        public int Id { set; get; }
        public string Date_and_time { set; get; }
        public string Description { set; get; }
        public int Amount { set; get; }
        public int Stock { set; get; }
    }
}
