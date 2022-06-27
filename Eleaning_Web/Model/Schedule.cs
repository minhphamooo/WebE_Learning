using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Eleaning_Web.Model
{
    public class Schedule
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ScheduleId { get; set; }
        public float ScheduleName { get; set; }
        public DayOfWeek DayLearn { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
    }
}
