using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Eleaning_Web.Model
{
    public class Answer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? AnswerId { get; set; }
        public string? Content { get; set; }
        public bool RightWrong { get; set; }

        public int IdExam { get; set; }
        public Exam? exam { get; set; }
    }
}
