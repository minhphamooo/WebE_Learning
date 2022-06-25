using WEB_ELEANING.Model;
using WEB_ELEANING.Request;

namespace WEB_ELEANING.Interface
{
    public interface ISchedule
    {
        List<Schedule> GetAllSchedule();
        int AddSchedule(ScheduleRequest request);
        int DetailSchedule(int id);
        int DeleteSchedule(int id);
        int UpdateSchedule(int id, ScheduleRequest request);
    }
}
