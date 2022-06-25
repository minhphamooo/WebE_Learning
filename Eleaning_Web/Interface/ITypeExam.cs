using WEB_ELEANING.Model;
using WEB_ELEANING.Request;

namespace WEB_ELEANING.Interface
{
    public interface ITypeExam
    {
        List<TypeExam> GetTypeExam();
        int AddTypeExam(TypeExamRequest request);
        int DetailTypeExam(string id);
        int DeleteTypeExam(string id);
        int UpdateTypeExam(string id, TypeExamRequest request);
    }
}
