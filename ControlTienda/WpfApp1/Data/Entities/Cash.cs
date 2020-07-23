

namespace WpfApp1.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Cash
    {
        public int Id { set; get; }
        public DateTime? Date { set; get; }
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public int Starting_amount { set; get; }
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public int Total_amount { set; get; }
        [MaxLength(250)]
        public string Observation { set; get; }
    }
}
