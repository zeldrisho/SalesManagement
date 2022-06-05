namespace DataAccess
{
    public interface ILoginDao
    {
        /// <summary>
        /// UserId: Tên đăng nhập
        /// Password: Encrypted password (Mật khẩu đã được mã hóa)
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        int Login(string userId, string password);
    }
}