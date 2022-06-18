using AutoMapper;
using Eleaning_Web.DTO;
using Eleaning_Web.Interface;
using Eleaning_Web.Model;
namespace Eleaning_Web.Repository
{
    public class ClassRepository : IClass
    {
        private readonly IMapper admap;
        private readonly DBContext con;


        public ClassRepository(DBContext context, IMapper mapper)
        {
            con = context;
            admap = mapper;
        }



        public bool Delete(string ClassId)
        {
            var DeleteClass = con.Answers.Find(ClassId);
            if (DeleteClass == null)
            {
                return false;
            }
            con.Remove(DeleteClass);
            return true;
        }

        public List<ClassDTO> GetAll()
        {
            var allClass = con.Classes.ToList();
            return admap.Map<List<ClassDTO>>(allClass);
        }



        public ClassDTO GetById(string ClassId)
        {
            var byid = con.Classes.Find(ClassId);
            if (byid == null)
            {
                return null;
            }

            return admap.Map<ClassDTO>(byid);
        }

        public bool Insert(ClassDTO classDTO)
        {
            var insert = con.Classes.Find(classDTO.ClassId);
            if (insert == null)
            {
                con.Classes.Add(admap.Map<Class>(classDTO));
                return true;
            }
            return false;
        }

        public void Save()
        {
            con.SaveChanges();
        }

        public bool Update(ClassDTO classDTO)
        {
            var Update = con.Classes.Find(classDTO.ClassId);
            if (Update != null)
            {
                con.Classes.Update(admap.Map(classDTO, Update));
                return true;
            }
            return false;
        }
    }
}