using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEB_ELEANING.Interface;
using WEB_ELEANING.Request;
using WEB_ELEANING.Model;
namespace WEB_ELEANING.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private readonly IDocument _document;
        public DocumentController(IDocument doc)
        {
            _document = doc;
        }
        [HttpGet("GetAllDocument")]
        public ActionResult<IEnumerable<Document>> GetUsers()
        {
            var cls = _document.GetAllDocument();
            return Ok(cls);
        }
        [HttpPost("AddDocument")]
        public IActionResult Add(DocumentRequest request)
        {
            var add = _document.AddDocument(request);
            if (add == 0)
            {
                return BadRequest(new { message = "ten lop da ton tai" });
            }
            return Ok(new { message = "tao lop thanh cong" });
        }
        
        [HttpPut("UpdateDocument")]
        public IActionResult Update(int id, DocumentRequest rq)
        {
            int login = _document.UpdateDocument(id, rq);
            if (login == 0)
            {
                return BadRequest(new { message = "khong tim thay lop" });
            }
            return Ok(new { message = "thay doi thanh cong" });
        }
        [HttpDelete("DeleteDocument")]
        public IActionResult Delete(int id)
        {
            int login = _document.DeleteDocument(id);
            if (login == 0)
            {
                return BadRequest(new { message = "khong tim thay lop" });
            }
            return Ok(new { message = "xoa thanh cong" });
        }
      
       
    }
}
