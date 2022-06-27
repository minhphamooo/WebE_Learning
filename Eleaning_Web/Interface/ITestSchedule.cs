using Eleaning_Web.DTO;
namespace Eleaning_Web.Interface
{
    public interface ITestSchedule
    {
        List<TestScheduleDTO> GetAll();
        TestScheduleDTO GetById(int TestScheduleId);
        bool Insert(TestScheduleDTO testSchedule);
        bool Update(TestScheduleDTO testSchedule);
        bool Delete(int TestScheduleId);
        void Save();
    }
}
