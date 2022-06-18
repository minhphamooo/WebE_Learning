using Eleaning_Web.DTO;

namespace Eleaning_Web.Interface
{
    public interface IAnswer
    {
        List<AnswerDTO> GetAll();
        AnswerDTO GetById(string AnswerId);
        bool Insert(AnswerDTO answer);
        bool Update(AnswerDTO answer);
        bool Delete(string AnswerId);
        void Save();
    }
}
