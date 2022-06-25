using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WEB_ELEANING.Model
{
    public class TypeExam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string TypeExamId { get; set; }
        public string TypeExamName { get; set; }
        public List<Exam> Exams { get; set; }
    }
}
