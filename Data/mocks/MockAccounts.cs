using iTechArt_Quake_UI.Data.Models;
using iTechArt_Quake_UI.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iTechArt_Quake_UI.Data.mocks
{
    public class MockAccounts : IAccounts { 
            public IEnumerable<Account> AllAccounts { 
                get{
                    return new List<Account> {
                        new Account { 
                            Email = "gtj550@gmail.com",
                            Id = 1,
                            IsAdmin = true,
                            Nickname = "denl8",
                            Password = "",
                            PhoneNumber = "" 
                        },
                        new Account {
                            Email = "kodaf@gmail.com",
                            Id = 2, IsAdmin = false,
                            Nickname = "k0daf",
                            Password = "",
                            PhoneNumber = "" 
                        },
                        new Account {
                            Email = "libidodo@gmail.com",
                            Id = 3, IsAdmin = false,
                            Nickname = "libidodo",
                            Password = "",
                            PhoneNumber = "" 
                        },
                        new Account {
                            Email = "evge489@gmail.com",
                            Id = 4,
                            IsAdmin = false,
                            Nickname = "evge489",
                            Password = "", 
                            PhoneNumber = "" 
                        }
                    };

                }
            }
    }
}
