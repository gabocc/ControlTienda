using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Data.Entities
{
   public class CashFlow
    {
        public int Id { set; get; }
        public string Date_and_time { set; get; }
        public int Income_amount { set; get; }
        public int Return_amount { set; get; }
    }
}
