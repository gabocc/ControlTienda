

namespace WpfApp1.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Login
    {
        public int Id { set; get; }
        public DateTime? Date_and_time_and_Entry { set; get; }
        public DateTime? Date_and_time_and_Exit { set; get; }
        [MaxLength(250)]
        public string Observation { set; get; }
    }
}
