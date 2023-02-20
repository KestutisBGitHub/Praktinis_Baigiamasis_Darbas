namespace Praktinis_Baigiamasis_Darbas
{
    public class Location
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNr { get; set; }
        public int AppartmentNr { get; set; }

        public Location(int id, string city, string street, int houseNr, int appartmentNr)
        {
            Id = id;
            City = city;
            Street = street;
            HouseNr = houseNr;
            AppartmentNr = appartmentNr;
        }
    }
}
