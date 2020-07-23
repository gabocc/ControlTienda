

namespace WpfApp1.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Product
    {
        public int Id { set; get; }

        [MaxLength(25)]
        public string BarCode { set; get; }
        [MaxLength(150)]
        public string Name { set; get; }
        [DisplayFormat (DataFormatString ="{0:C2}",ApplyFormatInEditMode =false )]
        public decimal Preci { set; get; }
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Quantity { set; get; }
    }
}
