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
    public class LearningResultController : ControllerBase
    {
        private readonly ILearningResult _leaR;
        private readonly IMapper _mapper;
        public LearningResultController(ILearningResult learningResult, IMapper mapper)
        {
            _leaR = learningResult;
            _mapper = mapper;
        }
        //getall
        [HttpGet]
        public async Task<ActionResult<List<LearningResultDTO>>> GetAll()
        {
            var learningResult = _leaR.GetAll();
            if (learningResult == null)
            {
                return new List<LearningResultDTO>();
            }
            return learningResult.ToList();
        }
        [HttpPost]
        public ActionResult<bool> AddLearning(LearningResultDTO learningResult)
        {
            var check = _leaR.Insert(learningResult);
            _leaR.Save();
            return check;

        }

        [HttpPut]
        public ActionResult<bool> UpdateLearning(LearningResultDTO learningResult)
        {
            var check = _leaR.Update(learningResult);
            _leaR.Save();
            return check;

        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteLearning(string LRId)
        {
            var check = _leaR.Delete(LRId);

            _leaR.Save();
            return check;

        }
    }
}