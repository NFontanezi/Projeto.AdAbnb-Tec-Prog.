using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdAbnb.Domain;

namespace AdAbnb.Repositories
{
    public static class UsersRentDB
    {

        public static Dictionary<string, string> usersRentDic = new(); // chave = email, valor = senha

        public static List<Person> usersRentInfos = new();

    }
}
