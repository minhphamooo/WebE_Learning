using Eleaning_Web.DTO;
namespace Eleaning_Web.Interface
{
    public interface IContentTest
    {
        List<ContentTestDTO> GetAll();
        ContentTestDTO GetById(int ContentId);
        bool Insert(ContentTestDTO contentTest);
        bool Update(ContentTestDTO contentTest);
        bool Delete(int ContentId);
        void Save();
    }
}
