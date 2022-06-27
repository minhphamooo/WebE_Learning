namespace Eleaning_Web.DTO
{
    public class ScheduleDTO
    {
        public int ScheduleId { get; set; }
        public DateTime Time { get; set; }
        public DateTime DayLearn { get; set; }
        public int IdSubject { get; set; }
    }
}
