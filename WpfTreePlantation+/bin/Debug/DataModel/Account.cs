using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTreePlantation_
{
    public class Account
    {
        public int AccountID { get; set; }
        [MaxLength(1000)]
        [Required]
        public string Login { get; set; }
        [MaxLength(256)]
        public string Password { get; set; }
        //[MaxLength(256)]
        //[MaxLength(50)]
        public Account(string Login,string Password)
        {
            this.Login = Login;
            this.Password = Password;
        }
    }
}
