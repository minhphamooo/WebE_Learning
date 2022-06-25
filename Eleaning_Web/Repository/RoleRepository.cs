using System.Linq;
using WEB_ELEANING.Interface;
using WEB_ELEANING.Model;
using WEB_ELEANING.Request;

namespace WEB_ELEANING.Repository
{
    public class RoleRepository : IRole
    {
        private readonly DBContext _context;
        public RoleRepository(DBContext context)
        {
            _context = context;
        }
        public int AddRole(RoleRequest request)
        {
            var name = _context.Role.FirstOrDefault(u => u.Name == request.Name);
            if (name != null)
            {
                return 0;
            }
            else
            {
                var doc = new Role
                {
                    Name = request.Name, 
                };
                _context.Role.Add(doc);
                _context.SaveChanges();
                return 1;
            }
        }

        public int DeleteRole(int id)
        {
            var doc = _context.Role.FirstOrDefault(u => u.RoleId == id);
            if (doc == null)
            {
                return 0;
            }
            else
            {
                _context.Role.Remove(doc);
                _context.SaveChanges();
                return 1;
            }
        }
        public int UpdateRole(int id, RoleRequest request)
        {
            var doc = _context.Role.FirstOrDefault(u => u.RoleId == id);
            if (doc != null)
            {

                _context.Role.Update(doc);
                _context.SaveChanges();
                return 1;
            }
            else
            {

                return 0;
            }
        }
        public int DetailRole(int id)
        {
            var doc = _context.Role.Any(m => m.RoleId == id);
            if (doc == null)
                return 0;
            return 1;
        }

        public List<Role> GetAllRole()
        {
            return _context.Role.ToList();
        }


    }
}
