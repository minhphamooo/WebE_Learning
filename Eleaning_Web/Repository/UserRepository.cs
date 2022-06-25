using WEB_ELEANING.Interface;
using WEB_ELEANING.Model;
using WEB_ELEANING.Request;

namespace WEB_ELEANING.Repository
{
    public class UserRepository : IUser
    {
        private readonly DBContext _context;
        public UserRepository(DBContext context)
        {
            _context = context;
        }

        public int DeleteUser(int id)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int ForgotPassword(string email, string phone, string newpass)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == email && u.PhoneNumber == phone);
            if (user == null)
            {
                return 0;
            }
            else
            {
                user.Password = Encode.Encrypt(newpass);
                _context.Users.Update(user);
                _context.SaveChanges();
                return 1;
            }
        }

        public List<User> GetAllUser()
        {
            return _context.Users.ToList(); ;
        }

        public int Login(string email, string pass)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == email && u.Password == Encode.Encrypt(pass));
            if (user == null)
            {
                return 0;
            }
            else
            {
                return 1;
            }

        }

        public int Register(UserRequest request)
        {
            var email = _context.Users.FirstOrDefault(u => u.Email == request.Email);
            if (email != null)
            {
                return 0;
            }
            else
            {
                var user = new User
                {
                    Email = request.Email,
                    PhoneNumber = request.phone,
                    Password = Encode.Encrypt(request.Password),
                    RoleId = request.RoleId,
                };
                _context.Users.Add(user);
                _context.SaveChanges();
                return 1;
            }
        }

        public int UpdateUser(int id, UserRequest request)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == id);
            if (user != null)
            {
                user.Email = request.Email;
                user.PhoneNumber = (request.phone).ToString();
                user.Password = Encode.Encrypt(request.Password);
                user.RoleId = request.RoleId;
                _context.Users.Update(user);
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