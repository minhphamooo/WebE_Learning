using WEB_ELEANING.Interface;
using WEB_ELEANING.Model;
using WEB_ELEANING.Request;

namespace WEB_ELEANING.Repository
{
    public class ScheduleRepository : ISchedule
    {
        private readonly DBContext _context;
        public ScheduleRepository(DBContext context)
        {
            _context = context;
        }
        public int AddSchedule(ScheduleRequest request)
        {
            var name = _context.Schedule.FirstOrDefault(u => u.ScheduleName == request.ScheduleName);
            if (name != null)
            {
                return 0;
            }
            else
            {
                var doc = new Schedule
                {
                    ScheduleName = request.ScheduleName,
                    DayLearn = request.DayLearn,
                    Start = request.Start,
                    End = request.End
                };
                _context.Schedule.Add(doc);
                _context.SaveChanges();
                return 1;
            }
        }

        public int DeleteSchedule(int id)
        {
            var doc = _context.Schedule.FirstOrDefault(u => u.ScheduleId == id);
            if (doc == null)
            {
                return 0;
            }
            else
            {
                _context.Schedule.Remove(doc);
                _context.SaveChanges();
                return 1;
            }
        }
        public int UpdateSchedule(int id, ScheduleRequest request)
        {
            var doc = _context.Schedule.FirstOrDefault(u => u.ScheduleId == id);
            if (doc != null)
            {
                doc.ScheduleName = request.ScheduleName;
                doc.DayLearn = request.DayLearn;
                doc.Start = request.Start;
                doc.End = request.End;
                _context.Schedule.Update(doc);
                _context.SaveChanges();
                return 1;
            }
            else
            {

                return 0;
            }
        }
        public int DetailSchedule(int id)
        {
            var doc = _context.Schedule.Any(m => m.ScheduleId == id);
            if (doc == null)
                return 0;
            return 1;
        }

        public List<Schedule> GetAllSchedule()
        {
            return _context.Schedule.ToList();
        }


    }
}