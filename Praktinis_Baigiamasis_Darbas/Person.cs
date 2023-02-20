namespace Praktinis_Baigiamasis_Darbas
{
    public class Person
    {
        public int Id { get; set; }
        public int Loc_Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PersonalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Person(int id, int loc_Id, string name, string surname, string personalCode, string phoneNumber, string email)
        {
            Id = id;
            Loc_Id = loc_Id;
            Name = name;
            Surname = surname;
            PersonalCode = personalCode;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
