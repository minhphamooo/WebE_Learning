using Eleaning_Web.DTO;
namespace Eleaning_Web.Interface
{
    public interface ISubject
    {
        List<SubjectDTO> GetAll();
        SubjectDTO GetById(string SubjectId);
        bool Insert(SubjectDTO subject);
        bool Update(SubjectDTO subject);
        bool Delete(string SubjectId);
        void Save();
    }
}

