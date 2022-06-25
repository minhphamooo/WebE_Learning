using System.ComponentModel.DataAnnotations;

namespace WEB_ELEANING.Request
{
    public class ScheduleRequest
    {
        [Required(ErrorMessage = "Nhập sai nhập lại!!!")]
        public int ScheduleId { get; set; }
        [Required]
        public float ScheduleName { get; set; }
        [Required]
        public DayOfWeek DayLearn { get; set; }
        [Required]
        public string Start { get; set; }
        [Required]
        public string End { get; set; }
        
    }
}
