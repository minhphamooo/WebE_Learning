using WEB_ELEANING.Interface;
using WEB_ELEANING.Model;
using WEB_ELEANING.Request;

namespace WEB_ELEANING.Repository
{
    public class SemesterRepository : ISemester
    {
        private readonly DBContext _context;
        public SemesterRepository(DBContext context)
        {
            _context = context;
        }
        public int AddSemester(SemesterRequest request)
        {
            var name = _context.Semester.FirstOrDefault(u => u.SemesterName == request.SemesterName);
            if (name != null)
            {
                return 0;
            }
            else
            {
                var doc = new Semester
                {
                    SemesterName = request.SemesterName,
                };
                _context.Semester.Add(doc);
                _context.SaveChanges();
                return 1;
            }
        }

        public int DeleteSemester(int id)
        {
            var doc = _context.Semester.FirstOrDefault(u => u.SemesterId == id);
            if (doc == null)
            {
                return 0;
            }
            else
            {
                _context.Semester.Remove(doc);
                _context.SaveChanges();
                return 1;
            }
        }
        public int UpdateSemester(int id, SemesterRequest request)
        {
            var doc = _context.Semester.FirstOrDefault(u => u.SemesterId == id);
            if (doc != null)
            {

                _context.Semester.Update(doc);
                _context.SaveChanges();
                return 1;
            }
            else
            {

                return 0;
            }
        }
        public int DetailSemester(int id)
        {
            var doc = _context.Semester.Any(m => m.SemesterId == id);
            if (doc == null)
                return 0;
            return 1;
        }

        public List<Semester> GetAllSemester()
        {
            return _context.Semester.ToList();
        }


    }
}