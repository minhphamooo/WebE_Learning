using WEB_ELEANING.Interface;
using WEB_ELEANING.Model;
using WEB_ELEANING.Request;

namespace WEB_ELEANING.Repository
{
    public class LearningResultRepository : ILearningResult
    {
        private readonly DBContext _context;
        public LearningResultRepository(DBContext context)
        {
            _context = context;
        }
        public int AddLearningResult(LearningResultRequest request)
        {
            var name = _context.LearningResult.FirstOrDefault(u => u.ScoreAvg == request.ScoreAvg);
            if (name != null)
            {
                return 0;
            }
            else
            {
                var doc = new LearningResult
                {
                    ScoreAvg = request.ScoreAvg,
                    AttendancePoint=request.AttendancePoint,
                    ScoreOralTest=request.ScoreOralTest,
                    Score=request.Score,
                    Score15Minunes=request.Score15Minunes,
                    ScoreCoefficient2=request.ScoreCoefficient2,
                    ScoreCoefficient3=request.ScoreCoefficient3,
                    SumScoreAvg=request.SumScoreAvg,
                    ResultOfEvaluation=request.ResultOfEvaluation,
                    DateUpdate=request.DateUpdate,
                    UserId=request.UserId,
                };
                _context.LearningResult.Add(doc);
                _context.SaveChanges();
                return 1;
            }
        }

        public int DeleteLearningResult(string id)
        {
            var doc = _context.LearningResult.FirstOrDefault(u => u.LRId == id);
            if (doc == null)
            {
                return 0;
            }
            else
            {
                _context.LearningResult.Remove(doc);
                _context.SaveChanges();
                return 1;
            }
        }
        public int UpdateLearningResult(string id, LearningResultRequest request)
        {
            var doc = _context.LearningResult.FirstOrDefault(u => u.LRId == id);
            if (doc != null)
            {

                _context.LearningResult.Update(doc);
                _context.SaveChanges();
                return 1;
            }
            else
            {

                return 0;
            }
        }
        public int DetailLearningResult(string id)
        {
            var doc = _context.LearningResult.Any(m => m.LRId == id);
            if (doc == null)
                return 0;
            return 1;
        }

        public List<LearningResult> GetLearningResult()
        {
            return _context.LearningResult.ToList();
        }


    }
}