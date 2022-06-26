using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEB_ELEANING.Interface;
using WEB_ELEANING.Model;
using WEB_ELEANING.Request;

namespace WEB_ELEANING.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LearningResultController : ControllerBase
    {
        private readonly ILearningResult _learning;
        public LearningResultController(ILearningResult ler)
        {
            _learning = ler;
        }
        [HttpGet("GetTypeExam")]
        public ActionResult<IEnumerable<LearningResult>> GetLearningResult()
        {
            var cls = _learning.GetLearningResult();
            return Ok(cls);
        }
        [HttpPost("AddLearningResult")]
        public IActionResult AddLearningResult(LearningResultRequest request)
        {
            var add = _learning.AddLearningResult(request);
            if (add == 0)
            {
                return BadRequest(new { message = "đã tồn tại" });
            }
            return Ok(new { message = "tạo thành công" });
        }
        [HttpPut("UpdateLearningResult")]
        public IActionResult UpdateLearningResult(string id, LearningResultRequest request)
        {
            int rl = _learning.UpdateLearningResult(id, request);
            if (rl == 0)
            {
                return BadRequest(new { message = "Không tìm thấy" });
            }
            return Ok(new { message = "Cập nhật thành công" });
        }
        [HttpDelete("DeleteLearningResult")]
        public IActionResult DeleteLearningResult(string id)
        {
            int login = _learning.DeleteLearningResult(id);
            if (login == 0)
            {
                return BadRequest(new { message = "Không tìm thấy" });
            }
            return Ok(new { message = "Đã xóa" });
        }

    }
}

