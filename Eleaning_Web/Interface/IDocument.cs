using WEB_ELEANING.Request;
using WEB_ELEANING.Model;

namespace WEB_ELEANING.Interface
{
    public interface IDocument
    {
        List<Document> GetAllDocument();
        int AddDocument(DocumentRequest request);
        int DetailDocument(int id);
        int DeleteDocument(int id);
        int UpdateDocument(int id, DocumentRequest request);
    }
}
