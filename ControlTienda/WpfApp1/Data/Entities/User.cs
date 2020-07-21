using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Data.Entities
{
   public class User
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int Direcction { set; get; }
        public string Phone { set; get; }
        public string Password { set; get; }
        public string Nick { set; get; }
    }
}
