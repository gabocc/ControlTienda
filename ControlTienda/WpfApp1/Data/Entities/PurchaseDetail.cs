

namespace WpfApp1.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class PurchaseDetail
    {
        public int Id { set; get; }
        public DateTime? Date_and_time { set; get; }
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public int Unit_amount { set; get; }
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public int Total_amount { set; get; }
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public int Quantity { set; get; }
    }
}
