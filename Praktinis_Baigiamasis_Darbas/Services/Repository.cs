//using Praktinis_Baigiamasis_Darbas.DataBase;

//namespace Praktinis_Baigiamasis_Darbas.Services
//{
//    public class Repository : IRepository
//    {
//        //private List<User> _users = new List<User>();

//        //private List<Location> _locations = new List<Location>();
//        //private List<Person> _persons = new List<Person>();

//        public void DeleteByID(int id)
//        {
//            using var dbContext = new RegistryDbContext();
//            var usersFromDb = dbContext.Users.FirstOrDefault(x => x.Id == id);
//            dbContext.Users.Remove(usersFromDb);
//            dbContext.SaveChanges();
//        }

//        public List<User> GetAll()
//        {
//            using var dbContext = new RegistryDbContext();
//            var usersFromDb = dbContext.Users;
//            return usersFromDb.ToList();
//            //return _users;
//        }

//        public Person GetById(int id)
//        {
//            using var dbContext = new RegistryDbContext();
//            var usersFromDb = dbContext.Persons.FirstOrDefault(x => x.Id == id);
//            return usersFromDb;
//            //using var dbContext = new RegistryDbContext();
//            //var usersFromDb = dbContext.Users.FirstOrDefault(x => x.Id == id);
//            //return usersFromDb;
//        }

//        public User GetByUserName(string userName)
//        {
//            using var dbContext = new RegistryDbContext();
//            var usersFromDb = dbContext.Users.FirstOrDefault(x => x.UserName == userName);
//            return usersFromDb;
//        }

//        public void Insert(User user)
//        {
//            using var dbContext = new RegistryDbContext();
//            //_users.Add(user);
//            dbContext.Add<User>(user);
//            dbContext.SaveChanges();
//        }

//        public void UpdateByUserName(string userName, string password, string name, string surname, string personalCode, string phone,
//            string email, string city, string street, string houseNr, string appartmentNr)
//        {
//            using var dbContext = new RegistryDbContext();
//            var usersFromDb = dbContext.Users.FirstOrDefault(x => x.UserName == userName);
//            //if (usersFromDb.Role == "user") 
//            //{
//            //var userToUpdate = usersFromDb.FirstOrDefault(x => x.userName == user.userName);
//            usersFromDb.Password = password;
//            //usersFromDb.Person.Name = name;
//            //usersFromDb.Person.Surname = surname;
//            //usersFromDb.Person.PersonalCode = personalCode;
//            //usersFromDb.Person.PhoneNumber = phone;
//            //usersFromDb.Person.Email = email;
//            //usersFromDb.Person.Location.City = city;
//            //usersFromDb.Person.Location.Street = street;
//            //usersFromDb.Person.Location.HouseNr = houseNr;
//            //usersFromDb.Person.Location.AppartmentNr = appartmentNr;
//            dbContext.SaveChanges();
//            //}

//        }
//    }
//}
