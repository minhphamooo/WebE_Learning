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
    public class QuestionController : ControllerBase
    {
        private readonly IQuestion _Que;
        private readonly IMapper _mapper;
        public QuestionController(IQuestion question, IMapper mapper)
        {
            _Que = question;
            _mapper = mapper;
        }
        //getall
        [HttpGet]
        public async Task<ActionResult<List<QuestionDTO>>> GetAll()
        {
            var Question = _Que.GetAll();
            if (Question == null)
            {
                return new List<QuestionDTO>();
            }
            return Question.ToList();
        }
        [HttpPost]
        public ActionResult<bool> AddQuestion(QuestionDTO question)
        {
            var check = _Que.Insert(question);
            _Que.Save();
            return check;

        }

        [HttpPut]
        public ActionResult<bool> UpdateQuestion(QuestionDTO question)
        {
            var check = _Que.Update(question);
            _Que.Save();
            return check;

        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteQuestion(string QuestionId)
        {
            var check = _Que.Delete(QuestionId);

            _Que.Save();
            return check;

        }
    }
}