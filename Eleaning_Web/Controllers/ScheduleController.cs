using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Eleaning_Web.Interface;
using Eleaning_Web.Model;
using AutoMapper;
using Eleaning_Web.Repository;
using Eleaning_Web.DTO;

namespace Eleaning_Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        private readonly ISchedule _sche;
        private readonly IMapper _mapper;
        public ScheduleController(ISchedule schedule, IMapper mapper)
        {
            _sche = schedule;
            _mapper = mapper;
        }
        //getall
        [HttpGet]
        public async Task<ActionResult<List<ScheduleDTO>>> GetAll()
        {
            var schedule = _sche.GetAll();
            if (schedule == null)
            {
                return new List<ScheduleDTO>();
            }
            return schedule.ToList();
        }
        [HttpPost]
        public ActionResult<bool> AddSchedule(ScheduleDTO schedule)
        {
            var check = _sche.Insert(schedule);
            _sche.Save();
            return check;

        }

        [HttpPut]
        public ActionResult<bool> UpdateSchedule(ScheduleDTO schedule)
        {
            var check = _sche.Update(schedule);
            _sche.Save();
            return check;

        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteSchedule(int ScheduleId)
        {
            var check = _sche.Delete(ScheduleId);

            _sche.Save();
            return check;

        }
    }
}
