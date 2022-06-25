using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WEB_ELEANING.Model
{
    public class Schedule
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ScheduleId { get; set; }
        public float ScheduleName { get; set; }
        public DayOfWeek DayLearn { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
    }
}
