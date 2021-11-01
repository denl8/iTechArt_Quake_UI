using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iTechArt_Quake_UI.Data.Models
{
    public class Account
    {
        public int Id { set; get; }
        public string Nickname { set; get; }
        public string Email { set; get; }
        public string PhoneNumber { set; get; }
        public string Password { set; get; }
        public bool IsAdmin { set; get; }
    }
}
