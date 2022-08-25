namespace AdAbnb;
using AdAbnb.Domain;
using AdAbnb.Repositories;
using System.Globalization;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        //Registration regNatC = new("natalia@campos", "123");
        //string dateSnatC = "10/05/2001";
        //DateTime birthNatC = DateTime.ParseExact(dateSnatC, "d", new CultureInfo("pt-BR"));
        //Person nataliaC = new Person(regNatC, "12345678910", "Natália Campos", "12987654321", birthNatC, 'F');


        //Registration regNatF = new("natalia@fontanezi", "123");
        //string dateSnatF = "18/09/1988";
        //DateTime birthNatF = DateTime.ParseExact(dateSnatF, "d", new CultureInfo("pt-BR"));
        //Person nataliaF = new Person(regNatF, "12345678910", "Natália Fontanezi", "11987654321", birthNatF, 'F');


        //UsersRentDB.usersRentDic.Add(regNatC.Login, regNatC.Password);
        //UsersRentDB.usersRentDic.Add(regNatF.Login, regNatF.Password);

        //UsersRentDB.usersRentInfos.Add(nataliaC);
        //UsersRentDB.usersRentInfos.Add(nataliaF);

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new frmMain());


    }
}
