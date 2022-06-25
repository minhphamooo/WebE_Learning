using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEB_ELEANING.Interface;
using WEB_ELEANING.Model;
using WEB_ELEANING.Request;

namespace WEB_ELEANING.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly ISubject _subject;
        public SubjectController(ISubject sub)
        {
            _subject = sub;
        }
        [HttpGet("GetAllSubject")]
        public ActionResult<IEnumerable<Subject>> GetUsers()
        {
            var cls = _subject.GetAllSubject();
            return Ok(cls);
        }
        [HttpPost("AddSubject")]
        public IActionResult AddSubject(SubjectRequest request)
        {
            var add = _subject.AddSubject(request);
            if (add == 0)
            {
                return BadRequest(new { message = "ten lop da ton tai" });
            }
            return Ok(new { message = "tao lop thanh cong" });
        }

        [HttpDelete("DeleteSubject")]
        public IActionResult DeleteSubject(int id)
        {
            int login = _subject.DeleteSubject(id);
            if (login == 0)
            {
                return BadRequest(new { message = "khong tim thay lop" });
            }
            return Ok(new { message = "xoa thanh cong" });
        }
        [HttpPost("UpdateSubject")]
        public IActionResult UpdateSubject(int id, SubjectRequest rq)
        {
            int login = _subject.UpdateSubject(id, rq);
            if (login == 0)
            {
                return BadRequest(new { message = "khong tim thay lop" });
            }
            return Ok(new { message = "thay doi thanh cong" });
        }
    }
}

