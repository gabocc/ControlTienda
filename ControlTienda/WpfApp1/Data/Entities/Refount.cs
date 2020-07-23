
namespace WpfApp1.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Refount
    {
        public int Id { set; get; }
        [MaxLength(250)]
        public string Observation { set; get; }
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public int Quantity { set; get; }
    }
}
