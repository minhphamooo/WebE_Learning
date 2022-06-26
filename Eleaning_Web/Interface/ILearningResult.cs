using WEB_ELEANING.Model;
using WEB_ELEANING.Request;

namespace WEB_ELEANING.Interface
{
    public interface ILearningResult
    {
        List<LearningResult> GetLearningResult();
        int AddLearningResult(LearningResultRequest request);
        int DetailLearningResult(string id);
        int DeleteLearningResult(string id);
        int UpdateLearningResult(string id, LearningResultRequest request);
    }
}
