using Eleaning_Web.DTO;
namespace Eleaning_Web.Interface
{
    public interface ITest
    {
        List<TestDTO> GetAll();
        TestDTO GetById(int TestId);
        bool Insert(TestDTO test);
        bool Update(TestDTO test);
        bool Delete(int TestId);
        void Save();
    }
}
