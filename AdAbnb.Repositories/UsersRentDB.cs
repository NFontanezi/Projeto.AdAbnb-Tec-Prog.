using System;
using System.Collections.Generic;
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
        //public static string ToString1(Person usuario)
        //{
        //    return $@"Número de registro: {usuario.Registration}
        //    Nome: {usuario.Name}
        //    CPF: {usuario.CPF}
        //    Telefone: {usuario.Phone}   
        //    Data de nascimento: {usuario.DateBirth}
        //    Gênero: {usuario.Gender}";
        //}

    }
}
