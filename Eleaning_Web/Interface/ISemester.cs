using WEB_ELEANING.Model;
using WEB_ELEANING.Request;

namespace WEB_ELEANING.Interface
{
    public interface ISemester
    {
        List<Semester> GetAllSemester();
        int AddSemester(SemesterRequest request);
        int DetailSemester(int id);
        int DeleteSemester(int id);
        int UpdateSemester(int id, SemesterRequest request);
    }
}
