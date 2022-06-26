using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEB_ELEANING.Interface;
using WEB_ELEANING.Model;
using WEB_ELEANING.Request;

namespace WEB_ELEANING.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestion _question;
        public QuestionController(IQuestion que)
        {
            _question = que;
        }
        [HttpGet("GetAllQuestion")]
        public ActionResult<IEnumerable<Question>> GetAllQuestion()
        {
            var cls = _question.GetAllQuestion();
            return Ok(cls);
        }
        [HttpPost("AddQuestion")]
        public IActionResult AddQuestion(QuestionRequest request)
        {
            var add = _question.AddQuestion(request);
            if (add == 0)
            {
                return BadRequest(new { message = "đã tồn tại" });
            }
            return Ok(new { message = "tạo thành công" });
        }
        [HttpPut("UpdateQuestion")]
        public IActionResult UpdateQuestion(string id, QuestionRequest request)
        {
            int rl = _question.UpdateQuestion(id, request);
            if (rl == 0)
            {
                return BadRequest(new { message = "Không tìm thấy" });
            }
            return Ok(new { message = "Cập nhật thành công" });
        }
        [HttpDelete("DeleteQuestion")]
        public IActionResult DeleteQuestion(string id)
        {
            int login = _question.DeleteQuestion(id);
            if (login == 0)
            {
                return BadRequest(new { message = "Không tìm thấy" });
            }
            return Ok(new { message = "Đã xóa" });
        }

    }
}

