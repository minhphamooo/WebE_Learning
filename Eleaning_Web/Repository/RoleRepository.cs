using AutoMapper;
using Eleaning_Web.DTO;
using Eleaning_Web.Interface;
using Eleaning_Web.Model;
namespace Eleaning_Web.Repository
{
    public class RoleRepository
    {
        private readonly IMapper admap;
        private readonly DBContext con;


        public RoleRepository(DBContext context, IMapper mapper)
        {
            con = context;
            admap = mapper;
        }



        public bool Delete(int RoleId)
        {
            var DeleteRole = con.Roles.Find(RoleId);
            if (DeleteRole == null)
            {
                return false;
            }
            con.Remove(DeleteRole);
            return true;
        }

        public List<RoleDTO> GetAll()
        {
            var allRole = con.Roles.ToList();
            return admap.Map<List<RoleDTO>>(allRole);
        }



        public RoleDTO GetById(int RoleId)
        {
            var byid = con.Roles.Find(RoleId);
            if (byid == null)
            {
                return null;
            }

            return admap.Map<RoleDTO>(byid);
        }

        public bool Insert(RoleDTO role)
        {
            var insert = con.Roles.Find(role.RoleId);
            if (insert == null)
            {
                con.Roles.Add(admap.Map<Role>(role));
                return true;
            }
            return false;
        }

        public void Save()
        {
            con.SaveChanges();
        }

        public bool Update(RoleDTO role)
        {
            var Update = con.Roles.Find(role.RoleId);
            if (Update != null)
            {
                con.Roles.Update(admap.Map(role, Update));
                return true;
            }
            return false;
        }
    }
}