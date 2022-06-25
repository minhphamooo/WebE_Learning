using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEB_ELEANING.Interface;
using WEB_ELEANING.Model;
using WEB_ELEANING.Request;

namespace WEB_ELEANING.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        private readonly ISchedule _schedule;
        public ScheduleController(ISchedule sce)
        {
            _schedule = sce;
        }
        [HttpGet("GetAllSemester")]
        public ActionResult<IEnumerable<Schedule>> GetAllSchedule()
        {
            var cls = _schedule.GetAllSchedule();
            return Ok(cls);
        }
        [HttpPost("AddSchedule")]
        public IActionResult AddSchedule(ScheduleRequest request)
        {
            var add = _schedule.AddSchedule(request);
            if (add == 0)
            {
                return BadRequest(new { message = "đã tồn tại" });
            }
            return Ok(new { message = "tạo thành công" });
        }
        [HttpPut("UpdateSchedule")]
        public IActionResult UpdateSchedule(int id, ScheduleRequest request)
        {
            int rl = _schedule.UpdateSchedule(id, request);
            if (rl == 0)
            {
                return BadRequest(new { message = "Không tìm thấy" });
            }
            return Ok(new { message = "Cập nhật thành công" });
        }
        [HttpDelete("DeleteSchedule")]
        public IActionResult DeleteSchedule(int id)
        {
            int login = _schedule.DeleteSchedule(id);
            if (login == 0)
            {
                return BadRequest(new { message = "Không tìm thấy" });
            }
            return Ok(new { message = "Đã xóa" });
        }

    }
}

