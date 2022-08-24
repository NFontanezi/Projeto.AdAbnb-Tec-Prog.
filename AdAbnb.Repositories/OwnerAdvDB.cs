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
        //public static string ToString1(Person usuario)
        //{
        //    return $@"Número de registro: {usuario.Registration}
        //    Nome: {usuario.Name}
        //    CPF: {usuario.CPF}
        //    Telefone: {usuario.Phone}   
        //    Data de nascimento: {usuario.DateBirth}
        //    Gênero: {usuario.Gender}";
        //}

        public static List<Property> ownerPropAdv = new();


    }
}

