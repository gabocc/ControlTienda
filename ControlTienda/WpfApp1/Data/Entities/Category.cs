

namespace WpfApp1.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Category
    {
        public int Id { set; get; }
        [MaxLength (30)]
        public string Name { set; get; }
        [MaxLength (250)]
        public string Description { set; get; }

    }
}
