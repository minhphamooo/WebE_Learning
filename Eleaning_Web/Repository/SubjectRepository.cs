using AutoMapper;
using Eleaning_Web.DTO;
using Eleaning_Web.Interface;
using Eleaning_Web.Model;
namespace Eleaning_Web.Repository
{
    public class SubjectRepository : ISubject
    {
        private readonly IMapper admap;
        private readonly DBContext con;


        public SubjectRepository(DBContext context, IMapper mapper)
        {
            con = context;
            admap = mapper;
        }



        public bool Delete(string SubjectId)
        {
            var DeleteSubject = con.Subjects.Find(SubjectId);
            if (DeleteSubject == null)
            {
                return false;
            }
            con.Remove(DeleteSubject);
            return true;
        }

        public List<SubjectDTO> GetAll()
        {
            var AllSubject = con.Subjects.ToList();
            return admap.Map<List<SubjectDTO>>(AllSubject);
        }



        public SubjectDTO GetById(string SubjectId)
        {
            var byid = con.Subjects.Find(SubjectId);
            if (byid == null)
            {
                return null;
            }

            return admap.Map<SubjectDTO>(byid);
        }

        public bool Insert(SubjectDTO subject)
        {
            var insert = con.Subjects.Find(subject.SubjectId);
            if (insert == null)
            {
                con.Subjects.Add(admap.Map<Subject>(subject));
                return true;
            }
            return false;
        }

        public void Save()
        {
            con.SaveChanges();
        }

        public bool Update(SubjectDTO subject)
        {
            var Update = con.Subjects.Find(subject.SubjectId);
            if (Update != null)
            {
                con.Subjects.Update(admap.Map(subject, Update));
                return true;
            }
            return false;
        }
    }
}