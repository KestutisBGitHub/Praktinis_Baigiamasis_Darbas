using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Praktinis_Baigiamasis_Darbas.DataBase;

namespace Praktinis_Baigiamasis_Darbas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private static List<User> _users = new List<User>();
        private readonly RegistryDbContext _registryContext;

        public DataController()
        {
            _registryContext = new RegistryDbContext();
        }

        [HttpGet("Get By ID")]
        public User GetAdmin(int id)
        {
            using var dbContext = new RegistryDbContext();
            var usersFromDb = dbContext.Users.FirstOrDefault(x => x.Id == id);
            return usersFromDb;
        }

        [HttpGet("Get by UserName")]
        public User GetByUserName(string userName)
        {
            using var dbContext = new RegistryDbContext();
            var usersFromDb = dbContext.Users.FirstOrDefault(x => x.UserName == userName);
            //var personID = usersFromDb.PersonID;
            //var personFromDb = dbContext.Persons.FirstOrDefault(y => y.Id == personID);
            //var locationId = personFromDb.LocationID;
            //var locationFromDb = dbContext.Locations.FirstOrDefault(z => z.Id == locationId);
            //var userData = usersFromDb + personFromDb + locationFromDb;
            return usersFromDb;
        }



        [HttpPost("Create user")]
        public void Post(User user)
        {
            using var dbContext = new RegistryDbContext();
            //_users.Add(user);
            dbContext.Add<User>(user);
            dbContext.SaveChanges();
        }

        [HttpPatch("User")]
        public void Patch(string userName, string password, string name, string surname, string personalCode, string phone, 
            string email, string city, string street, string houseNr, string appartmentNr)
        {
            using var dbContext = new RegistryDbContext();
            var usersFromDb = dbContext.Users.FirstOrDefault(x => x.UserName == userName);
           
            //if (usersFromDb.Role == "user") 
            //{
                //var userToUpdate = usersFromDb.FirstOrDefault(x => x.userName == user.userName);
                usersFromDb.Password = password;
                //usersFromDb.Person.Name = name;
                //usersFromDb.Person.Surname = surname;
                //usersFromDb.Person.PersonalCode = personalCode;
                //usersFromDb.Person.PhoneNumber = phone;
                //usersFromDb.Person.Email = email;
                //usersFromDb.Person.Location.City = city;
                //usersFromDb.Person.Location.Street = street;
                //usersFromDb.Person.Location.HouseNr = houseNr;
                //usersFromDb.Person.Location.AppartmentNr = appartmentNr;
                dbContext.SaveChanges();
            //}
            
        }

        [HttpDelete]
        public void Delete(int id)
        {
            using var dbContext = new RegistryDbContext();
            var usersFromDb = dbContext.Users.FirstOrDefault(x => x.Id == id);
            dbContext.Users.Remove(usersFromDb);
            dbContext.SaveChanges();
        }
    }
}
