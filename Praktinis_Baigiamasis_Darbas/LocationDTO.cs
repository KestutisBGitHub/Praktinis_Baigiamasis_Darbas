namespace Praktinis_Baigiamasis_Darbas
{
    public class LocationDTO
    {


        public string City { get; set; }
        //[Required(ErrorMessage = "* Required Street")]
        public string Street { get; set; }
        //[Required(ErrorMessage = "* Required HouseNr")]
        public string HouseNr { get; set; }
        //[Required(ErrorMessage = "* Required AppartmentNr")]
        public string AppartmentNr { get; set; }
        public List<PersonDTO> Persons { get; private set; }

        public LocationDTO(string city, string street, string houseNr, string appartmentNr)
        {
            
            City = city;
            Street = street;
            HouseNr = houseNr;
            AppartmentNr = appartmentNr;
            Persons = new List<PersonDTO>();
        }
    }
}
