using WEB_ELEANING.Interface;
using WEB_ELEANING.Model;
using WEB_ELEANING.Request;

namespace WEB_ELEANING.Repository
{
    public class QuestionRepository : IQuestion
    {
        private readonly DBContext _context;
        public QuestionRepository(DBContext context)
        {
            _context = context;
        }
        public int AddQuestion(QuestionRequest request)
        {
            var name = _context.Question.FirstOrDefault(u => u.QuestionName == request.QuestionName);
            if (name != null)
            {
                return 0;
            }
            else
            {
                var sub = new Question
                {
                    QuestionName = request.QuestionName,
                    AnswerA = request.AnswerA,
                    AnswerB = request.AnswerB,
                    AnswerC = request.AnswerC,
                    AnswerD = request.AnswerD,
                    AnswerCorrect = request.AnswerCorrect,
                    ContentId = request.ContentId,

                };
                _context.Question.Add(sub);
                _context.SaveChanges();
                return 1;
            }
        }

        public int DeleteQuestion(string id)
        {
            var cls = _context.Question.FirstOrDefault(u => u.QuestionId == id);
            if (cls == null)
            {
                return 0;
            }
            else
            {
                _context.Question.Remove(cls);
                _context.SaveChanges();
                return 1;
            }
        }

        public int DetailQuestion(string id)
        {
            var cls = _context.Question.Any(m => m.QuestionId == id);
            if (cls == null)
                return 0;
            return 1;
        }

        public List<Question> GetAllQuestion()
        {
            return _context.Question.ToList();
        }

        public int UpdateQuestion(string id, QuestionRequest request)
        {
            var sub = _context.Question.FirstOrDefault(u => u.QuestionId == id);
            if (sub != null)
            {
                sub.QuestionName = request.QuestionName;
                sub.AnswerA = request.AnswerA;
                sub.AnswerB = request.AnswerB;
                sub.AnswerC = request.AnswerC;
                sub.AnswerD = request.AnswerD;
                sub.AnswerCorrect = request.AnswerCorrect;
                sub.ContentId = request.ContentId;
                _context.Question.Update(sub);
                _context.SaveChanges();
                return 1;
            }
            else
            {

                return 0;
            }
        }
    }
}
