using AdAbnb.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdAbnb.Repositories
{
    public static class OwnerAdvDB
    {

        public static Dictionary<string, string> usersAdvDic = new(); // chave = email, valor = senha

        public static List<Owner> ownerAdvInfos = new();

        public static List<Property> ownerPropAdv = new();


    }
}

