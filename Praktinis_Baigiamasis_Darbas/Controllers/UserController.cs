using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Praktinis_Baigiamasis_Darbas.DataBase;
using Praktinis_Baigiamasis_Darbas.Services;

namespace Praktinis_Baigiamasis_Darbas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Login")]
        public ActionResult<ResponseDto> Login([FromBody] UserDto request)
        {
            var response = _userService.Login(request.UserName, request.Password);
            if (!response.IsSuccess)
                return BadRequest(response.Message);
            return response;
        }

        [HttpPost("Signup")]
        public ActionResult<ResponseDto> Signup([FromBody] UserDto request)
        {
            var response = _userService.Signup(request.UserName, request.Password);
            if (!response.IsSuccess)
                return BadRequest(response.Message);
            return response;
        }
    }
}
