using WEB_ELEANING.Interface;
using WEB_ELEANING.Model;
using WEB_ELEANING.Request;

namespace WEB_ELEANING.Repository
{
    public class TypeExamRepository : ITypeExam
    {
        private readonly DBContext _context;
        public TypeExamRepository(DBContext context)
        {
            _context = context;
        }
        public int AddTypeExam(TypeExamRequest request)
        {
            var name = _context.TypeExam.FirstOrDefault(u => u.TypeExamName == request.TypeExamName);
            if (name != null)
            {
                return 0;
            }
            else
            {
                var doc = new TypeExam
                {
                    TypeExamName = request.TypeExamName,
                };
                _context.TypeExam.Add(doc);
                _context.SaveChanges();
                return 1;
            }
        }

        public int DeleteTypeExam(string id)
        {
            var doc = _context.TypeExam.FirstOrDefault(u => u.TypeExamId == id);
            if (doc == null)
            {
                return 0;
            }
            else
            {
                _context.TypeExam.Remove(doc);
                _context.SaveChanges();
                return 1;
            }
        }
        public int UpdateTypeExam( string id, TypeExamRequest request)
        {
            var doc = _context.TypeExam.FirstOrDefault(u => u.TypeExamId == id);
            if (doc != null)
            {

                _context.TypeExam.Update(doc);
                _context.SaveChanges();
                return 1;
            }
            else
            {

                return 0;
            }
        }
        public int DetailTypeExam(string id)
        {
            var doc = _context.TypeExam.Any(m => m.TypeExamId == id);
            if (doc == null)
                return 0;
            return 1;
        }

        public List<TypeExam> GetTypeExam()
        {
            return _context.TypeExam.ToList();
        }


    }
}
