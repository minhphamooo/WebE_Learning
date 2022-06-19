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
    public class ContentTestController : ControllerBase
    {
        private readonly IContentTest _contentTest;
        private readonly IMapper _mapper;
        public ContentTestController(IContentTest contentTest, IMapper mapper)
        {
            _contentTest = contentTest;
            _mapper = mapper;
        }
        //getall
        [HttpGet]
        public async Task<ActionResult<List<ContentTestDTO>>> GetAll()
        {
            var model = _contentTest.GetAll();
            if (model == null)
            {
                return new List<ContentTestDTO>();
            }
            return model.ToList();
        }
        [HttpPost]
        public ActionResult<bool> AddContentTest(ContentTestDTO model)
        {
            var check = _contentTest.Insert(model);
            _contentTest.Save();
            return check;

        }

        [HttpPut]
        public ActionResult<bool> UpdateContentTest(ContentTestDTO contentTest)
        {
            var check = _contentTest.Update(contentTest);
            _contentTest.Save();
            return check;

        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteContentTest(int ContentId)
        {
            var check = _contentTest.Delete(ContentId);

            _contentTest.Save();
            return check;

        }
    }
}