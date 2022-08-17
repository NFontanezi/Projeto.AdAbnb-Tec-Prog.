namespace AdAbnb.Domain
{
    public class Person
    {
        public Registration Registration { get; set; }  
        public string CPF { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateBirth { get; set; }
        public char Gender { get; set; }
       
    }
}
