using WEB_ELEANING.Model;
using WEB_ELEANING.Request;

namespace WEB_ELEANING.Interface
{
    public interface IQuestion
    {
        List<Question> GetAllQuestion();
        int AddQuestion(QuestionRequest request);
        int DetailQuestion(string id);
        int DeleteQuestion(string id);
        int UpdateQuestion(string id, QuestionRequest request);
    }
}
