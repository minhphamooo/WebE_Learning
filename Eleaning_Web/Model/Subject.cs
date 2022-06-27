using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eleaning_Web.Model
{
    public class Subject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int Period { get; set; }
        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }
        public List<Document> Documents { get; set; }
        public List<DetailSubject> DetailSubjects { get; set; }
        public List<ContentTest> ContentTest { get; set; }
    }
}
