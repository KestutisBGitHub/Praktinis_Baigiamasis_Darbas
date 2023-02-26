using Praktinis_Baigiamasis_Darbas.DataBase;
using System.Security.Cryptography;

namespace Praktinis_Baigiamasis_Darbas.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository _repository;

        public UserService(IRepository repository)
        {
            _repository = repository;
        }

        public ResponseDto Login(string username, string password)
        {
            var user = _repository.GetUser(username);
            if (user is null)
                return new ResponseDto(false, "Username or password does not match");

            if (!VerifyPasswordHash(password, user.Password, user.Salt))
                return new ResponseDto(false, "Username or password does not match");

            return new ResponseDto(true, "User logged in");
        }

        public ResponseDto Signup(string username, string password)
        {
            var user = _repository.GetUser(username);
            if (user is not null)
                return new ResponseDto(false, "User already exists");

            user = CreateUser(username, password);
            _repository.SaveUser(user);
            return new ResponseDto(true);
        }

        private User CreateUser(string userName, string password)
        {
            CreatePasswordHash(userName, password, out byte[] passwordHash, out byte[] Salt);
            var user = new User
            {
                UserName = userName,
                Password = passwordHash,
                Salt = Salt,
                Role = "user"
            };

            return user;
        }

        private void CreatePasswordHash(string userName, string password, out byte[] passwordHash, out byte[] Salt)
        {
            using var hmac = new HMACSHA512();
            Salt = hmac.Key;
            passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using var hmac = new HMACSHA512(passwordSalt);
            var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

            return computedHash.SequenceEqual(passwordHash);
        }
    }
}
