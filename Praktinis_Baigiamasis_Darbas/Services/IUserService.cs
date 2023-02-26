namespace Praktinis_Baigiamasis_Darbas.Services
{
    public interface IUserService
    {
        ResponseDto Signup(string username, string password);
        ResponseDto Login(string username, string password);
    }
}
