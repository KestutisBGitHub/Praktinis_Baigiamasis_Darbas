using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Praktinis_Baigiamasis_Darbas
{
    public class UserDto
    {
        
        //[Required(ErrorMessage = "* Required")]
        public string UserName { get; set; }
        //[Required(ErrorMessage = "* Required")]
        public string Password { get; set; }
        //[DefaultValue("user")]
       // public string Role { get; set; }

      // [ForeignKey("Person")]
      //  public int PersonID { get; set; }
        //public PersonDTO Person { get; set; }

        public UserDto(string userName, string password /*, string role*/)
        {
           
            UserName = userName;
            Password = password;
            
           // Role = role;

        }
    }
}
