using Eleaning_Web.Interface;
using Eleaning_Web.Model;
namespace Eleaning_Web.Repository
{
internal class AnswerRepository : BaseRepository<Answer>, IServiceAnswer
    {
    public AnswerRepository(DBContext data) : base(data)
    {
    }
}
}
