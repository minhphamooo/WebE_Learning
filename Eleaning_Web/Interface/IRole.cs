using WEB_ELEANING.Request;
using WEB_ELEANING.Model;

namespace WEB_ELEANING.Interface
{
    public interface IRole
    {
        List<Role> GetAllRole();
        int AddRole(RoleRequest request);
        int DetailRole(int id);
        int DeleteRole(int id);
        int UpdateRole(int id, RoleRequest request);
    }
}
