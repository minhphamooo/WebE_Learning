using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WEB_ELEANING.Model
{
    public class Exam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExamId { get; set; }
        public string NameExam { get; set; }
        public string Content { get; set; }
        public string TypeTest { get; set; }
        public DateTime Date { get; set; }
        public int Time { get; set; }
        public string Description  { get; set; }
        public string ExamCode  { get; set; }
        public bool Status { get; set; }
        public List<ContentTest> contentTests { get; set; }
        public ResultExam ResultExam { get; set; }

    }
}
