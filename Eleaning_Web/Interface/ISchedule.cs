using Eleaning_Web.DTO;
namespace Eleaning_Web.Interface
{
    public interface ISchedule
    {
        List<ScheduleDTO> GetAll();
        ScheduleDTO GetById(int ScheduleId);
        bool Insert(ScheduleDTO schedule);
        bool Update(ScheduleDTO schedule);
        bool Delete(int ScheduleId);
        void Save();
    }
}
