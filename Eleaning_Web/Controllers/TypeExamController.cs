using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEB_ELEANING.Interface;
using WEB_ELEANING.Model;
using WEB_ELEANING.Request;

namespace WEB_ELEANING.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeExamController : ControllerBase
    {
        private readonly ITypeExam _typeExam;
        public TypeExamController(ITypeExam tye)
        {
            _typeExam = tye;
        }
        [HttpGet("GetTypeExam")]
        public ActionResult<IEnumerable<TypeExam>> GetTypeExam()
        {
            var cls = _typeExam.GetTypeExam();
            return Ok(cls);
        }
        [HttpPost("AddRole")]
        public IActionResult AddTypeExam(TypeExamRequest request)
        {
            var add = _typeExam.AddTypeExam(request);
            if (add == 0)
            {
                return BadRequest(new { message = "đã tồn tại" });
            }
            return Ok(new { message = "tạo thành công" });
        }
        [HttpPut("UpdateTypeExam")]
        public IActionResult UpdateTypeExam(string id, TypeExamRequest rq)
        {
            int rl = _typeExam.UpdateTypeExam(id, rq);
            if (rl == 0)
            {
                return BadRequest(new { message = "Không tìm thấy" });
            }
            return Ok(new { message = "Cập nhật thành công" });
        }
        [HttpDelete("DeleteTypeExam")]
        public IActionResult DeleteTypeExam(string id)
        {
            int login = _typeExam.DeleteTypeExam(id);
            if (login == 0)
            {
                return BadRequest(new { message = "Không tìm thấy" });
            }
            return Ok(new { message = "Đã xóa" });
        }

    }
}

