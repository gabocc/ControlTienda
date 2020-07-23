

namespace WpfApp1.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Rol
    {
        public int Id { set; get; }
        [MaxLength(25)]
        public string Name { set; get; }
        [MaxLength(250)]
        public string Description { set; get; }
    }
}
