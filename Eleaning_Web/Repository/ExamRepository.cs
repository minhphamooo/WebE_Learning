﻿using AutoMapper;
using Eleaning_Web.DTO;
using Eleaning_Web.Interface;
using Eleaning_Web.Model;
namespace Eleaning_Web.Repository
{
    public class ExamRepository : IExam
    {
        private readonly IMapper admap;
        private readonly DBContext con;


        public ExamRepository(DBContext context, IMapper mapper)
        {
            con = context;
            admap = mapper;
        }



        public bool Delete(int ExamId)
        {
            var DeleteExam = con.Answers.Find(ExamId);
            if (DeleteExam == null)
            {
                return false;
            }
            con.Remove(DeleteExam);
            return true;
        }

        public List<ExamDTO> GetAll()
        {
            var allExam = con.Exams.ToList();
            return admap.Map<List<ExamDTO>>(allExam);
        }



        public ExamDTO GetById(int ExamId)
        {
            var byid = con.Exams.Find(ExamId);
            if (byid == null)
            {
                return null;
            }

            return admap.Map<ExamDTO>(byid);
        }

        public bool Insert(ExamDTO exam)
        {
            var insert = con.Exams.Find(exam.ExamId);
            if (insert == null)
            {
                con.Exams.Add(admap.Map<Exam>(exam));
                return true;
            }
            return false;
        }

        public void Save()
        {
            con.SaveChanges();
        }

        public bool Update(ExamDTO exam)
        {
            var Update = con.Exams.Find(exam.ExamId);
            if (Update != null)
            {
                con.Exams.Update(admap.Map(exam, Update));
                return true;
            }
            return false;
        }
    }
}