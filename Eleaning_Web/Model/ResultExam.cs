using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WEB_ELEANING.Model
{
    public class ResultExam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ResultExamId { get; set; }
        public float Score { get; set; }
        public DateTime ExamDate { get; set; }
        
        public int UserId { get; set; }
        public User User{ get; set; }

        public int ExamId { get; set; }
        public Exam Exam { get; set; }

    }
}
