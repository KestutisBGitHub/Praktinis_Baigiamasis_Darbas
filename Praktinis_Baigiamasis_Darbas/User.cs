using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Praktinis_Baigiamasis_Darbas
{
    public class User
    {
        public int Id { get; set; }
        //[Required(ErrorMessage = "* Required")]
        public string UserName { get; set; }
        //[Required(ErrorMessage = "* Required")]
        public string Password { get; set; }
        //public byte[] Salt { get; set; }
        [DefaultValue("user")]
        public string Role { get; set; }

        [ForeignKey("Person")]
        public int PersonID { get; set; }
        public Person Person { get; set; }

        public User(string userName, string password, /*byte[] salt,*/ string role)
        {

            UserName = userName;
            Password = password;
            //Salt = salt;
            Role = role;

        }
    }
}
