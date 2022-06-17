using Eleaning_Web.DTO;
namespace Eleaning_Web.Services
{
    public interface IAnswer
    {
        Task<List<AnswerDTO>> GetAll();
        Task<AnswerDTO> AnswerGetSingle(string id);
        Task<bool> AnswerInsert(AnswerDTO request);
        Task<bool> AnswerUpdate(AnswerDTO request);
        Task<bool> AnswerDelete(string id);
    }
}
