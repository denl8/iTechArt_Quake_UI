using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iTechArt_Quake_UI.Data.Models
{
    public class Player
    {
        public int Id { set; get; }
        public string Nickname { set; get; }
        public List<Account> Accounts { set; get; }
    }
}
