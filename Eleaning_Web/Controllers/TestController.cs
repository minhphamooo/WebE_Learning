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
    public class TestController : ControllerBase
    {
        private readonly ITest _test;
        private readonly IMapper _mapper;
        public TestController(ITest test, IMapper mapper)
        {
            _test = test;
            _mapper = mapper;
        }
        //getall
        [HttpGet]
        public async Task<ActionResult<List<TestDTO>>> GetAll()
        {
            var test = _test.GetAll();
            if (test == null)
            {
                return new List<TestDTO>();
            }
            return test.ToList();
        }
        [HttpPost]
        public ActionResult<bool> AddTest(TestDTO test)
        {
            var check = _test.Insert(test);
            _test.Save();
            return check;

        }

        [HttpPut]
        public ActionResult<bool> UpdateTest(TestDTO test)
        {
            var check = _test.Update(test);
            _test.Save();
            return check;

        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteTest(int TestId)
        {
            var check = _test.Delete(TestId);

            _test.Save();
            return check;

        }
    }
}
