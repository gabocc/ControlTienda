using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Data.Entities
{
   public class Box
    {
        public int Id { set; get; }
        public string Date { set; get; }
        public int Starting_amount { set; get; }
        public int Total_amount { set; get; }
        public string Observation { set; get; }
    }
}
