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
            //Document
            this.CreateMap<DocumentDTO, Document>();
            this.CreateMap<Document, DocumentDTO>();
            //Exam
            this.CreateMap<ExamDTO, Exam>();
            this.CreateMap<Exam, ExamDTO>();
            //learningResult
            this.CreateMap<LearningResultDTO, LearningResult>();
            this.CreateMap<LearningResult, LearningResultDTO>();
            //Question
            this.CreateMap<QuestionDTO, Question>();
            this.CreateMap<Question, QuestionDTO>();
            //Schedule
            this.CreateMap<ScheduleDTO, Schedule>();
            this.CreateMap<Schedule, ScheduleDTO>();
            //Test
            this.CreateMap<TestDTO, Test>();
            this.CreateMap<Test, TestDTO>();
            //Subject
            this.CreateMap<SubjectDTO, Subject>();
            this.CreateMap<Subject, SubjectDTO>();
            //TestSchedule
            this.CreateMap<TestScheduleDTO, TestSchedule>();
            this.CreateMap<TestSchedule, TestScheduleDTO>();
            //Role
            this.CreateMap<RoleDTO, Role>();
            this.CreateMap<Role, RoleDTO>();
        }
    }
}
