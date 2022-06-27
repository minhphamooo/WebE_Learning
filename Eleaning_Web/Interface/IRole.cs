using Eleaning_Web.DTO;
namespace Eleaning_Web.Interface
{
    public interface IRole
    {
        List<RoleDTO> GetAll();
        RoleDTO GetById(int RoleId);
        bool Insert(RoleDTO role);
        bool Update(RoleDTO role);
        bool Delete(int RoleId);
        void Save();
    }
}
