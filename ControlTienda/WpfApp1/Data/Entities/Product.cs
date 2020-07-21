using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Data.Entities
{
   public class Product
    {
        public int Id { set; get; }
        public string BarCode { set; get; }
        public string Name { set; get; }
        public decimal Preci { set; get; }
        public int stock { set; get; }
    }
}
