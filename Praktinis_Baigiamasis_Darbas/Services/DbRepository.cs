using Praktinis_Baigiamasis_Darbas.DataBase;

namespace Praktinis_Baigiamasis_Darbas.Services
{
    public class DbRepository : IRepository
    {
        private readonly RegistryDbContext _context;
        public DbRepository (RegistryDbContext context)
        {
            _context = context;
        }

        public void Insert(User user)
        {
           _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void DeleteByID(int id)
        {
            var userToDlete = _context.Users.FirstOrDefault(x => x.Id == id);
            _context.Users.Remove(userToDlete);
            _context.SaveChanges();
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public Person GetById(int id)
        {
            return _context.Persons.FirstOrDefault(x => x.Id == id);
             
        }

        public User GetByUserName(string userName)
        {
            return _context.Users.FirstOrDefault(x => x.UserName == userName);
        }

       

        public void UpdateByUserName(string userName, /*byte[] password,*/ string name, string surname, string personalCode, string phone, string email, string city, string street, string houseNr, string appartmentNr)
        {
            var itemFromDb = _context.Users.FirstOrDefault(x => x.UserName == userName);
            itemFromDb.Person.Name = name;
            _context.SaveChanges();
        }

        public User GetUser(string username)
        {
            return _context.Users.SingleOrDefault(x => x.UserName == username);
        }

        public void SaveUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
