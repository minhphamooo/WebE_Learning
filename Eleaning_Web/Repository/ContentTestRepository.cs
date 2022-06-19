using AutoMapper;
using Eleaning_Web.DTO;
using Eleaning_Web.Interface;
using Eleaning_Web.Model;
namespace Eleaning_Web.Repository
{
    public class ContentTestRepository : IContentTest
    {
        private readonly IMapper admap;
        private readonly DBContext con;


        public ContentTestRepository(DBContext context, IMapper mapper)
        {
            con = context;
            admap = mapper;
        }



        public bool Delete(int ContentId)
        {
            var DeleteContent = con.ContentTests.Find(ContentId);
            if (DeleteContent == null)
            {
                return false;
            }
            con.Remove(DeleteContent);
            return true;
        }

        public List<ContentTestDTO> GetAll()
        {
            var allContent = con.ContentTests.ToList();
            return admap.Map<List<ContentTestDTO>>(allContent);
        }



        public ContentTestDTO GetById(int ContentId)
        {
            var byid = con.ContentTests.Find(ContentId);
            if (byid == null)
            {
                return null;
            }

            return admap.Map<ContentTestDTO>(byid);
        }

        public bool Insert(ContentTestDTO contentTest)
        {
            var insert = con.ContentTests.Find(contentTest.ContentId);
            if (insert == null)
            {
                con.ContentTests.Add(admap.Map<ContentTest>(contentTest));
                return true;
            }
            return false;
        }

        public void Save()
        {
            con.SaveChanges();
        }

        public bool Update(ContentTestDTO contentTest)
        {
            var Update = con.ContentTests.Find(contentTest.ContentId);
            if (Update != null)
            {
                con.ContentTests.Update(admap.Map(contentTest, Update));
                return true;
            }
            return false;
        }
    }
}