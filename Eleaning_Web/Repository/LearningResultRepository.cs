using AutoMapper;
using Eleaning_Web.DTO;
using Eleaning_Web.Interface;
using Eleaning_Web.Model;
namespace Eleaning_Web.Repository
{
    public class LearningResultRepository : ILearningResult
    {
        private readonly IMapper admap;
        private readonly DBContext con;


        public LearningResultRepository(DBContext context, IMapper mapper)
        {
            con = context;
            admap = mapper;
        }



        public bool Delete(string LRId)
        {
            var DeleteLearning = con.LearningResults.Find(LRId);
            if (DeleteLearning == null)
            {
                return false;
            }
            con.Remove(DeleteLearning);
            return true;
        }

        public List<LearningResultDTO> GetAll()
        {
            var allLearning = con.LearningResults.ToList();
            return admap.Map<List<LearningResultDTO>>(allLearning);
        }



        public LearningResultDTO GetById(string LRId)
        {
            var byid = con.LearningResults.Find(LRId);
            if (byid == null)
            {
                return null;
            }

            return admap.Map<LearningResultDTO>(byid);
        }

        public bool Insert(LearningResultDTO learningResult)
        {
            var insert = con.LearningResults.Find(learningResult.LRId);
            if (insert == null)
            {
                con.LearningResults.Add(admap.Map<LearningResult>(learningResult));
                return true;
            }
            return false;
        }

        public void Save()
        {
            con.SaveChanges();
        }

        public bool Update(LearningResultDTO learningResult)
        {
            var Update = con.LearningResults.Find(learningResult.LRId);
            if (Update != null)
            {
                con.LearningResults.Update(admap.Map(learningResult, Update));
                return true;
            }
            return false;
        }
    }
}