using WEB_ELEANING.Model;
using WEB_ELEANING.Request;
namespace WEB_ELEANING.Interface

{
    public interface IContentTest
    {
        List<ContentTest> GetAllContentTest();
        int AddContentTest(ContentTestRequest request);
        int DetailContentTest(int id);
        int DeleteContentTest(int id);
        int UpdateContentTest(int id, ContentTestRequest request);
    }
}
