namespace Praktinis_Baigiamasis_Darbas
{
    public class AllUserData
    {
        public List<User> Users { get; set; }
        public List<Person> Persons { get; set; }
        public List<Location> Locations { get; set; }

        public AllUserData(List<User> users, List<Person> persons, List<Location> locations)
        {
            Users = users;
            Persons = persons;
            Locations = locations;
        }
    }
}
