using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Eleaning_Web.Interface;
using Eleaning_Web.Model;
using AutoMapper;
using Eleaning_Web.Repository;
using Eleaning_Web.Response;
using Eleaning_Web.Services;
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
        public async Task<ActionResult> GetAll()
        {
            try
            {
                var getall = await _answer.GetAll();
                if (getall == null)
                {
                    return NotFound(new { status = "200", message = "Success", data = new List<AnswerResponse>() });
                }
                var response = this._mapper.Map<List<AnswerResponse>>(getall);
                return Ok(new { status = "200", message = "Success", data = response });
            }
            catch (Exception e) { return Problem(e.Message); }

        }
        //getbyid
        [HttpGet("{id}")]
        public async Task<ActionResult> AnswerGetSingle(string id)
        {
            try
            {
                var find = await _answer.AnswerGetSingle(id);
                if (find == null)
                {
                    return NotFound(new { status = "404", Message = "Id dosesn't exsist" });
                }
                var response = this._mapper.Map<AnswerResponse>(find);
                return Ok(new { status = "200", message = "Success", data = response });
            }
            catch (Exception e) { return Problem(e.Message); }

        }
        //add
        [HttpPost]
        public async Task<ActionResult> AnswerInsert(AnswerDTO dto)
        {
            try
            {
                return (await _answer.AnswerInsert(dto) == true ?
                    Ok(new { status = "200", message = "Success" }) :
                    Conflict(new { status = "409", message = "Id aready exsist" }));
            }
            catch (Exception e) { return Problem(e.Message); }
        }
        //update
        [HttpPut("{id}")]
        public async Task<ActionResult> AnswerUpdate(string id, AnswerDTO dto)
        {
            try
            {
                //check id equals
                if (!(id.ToLower().Trim().Equals(dto.Content.ToLower().Trim())))
                {
                    return BadRequest(new { status = "400", message = "Id doesn't equals" });
                }
                return (await _answer.AnswerUpdate(dto) == true ?
                    Ok(new { status = "200", message = "Success" }) :
                    NotFound(new { status = "404", message = "Id doesn't exsist" }));

            }
            catch (Exception e) { return Problem(e.Message); }
        }
        //delete
        [HttpDelete("{id}")]
        public async Task<ActionResult> AnswerDelete(string id)
        {
            try
            {
                return (await _answer.AnswerDelete(id) == true ?
                    Ok(new { status = "200", message = "Success" }) :
                    NotFound(new { status = "404", message = "Id doesn't exsist" }));

            }
            catch (Exception e) { return Problem(e.Message); }
        }

    }
}
