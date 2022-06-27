using Eleaning_Web.Model;
using Eleaning_Web.Services;
namespace Eleaning_Web.Interface
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
