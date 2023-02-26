namespace Praktinis_Baigiamasis_Darbas.Services
{
    public interface IRepository
    {

        public List<User> GetAll();

        public Person GetById(int id);
        public User GetByUserName (string userName);
        public void DeleteByID (int id);
        public void Insert (User user);
        public void UpdateByUserName (string userName, /*byte[] password,*/ string name, string surname, string personalCode, string phone,
            string email, string city, string street, string houseNr, string appartmentNr);
        public User GetUser(string username);

        public void SaveUser(User user);

    }
}
