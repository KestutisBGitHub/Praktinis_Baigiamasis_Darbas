using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Praktinis_Baigiamasis_Darbas.DataBase;
using Praktinis_Baigiamasis_Darbas.Services;

namespace Praktinis_Baigiamasis_Darbas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly IRepository _repository;
        public DataController(IRepository repository)
        {
            _repository = repository;
        }


        //private static List<User> _users = new List<User>();
        //private readonly RegistryDbContext _registryContext;

        //public DataController()
        //{
        //    _registryContext = new RegistryDbContext();
        //}

        [HttpGet("All")]
        public List<User> GetAll()
        {
            return _repository.GetAll();
        }

        [HttpGet("Get By ID")]
        public Person GetAdmin(int id)
        {
            return _repository.GetById(id);
        }

        [HttpGet("Get by UserName")]
        public User GetByUserName(string userName)
        {
            //using var dbContext = new RegistryDbContext();
            //var usersFromDb = dbContext.Users.FirstOrDefault(x => x.UserName == userName);
            ////var personID = usersFromDb.PersonID;
            ////var personFromDb = dbContext.Persons.FirstOrDefault(y => y.Id == personID);
            ////var locationId = personFromDb.LocationID;
            ////var locationFromDb = dbContext.Locations.FirstOrDefault(z => z.Id == locationId);
            ////var userData = usersFromDb + personFromDb + locationFromDb;
            //return usersFromDb;
            return _repository.GetByUserName(userName);
        }



        [HttpPost("Create user")]
        public void Post(User user)
        {
            _repository.Insert(user);
        }

        //[HttpPatch("User")]
        //public void Patch(string userName, string password, string name, string surname, string personalCode, string phone, 
        //    string email, string city, string street, string houseNr, string appartmentNr)
        //{

        //    _repository.UpdateByUserName(userName, password, name, surname,
        //        personalCode, phone, email, city, street, houseNr, appartmentNr);

            
        //}

        [HttpPatch("User")]
        public void Patch(UserDto userUpdatedinfo)
        {

            //_repository.UpdateByUserName(userUpdatedinfo.UserName, /*userUpdatedinfo.Password,*/ userUpdatedinfo.Person.Name, userUpdatedinfo.Person.Surname,
            //    userUpdatedinfo.Person.PersonalCode, userUpdatedinfo.Person.PhoneNumber, userUpdatedinfo.Person.Email, userUpdatedinfo.Person.Location.City, userUpdatedinfo.Person.Location.Street, userUpdatedinfo.Person.Location.HouseNr, userUpdatedinfo.Person.Location.AppartmentNr);


        }

        [HttpDelete]
        public void Delete(int id)
        {
            _repository.DeleteByID(id);
        }
    }
}
