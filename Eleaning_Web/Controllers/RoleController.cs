using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEB_ELEANING.Interface;
using WEB_ELEANING.Model;
using WEB_ELEANING.Request;

namespace WEB_ELEANING.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRole _role;
        public RoleController(IRole rls)
        {
            _role = rls;
        }
        [HttpGet("GetAllRole")]
        public ActionResult<IEnumerable<Role>> GetAllRole()
        {
            var cls = _role.GetAllRole();
            return Ok(cls);
        }
        [HttpPost("AddRole")]
        public IActionResult AddRole(RoleRequest request)
        {
            var add = _role.AddRole(request);
            if (add == 0)
            {
                return BadRequest(new { message = "ten lop da ton tai" });
            }
            return Ok(new { message = "tao lop thanh cong" });
        }
        [HttpPut("UpdateRole")]
        public IActionResult UpdateRole(int id, RoleRequest rq)
        {
            int rl = _role.UpdateRole(id, rq);
            if (rl == 0)
            {
                return BadRequest(new { message = "khong tim thay lop" });
            }
            return Ok(new { message = "thay doi thanh cong" });
        }
        [HttpDelete("DeleteClass")]
        public IActionResult DeleteRole(int id)
        {
            int login = _role.DeleteRole(id);
            if (login == 0)
            {
                return BadRequest(new { message = "khong tim thay lop" });
            }
            return Ok(new { message = "xoa thanh cong" });
        }

    }
}

