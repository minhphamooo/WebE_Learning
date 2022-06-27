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
    public class AnswerController : ControllerBase
    {
        private readonly IAnswer _answer;
        private readonly IMapper _mapper;
        public AnswerController(IAnswer answers, IMapper mapper)
        {
            _answer = answers;
            _mapper = mapper;
        }
        //getall
        [HttpGet]
        public async Task<ActionResult<List<AnswerDTO>>> GetAll()
        {
            var answer = _answer.GetAll();
            if (answer == null)
            {
                return new List<AnswerDTO>();
            }
            return answer.ToList();
        }
        [HttpPost]
        public ActionResult<bool> AddAnswer(AnswerDTO answer)
        {
            var check = _answer.Insert(answer);
            _answer.Save();
            return check;

        }

        [HttpPut]
        public ActionResult<bool> UpdateAnswer(AnswerDTO answer)
        {
            var check = _answer.Update(answer);
            _answer.Save();
            return check;

        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteAnswer(string AnswerId)
        {
            var check = _answer.Delete(AnswerId);

            _answer.Save();
            return check;

        }
    }
}