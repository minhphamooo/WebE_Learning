using WEB_ELEANING.Model;
using WEB_ELEANING.Request;
namespace WEB_ELEANING.Interface
{
    public interface IClass
    {
        List<Class> GetAllClass();
        int AddClass(ClassRequest request);
        int DetailClass(int id);
        int DeleteClass(int id);
        int UpdateClass(int id, ClassRequest request);
    }
}
