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
    public class SubjectController : ControllerBase
    {
        private readonly ISubject _subject;
        private readonly IMapper _mapper;
        public SubjectController(ISubject subject, IMapper mapper)
        {
            _subject = subject;
            _mapper = mapper;
        }
        //getall
        [HttpGet]
        public async Task<ActionResult<List<SubjectDTO>>> GetAll()
        {
            var Subject = _subject.GetAll();
            if (Subject == null)
            {
                return new List<SubjectDTO>();
            }
            return Subject.ToList();
        }
        [HttpPost]
        public ActionResult<bool> AddSubject(SubjectDTO subject)
        {
            var check = _subject.Insert(subject);
            _subject.Save();
            return check;

        }

        [HttpPut]
        public ActionResult<bool> UpdateSubject(SubjectDTO subject)
        {
            var check = _subject.Update(subject);
            _subject.Save();
            return check;

        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteSubject(string SubjectId)
        {
            var check = _subject.Delete(SubjectId);

            _subject.Save();
            return check;

        }
    }
}