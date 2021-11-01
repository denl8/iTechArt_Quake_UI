using iTechArt_Quake_UI.Data.interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iTechArt_Quake_UI.Controllers
{
    public class AccountsController : Controller {
        private readonly IAccounts _allAccounts;
        public AccountsController(IAccounts iAllAccounts){
            _allAccounts = iAllAccounts;
        }

        public ViewResult List() {
            var accounts = _allAccounts.AllAccounts;
            return View();
        }
    }
}
