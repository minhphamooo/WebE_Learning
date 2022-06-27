using Eleaning_Web.DTO;
namespace Eleaning_Web.Interface
{
    public interface ILearningResult
    {
        List<LearningResultDTO> GetAll();
        LearningResultDTO GetById(string LRId);
        bool Insert(LearningResultDTO learningResult);
        bool Update(LearningResultDTO learningResult);
        bool Delete(string LRId);
        void Save();
    }
}
