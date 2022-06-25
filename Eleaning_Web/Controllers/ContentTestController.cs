using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEB_ELEANING.Interface;
using WEB_ELEANING.Request;
using WEB_ELEANING.Model;

namespace WEB_ELEANING.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentTestController : ControllerBase
    {
        private readonly IContentTest _content;
        public ContentTestController(IContentTest doc)
        {
            _content = doc;
        }
        [HttpGet("GetAllContentTest")]
        public ActionResult<IEnumerable<ContentTest>> GetAllContentTest()
        {
            var ct = _content.GetAllContentTest();
            return Ok(ct);
        }
        [HttpPost("AddContentTest")]
        public IActionResult Add(ContentTestRequest request)
        {
            var add = _content.AddContentTest(request);
            if (add == 0)
            {
                return BadRequest(new { message = "tên đã tồn tại" });
            }
            return Ok(new { message = "tạo thành công" });
        }

        [HttpPut("UpdateContentTest")]
        public IActionResult Update(int id, ContentTestRequest rq)
        {
            int login = _content.UpdateContentTest(id, rq);
            if (login == 0)
            {
                return BadRequest(new { message = "khong tim thay lop" });
            }
            return Ok(new { message = "thay doi thanh cong" });
        }
        [HttpDelete("DeleteContentTest")]
        public IActionResult Delete(int id)
        {
            int login = _content.DeleteContentTest(id);
            if (login == 0)
            {
                return BadRequest(new { message = "khong tim thay lop" });
            }
            return Ok(new { message = "xoa thanh cong" });
        }


    }
}
