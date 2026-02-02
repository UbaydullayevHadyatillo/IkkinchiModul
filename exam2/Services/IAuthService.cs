using exam2.Ddos;

namespace exam2.Services
{
    internal interface IAuthService
    {
        public Guid RegisterUser(UserRegisterDto userRegisterDto);
        public string LoginUser(UserLoginDto userLoginDto);
    }
}