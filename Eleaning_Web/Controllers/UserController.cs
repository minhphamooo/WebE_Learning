using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEB_ELEANING.Interface;
using WEB_ELEANING.Model;
using WEB_ELEANING.Request;

namespace WEB_ELEANING.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUser _user;
        public UserController(IUser user)
        {
            _user = user;
        }
        [HttpGet("GETALL")]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            var users = _user.GetAllUser();
            return Ok(users);
        }
        [HttpPost("Register")]
        public IActionResult Register(UserRequest request)
        {
            var register = _user.Register(request);
            if (register == 0)
            {
                return BadRequest(new { message = "email da ton tai" });
            }
            return Ok(new { message = "dang ki thanh cong" });
        }
        [HttpGet("Login")]
        public IActionResult Login(string email, string pass)
        {
            int login = _user.Login(email, pass);
            if (login == 0)
            {
                return BadRequest(new { message = "mat khau hoac tai khoan khong dung" });
            }
            return Ok(new { message = "dang nhap thanh cong" });
        }
        [HttpPost("ForgotPassword")]
        public IActionResult Forgot(string email, string pass, string newpass)
        {
            int forgot = _user.ForgotPassword(email, pass, newpass);
            if (forgot == 0)
            {
                return BadRequest(new { message = "tai khoan khong ton tai" });
            }
            return Ok(new { message = "doi mat khau thanh cong" });
        }
        [HttpPut("UpdateUser")]
        public IActionResult UpdateUser(int id, UserRequest rq)
        {
            int login = _user.UpdateUser(id, rq);
            if (login == 0)
            {
                return BadRequest(new { message = "khong tim thay tai khoan" });
            }
            return Ok(new { message = "thay doi thanh cong" });
        }
        [HttpDelete("DeleteUser")]
        public IActionResult DeleteUser(int id)
        {
            int login = _user.DeleteUser(id);
            if (login == 0)
            {
                return BadRequest(new { message = "khong tim thay tai khoan" });
            }
            return Ok(new { message = "xoa thanh cong" });
        }
       
    }
}
