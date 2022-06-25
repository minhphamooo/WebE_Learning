using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEB_ELEANING.Interface;
using WEB_ELEANING.Model;
using WEB_ELEANING.Request;

namespace WEB_ELEANING.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SemesterController : ControllerBase
    {
        private readonly ISemester _semester;
        public SemesterController(ISemester smt)
        {
            _semester = smt;
        }
        [HttpGet("GetAllSemester")]
        public ActionResult<IEnumerable<Semester>> GetAllSemester()
        {
            var cls = _semester.GetAllSemester();
            return Ok(cls);
        }
        [HttpPost("AddRole")]
        public IActionResult AddSemester(SemesterRequest request)
        {
            var add = _semester.AddSemester(request);
            if (add == 0)
            {
                return BadRequest(new { message = "đã tồn tại" });
            }
            return Ok(new { message = "tạo thành công" });
        }
        [HttpPut("UpdateTypeExam")]
        public IActionResult UpdateSemester(int id, SemesterRequest request)
        {
            int rl = _semester.UpdateSemester(id, request);
            if (rl == 0)
            {
                return BadRequest(new { message = "Không tìm thấy" });
            }
            return Ok(new { message = "Cập nhật thành công" });
        }
        [HttpDelete("DeleteTypeExam")]
        public IActionResult DeleteSemester(int id)
        {
            int login = _semester.DeleteSemester(id);
            if (login == 0)
            {
                return BadRequest(new { message = "Không tìm thấy" });
            }
            return Ok(new { message = "Đã xóa" });
        }

    }
}

