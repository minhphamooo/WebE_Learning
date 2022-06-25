using WEB_ELEANING.Interface;
using WEB_ELEANING.Model;
using WEB_ELEANING.Request;

namespace WEB_ELEANING.Repository
{
    public class ClassRepository : IClass
    {
        private readonly DBContext _context;
        public ClassRepository(DBContext context)
        {
            _context = context;
        }

        public int AddClass(ClassRequest request)
        {
            var name = _context.Class.FirstOrDefault(u => u.NameClass == request.Name);
            if (name != null)
            {
                return 0;
            }
            else
            {
                var cls = new Class
                {
                    NameClass = request.Name,
                    Amount = request.Amount,
                    Link = request.link,
                    Status = request.status
                };
                _context.Class.Add(cls);
                _context.SaveChanges();
                return 1;
            }
        }

        public int DeleteClass(int id)
        {
            var cls = _context.Class.FirstOrDefault(u => u.ClassId == id);
            if (cls == null)
            {
                return 0;
            }
            else
            {
                _context.Class.Remove(cls);
                _context.SaveChanges();
                return 1;
            }
        }

        public int DetailClass(int id)
        {
            var cls = _context.Class.Any(m => m.ClassId == id);
            if (cls == null)
                return 0;
            return 1;
        }

        public List<Class> GetAllClass()
        {
            return _context.Class.ToList();
        }



        public int UpdateClass(int id, ClassRequest request)
        {
            var cls = _context.Class.FirstOrDefault(u => u.ClassId == id);
            if (cls != null)
            {
                cls.NameClass = request.Name;
                cls.Amount = request.Amount;
                cls.Link = request.link;
                cls.Status = request.status;
                _context.Class.Update(cls);
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
