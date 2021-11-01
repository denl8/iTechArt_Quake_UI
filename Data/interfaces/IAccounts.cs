using iTechArt_Quake_UI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iTechArt_Quake_UI.Data.interfaces
{
    public interface IAccounts
    {
        IEnumerable<Account> AllAccounts { get; }
    }
}
