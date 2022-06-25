using WEB_ELEANING.Interface;
using WEB_ELEANING.Model;
using WEB_ELEANING.Request;
namespace WEB_ELEANING.Repository
{
    public class ContentTestRepository : IContentTest
    {
        private readonly DBContext _context;
        public ContentTestRepository(DBContext context)
        {
            _context = context;
        }
        public int AddContentTest(ContentTestRequest request)
        {
            var name = _context.ContentTest.FirstOrDefault(u => u.Content == request.Content);
            if (name != null)
            {
                return 0;
            }
            else
            {
                var doc = new ContentTest
                {
                    Content = request.Content,
                    Result = request.Result,
                    ExamID = request.ExamID,
                    SubjectID = request.SubjectID
                };
                _context.ContentTest.Add(doc);
                _context.SaveChanges();
                return 1;
            }
        }

        public int DeleteContentTest(int id)
        {
            var doc = _context.ContentTest.FirstOrDefault(u => u.ContentId == id);
            if (doc == null)
            {
                return 0;
            }
            else
            {
                _context.ContentTest.Remove(doc);
                _context.SaveChanges();
                return 1;
            }
        }
        public int UpdateContentTest(int id, ContentTestRequest request)
        {
            var doc = _context.ContentTest.FirstOrDefault(u => u.ContentId == id);
            if (doc != null)
            {
                doc.Content = request.Content;
                doc.Result = request.Result;
                doc.ExamID = request.ExamID;
                doc.SubjectID = request.SubjectID;
                _context.ContentTest.Update(doc);
                _context.SaveChanges();
                return 1;
            }
            else
            {

                return 0;
            }
        }
        public int DetailContentTest(int id)
        {
            var doc = _context.ContentTest.Any(m => m.ContentId == id);
            if (doc == null)
                return 0;
            return 1;
        }

        public List<ContentTest> GetAllContentTest()
        {
            return _context.ContentTest.ToList();
        }


    }
}