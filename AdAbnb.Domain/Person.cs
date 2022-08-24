namespace AdAbnb.Domain
{
    public class Person
    {
        public Registration Registration { get; set; }  
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime DateBirth { get; set; }
        public char Gender { get; set; }

        public static Dictionary<Person,Registration> UserList { get; set; } = new();

        public List<Property> usersPropRented { get; set; } = new();

        public Person(Registration registration, string cPF, string name, string phone, DateTime dateBirth, char gender)
        {
            Registration = registration;
            CPF = cPF;
            Name = name;
            Phone = phone;
            DateBirth = dateBirth;
            Gender = gender;
        }


    }
}
