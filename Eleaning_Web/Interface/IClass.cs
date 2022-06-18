using Eleaning_Web.DTO;
namespace Eleaning_Web.Interface
{
    public interface IClass
    {
        List<ClassDTO> GetAll();
        ClassDTO GetById(string ClassId);
        bool Insert(ClassDTO classDTO);
        bool Update(ClassDTO classDTO);
        bool Delete(string ClassId);
        void Save();
    }
}
