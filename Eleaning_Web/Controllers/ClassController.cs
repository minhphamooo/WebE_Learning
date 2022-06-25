using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEB_ELEANING.Interface;
using WEB_ELEANING.Model;
using WEB_ELEANING.Request;

namespace WEB_ELEANING.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private readonly IClass _class;
        public ClassController(IClass cls)
        {
            _class = cls;
        }
        [HttpGet("GetAllClass")]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            var cls = _class.GetAllClass();
            return Ok(cls);
        }
        [HttpPost("AddClass")]
        public IActionResult AddClass(ClassRequest request)
        {
            var add = _class.AddClass(request);
            if (add == 0)
            {
                return BadRequest(new { message = "ten lop da ton tai" });
            }
            return Ok(new { message = "tao lop thanh cong" });
        }
        [HttpPut("UpdateClass")]
        public IActionResult UpdateClass(int id, ClassRequest rq)
        {
            int login = _class.UpdateClass(id, rq);
            if (login == 0)
            {
                return BadRequest(new { message = "khong tim thay lop" });
            }
            return Ok(new { message = "thay doi thanh cong" });
        }
        [HttpDelete("DeleteClass")]
        public IActionResult DeleteClass(int id)
        {
            int login = _class.DeleteClass(id);
            if (login == 0)
            {
                return BadRequest(new { message = "khong tim thay lop" });
            }
            return Ok(new { message = "xoa thanh cong" });
        }
       
    }
}
