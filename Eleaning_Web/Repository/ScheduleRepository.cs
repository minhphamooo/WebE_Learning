using AutoMapper;
using Eleaning_Web.DTO;
using Eleaning_Web.Interface;
using Eleaning_Web.Model;
namespace Eleaning_Web.Repository
{
    public class ScheduleRepository : ISchedule
    {
        private readonly IMapper admap;
        private readonly DBContext con;


        public ScheduleRepository(DBContext context, IMapper mapper)
        {
            con = context;
            admap = mapper;
        }



        public bool Delete(int ScheduleId)
        {
            var DeleteSchedule = con.Schedules.Find(ScheduleId);
            if (DeleteSchedule == null)
            {
                return false;
            }
            con.Remove(DeleteSchedule);
            return true;
        }

        public List<ScheduleDTO> GetAll()
        {
            var allSchedule = con.Schedules.ToList();
            return admap.Map<List<ScheduleDTO>>(allSchedule);
        }



        public ScheduleDTO GetById(int ScheduleId)
        {
            var byid = con.Schedules.Find(ScheduleId);
            if (byid == null)
            {
                return null;
            }

            return admap.Map<ScheduleDTO>(byid);
        }

        public bool Insert(ScheduleDTO schedule)
        {
            var insert = con.Schedules.Find(schedule.ScheduleId);
            if (insert == null)
            {
                con.Schedules.Add(admap.Map<Schedule>(schedule));
                return true;
            }
            return false;
        }

        public void Save()
        {
            con.SaveChanges();
        }

        public bool Update(ScheduleDTO schedule)
        {
            var Update = con.Schedules.Find(schedule.ScheduleId);
            if (Update != null)
            {
                con.Schedules.Update(admap.Map(schedule, Update));
                return true;
            }
            return false;
        }
    }
}