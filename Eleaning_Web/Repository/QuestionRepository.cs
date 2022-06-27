using AutoMapper;
using Eleaning_Web.DTO;
using Eleaning_Web.Interface;
using Eleaning_Web.Model;
namespace Eleaning_Web.Repository
{
    public class QuestionRepository : IQuestion
    {
        private readonly IMapper admap;
        private readonly DBContext con;


        public QuestionRepository(DBContext context, IMapper mapper)
        {
            con = context;
            admap = mapper;
        }



        public bool Delete(string QuestionId)
        {
            var DeleteQuestion = con.Questions.Find(QuestionId);
            if (DeleteQuestion == null)
            {
                return false;
            }
            con.Remove(DeleteQuestion);
            return true;
        }

        public List<QuestionDTO> GetAll()
        {
            var allQuestionId = con.Questions.ToList();
            return admap.Map<List<QuestionDTO>>(allQuestionId);
        }



        public QuestionDTO GetById(string QuestionId)
        {
            var byid = con.Questions.Find(QuestionId);
            if (byid == null)
            {
                return null;
            }

            return admap.Map<QuestionDTO>(byid);
        }

        public bool Insert(QuestionDTO question)
        {
            var insert = con.Questions.Find(question.QuestionId);
            if (insert == null)
            {
                con.Exams.Add(admap.Map<Exam>(question));
                return true;
            }
            return false;
        }

        public void Save()
        {
            con.SaveChanges();
        }

        public bool Update(QuestionDTO question)
        {
            var Update = con.Questions.Find(question.QuestionId);
            if (Update != null)
            {
                con.Questions.Update(admap.Map(question, Update));
                return true;
            }
            return false;
        }
    }
}