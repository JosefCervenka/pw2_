using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Pleasure.Data.LoginAndRegister
{
    public class Login
    {
        public string UserNameOrEmail { get; set; }

        public string Password { get; set; }
    }
}
