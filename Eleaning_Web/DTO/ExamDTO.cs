namespace Eleaning_Web.DTO
{
    public class ExamDTO
    {
        public int ExamId { get; set; }
        public string? NameExam { get; set; }
        public string? Content { get; set; }
        public string? TypeTest { get; set; }
        public DateTime Date { get; set; }
        public int Time { get; set; }
        public string? Description { get; set; }
        public string? ExamCode { get; set; }
        public bool Status { get; set; }
        public int IdSubject { get; set; }
    }
}
