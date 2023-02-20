using System.ComponentModel.DataAnnotations.Schema;

namespace Praktinis_Baigiamasis_Darbas
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PersonalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<User> Users { get; set; }

        [ForeignKey("Location")]
        public int? LocationID { get; set; }
        public Location? Location { get; set; }

        public Person(int id, string name, string surname, string personalCode, string phoneNumber, string email)
        {
            Id = id;
            Name = name;
            Surname = surname;
            PersonalCode = personalCode;
            PhoneNumber = phoneNumber;
            Email = email;
            Users = new List<User>();
            
        }
    }
}
