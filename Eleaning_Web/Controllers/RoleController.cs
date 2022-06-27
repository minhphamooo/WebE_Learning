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
    public class RoleController : ControllerBase
    {
        private readonly IRole _role;
        private readonly IMapper _mapper;
        public RoleController(IRole role, IMapper mapper)
        {
            _role = role;
            _mapper = mapper;
        }
        //getall
        [HttpGet]
        public async Task<ActionResult<List<RoleDTO>>> GetAll()
        {
            var roles = _role.GetAll();
            if (roles == null)
            {
                return new List<RoleDTO>();
            }
            return roles.ToList();
        }
        [HttpPost]
        public ActionResult<bool> AddRole(RoleDTO role)
        {
            var check = _role.Insert(role);
            _role.Save();
            return check;

        }

        [HttpPut]
        public ActionResult<bool> UpdateRole(RoleDTO role)
        {
            var check = _role.Update(role);
            _role.Save();
            return check;

        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteRole(int RoleId)
        {
            var check = _role.Delete(RoleId);

            _role.Save();
            return check;

        }
    }
}
