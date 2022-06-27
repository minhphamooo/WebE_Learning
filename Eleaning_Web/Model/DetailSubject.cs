using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Eleaning_Web.Model
{
    public class DetailSubject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DetailId { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }
        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
