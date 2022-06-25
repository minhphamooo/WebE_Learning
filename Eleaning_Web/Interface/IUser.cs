using WEB_ELEANING.Model;
using WEB_ELEANING.Repository;
using WEB_ELEANING.Request;

namespace WEB_ELEANING.Interface
{
    public interface IUser
    {
        List<User> GetAllUser();
        int Register(UserRequest user);
        int Login(string email, string pass);
        int ForgotPassword(string email, string phone, string newpass);
        int DeleteUser(int id);
        int UpdateUser(int id, UserRequest request);
    }
}
