using AutoMapper;
using Eleaning_Web.DTO;
using Eleaning_Web.Model;
using Eleaning_Web.Repository;

namespace Eleaning_Web.Mapper
{
    public class Map : Profile
    {
        public Map()
        {
            //Answer
            this.CreateMap<AnswerDTO, Answer>();
            this.CreateMap<Answer, AnswerDTO>();
            //Class
            this.CreateMap<ClassDTO, Class>();
            this.CreateMap<Class, ClassDTO>();
            //ContentTest
            this.CreateMap<ContentTestDTO, ContentTest>();
            this.CreateMap<ContentTest, ContentTestDTO>();
        }
    }
}
