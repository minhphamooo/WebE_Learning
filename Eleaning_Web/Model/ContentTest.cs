using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Eleaning_Web.Model
{
    public class ContentTest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContentId { get; set; }
        public string Content { get; set; }
        public int Result { get; set; }
        public List<Question> Questions { get; set; }
        public int ExamID { get; set; }
        public Exam Exam { get; set; }
        public int SubjectID { get; set; }
        public Subject Subject { get; set; }
    }
}
