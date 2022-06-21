using AutoMapper;
using Eleaning_Web.DTO;
using Eleaning_Web.Interface;
using Eleaning_Web.Model;
namespace Eleaning_Web.Repository
{
    public class TestRepository : ITest
    {
        private readonly IMapper admap;
        private readonly DBContext con;


        public TestRepository(DBContext context, IMapper mapper)
        {
            con = context;
            admap = mapper;
        }



        public bool Delete(int TestId)
        {
            var DeleteSchedule = con.Schedules.Find(TestId);
            if (DeleteSchedule == null)
            {
                return false;
            }
            con.Remove(DeleteSchedule);
            return true;
        }

        public List<TestDTO> GetAll()
        {
            var allTest = con.Tests.ToList();
            return admap.Map<List<TestDTO>>(allTest);
        }



        public TestDTO GetById(int TestId)
        {
            var byid = con.Tests.Find(TestId);
            if (byid == null)
            {
                return null;
            }

            return admap.Map<TestDTO>(byid);
        }

        public bool Insert(TestDTO test)
        {
            var insert = con.Tests.Find(test.TestId);
            if (insert == null)
            {
                con.Tests.Add(admap.Map<Test>(test));
                return true;
            }
            return false;
        }

        public void Save()
        {
            con.SaveChanges();
        }

        public bool Update(TestDTO test)
        {
            var Update = con.Tests.Find(test.TestId);
            if (Update != null)
            {
                con.Tests.Update(admap.Map(test, Update));
                return true;
            }
            return false;
        }
    }
}