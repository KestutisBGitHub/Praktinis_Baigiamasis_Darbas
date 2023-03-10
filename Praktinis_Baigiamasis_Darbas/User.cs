using System.ComponentModel.DataAnnotations.Schema;

namespace Praktinis_Baigiamasis_Darbas
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public byte[] Salt { get; set; }
        public string Role { get; set; }

        [ForeignKey("Person")]
        public int? PersonID { get; set; }
        public Person? Person { get; set; }

        public User(int id, string userName, string password, byte[] salt, string role)
        {
            Id = id;
            UserName = userName;
            Password = password;
            Salt = salt;
            Role = role;
        }
    }
}
