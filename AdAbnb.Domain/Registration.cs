using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdAbnb.Domain
{
    public class Registration
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public Registration(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }


}
