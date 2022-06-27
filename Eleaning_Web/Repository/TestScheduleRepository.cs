using AutoMapper;
using Eleaning_Web.DTO;
using Eleaning_Web.Interface;
using Eleaning_Web.Model;
namespace Eleaning_Web.Repository
{
    public class TestScheduleRepository : ITestSchedule
    {
        private readonly IMapper admap;
        private readonly DBContext con;


        public TestScheduleRepository(DBContext context, IMapper mapper)
        {
            con = context;
            admap = mapper;
        }



        public bool Delete(int TestScheduleId)
        {
            var Delete = con.TestSchedules.Find(TestScheduleId);
            if (Delete == null)
            {
                return false;
            }
            con.Remove(Delete);
            return true;
        }

        public List<TestScheduleDTO> GetAll()
        {
            var All = con.Schedules.ToList();
            return admap.Map<List<TestScheduleDTO>>(All);
        }



        public TestScheduleDTO GetById(int TestScheduleId)
        {
            var byid = con.TestSchedules.Find(TestScheduleId);
            if (byid == null)
            {
                return null;
            }

            return admap.Map<TestScheduleDTO>(byid);
        }

        public bool Insert(TestScheduleDTO testSchedule)
        {
            var insert = con.TestSchedules.Find(testSchedule.TestScheduleId);
            if (insert == null)
            {
                con.TestSchedules.Add(admap.Map<TestSchedule>(testSchedule));
                return true;
            }
            return false;
        }

        public void Save()
        {
            con.SaveChanges();
        }

        public bool Update(TestScheduleDTO testSchedule)
        {
            var Update = con.TestSchedules.Find(testSchedule.TestScheduleId);
            if (Update != null)
            {
                con.TestSchedules.Update(admap.Map(testSchedule, Update));
                return true;
            }
            return false;
        }
    }
}