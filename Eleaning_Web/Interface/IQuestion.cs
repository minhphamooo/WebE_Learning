using Eleaning_Web.DTO;
namespace Eleaning_Web.Interface
{
    public interface IQuestion
    {
        List<QuestionDTO> GetAll();
        QuestionDTO GetById(string QuestionId);
        bool Insert(QuestionDTO question);
        bool Update(QuestionDTO question);
        bool Delete(string QuestionId);
        void Save();
    }
}
