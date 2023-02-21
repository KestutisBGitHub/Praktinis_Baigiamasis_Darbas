using System.ComponentModel.DataAnnotations;

namespace Praktinis_Baigiamasis_Darbas
{
    public class Location
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "* Required")]
        public string City { get; set; }
        [Required(ErrorMessage = "* Required")]
        public string Street { get; set; }
        [Required(ErrorMessage = "* Required")]
        public int HouseNr { get; set; }
        [Required(ErrorMessage = "* Required")]
        public int AppartmentNr { get; set; }
        
        public List<Person> Persons { get; set; }

        public Location(int id, string city, string street, int houseNr, int appartmentNr)
        {
            Id = id;
            City = city;
            Street = street;
            HouseNr = houseNr;
            AppartmentNr = appartmentNr;
            Persons = new List<Person>();
        }
    }
}
