using AutoMapper;
using Eleaning_Web.DTO;
using Eleaning_Web.Model;
using Eleaning_Web.Repository;
using Eleaning_Web.Response;
namespace Eleaning_Web.Mapper
{
    public class Map : Profile
    {
        public Map()
        {
            this.CreateMap<AnswerDTO, AnswerResponse>();
            this.CreateMap<Answer, AnswerDTO>();
            this.CreateMap<AnswerDTO, Answer>();
        }
    }
}
