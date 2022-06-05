using DataAccess;

namespace BusinessLogic
{
    public class LoginService : ILoginService
    {
        public int Login(string userId, string password)
        {
            //Mã hóa mật khẩu bằng một hàm có sẵn
            var passwordEncrypted = AuthenticationUtil.EncrytPassword(password);

            ILoginDao loginDao = new LoginDao();

            var returnValue = loginDao.Login(userId, passwordEncrypted);

            return returnValue;
        }
    }
}