using AutoMapper;
using Eleaning_Web.DTO;
using Eleaning_Web.Interface;
using Eleaning_Web.Model;
namespace Eleaning_Web.Repository
{
    internal class AnswerRepository : IAnswer
    {
        private readonly IMapper admap;
        private readonly DBContext con;


        public AnswerRepository(DBContext context, IMapper mapper)
        {
            con = context;
            admap = mapper;
        }

       

        public bool Delete(string AnswerId)
        {
            var DeleteAnswer = con.Answers.Find(AnswerId);
            if (DeleteAnswer == null)
            {
                return false;
            }
            con.Remove(DeleteAnswer);
            return true;
        }

        public List<AnswerDTO> GetAll()
        {
            var allAnswer = con.Answers.ToList();
            return admap.Map<List<AnswerDTO>>(allAnswer);
        }

      

        public AnswerDTO GetById(string AnswerId)
        {
            var byid = con.Answers.Find(AnswerId);
            if (byid == null)
            {
                return null;
            }

            return admap.Map<AnswerDTO>(byid);
        }

        public bool Insert(AnswerDTO answer)
        {
            var insertAnswer = con.Answers.Find(answer.AnswerId);
            if (insertAnswer == null)
            {
                con.Answers.Add(admap.Map<Answer>(answer));
                return true;
            }
            return false;
        }

        public void Save()
        {
            con.SaveChanges();
        }

        public bool Update(AnswerDTO answer)
        {
            var UpdateCourse = con.Answers.Find(answer.AnswerId);
            if (UpdateCourse != null)
            {
                con.Answers.Update(admap.Map(answer, UpdateCourse));
                return true;
            }
            return false;
        }
    }
}
