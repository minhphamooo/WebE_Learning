using WEB_ELEANING.Model;
using WEB_ELEANING.Request;

namespace WEB_ELEANING.Interface
{
    public interface ISubject
    {
        List<Subject> GetAllSubject();
        int AddSubject(SubjectRequest request);
        int DetailSubject(int id);
        int DeleteSubject(int id);
        int UpdateSubject(int id, SubjectRequest request);
    }
}
