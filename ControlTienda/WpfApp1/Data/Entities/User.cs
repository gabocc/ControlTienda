

namespace WpfApp1.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class User
    {
        public int Id { set; get; }
        [MaxLength(50)]
        public string Name { set; get; }
        [MaxLength(100)]
        public int Address { set; get; }
        [MaxLength(25)]
        public string Phone { set; get; }
        [ConcurrencyCheck,MinLength(8,ErrorMessage = "password error missing fill 8 characters"),MaxLength(15,ErrorMessage = "error password exceeds 15 characters")]
        public string Password { set; get; }
        [ConcurrencyCheck,MinLength(6,ErrorMessage ="At lees need 6 characters "),MaxLength(8,ErrorMessage = "exceeds 8 characters try again")]
        public string Nickname { set; get; }
    }
}
