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
    public class TestScheduleController : ControllerBase
    {
        private readonly ITestSchedule _Tsubject;
        private readonly IMapper _mapper;
        public TestScheduleController(ITestSchedule testSchedule, IMapper mapper)
        {
            _Tsubject = testSchedule;
            _mapper = mapper;
        }
        //getall
        [HttpGet]
        public async Task<ActionResult<List<TestScheduleDTO>>> GetAll()
        {
            var Subject = _Tsubject.GetAll();
            if (Subject == null)
            {
                return new List<TestScheduleDTO>();
            }
            return Subject.ToList();
        }
        [HttpPost]
        public ActionResult<bool> AddTestSchedule(TestScheduleDTO testSchedule)
        {
            var check = _Tsubject.Insert(testSchedule);
            _Tsubject.Save();
            return check;

        }

        [HttpPut]
        public ActionResult<bool> UpdateSubject(TestScheduleDTO testSchedule)
        {
            var check = _Tsubject.Update(testSchedule);
            _Tsubject.Save();
            return check;

        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteSubject(int SubjectId)
        {
            var check = _Tsubject.Delete(SubjectId);

            _Tsubject.Save();
            return check;

        }
    }
}