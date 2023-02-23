using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Praktinis_Baigiamasis_Darbas
{
    public class UserDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "* Required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "* Required")]
        public string Password { get; set; }
        public byte[] Salt { get; set; }
        public string Role { get; set; }

        [ForeignKey("Person")]
        public int PersonID { get; set; }
        public Person Person { get; set; }

        public UserDTO(int id, string userName)
        {
            Id = id;
            UserName = userName;
 
        }
    }
}
