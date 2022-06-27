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
    public class ClassesController : ControllerBase
    {
        private readonly IClass _class;
        private readonly IMapper _mapper;
        public ClassesController(IClass classs, IMapper mapper)
        {
            _class = classs;
            _mapper = mapper;
        }
        //getall
        [HttpGet]
        public async Task<ActionResult<List<ClassDTO>>> GetAll()
        {
            var model = _class.GetAll();
            if (model == null)
            {
                return new List<ClassDTO>();
            }
            return model.ToList();
        }
        [HttpPost]
        public ActionResult<bool> AddClass(ClassDTO model)
        {
            var check = _class.Insert(model);
            _class.Save();
            return check;

        }

        [HttpPut]
        public ActionResult<bool> UpdateClass(ClassDTO classDTO)
        {
            var check = _class.Update(classDTO);
            _class.Save();
            return check;

        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteClass(string ClassId)
        {
            var check = _class.Delete(ClassId);

            _class.Save();
            return check;

        }
    }
}
