namespace Eleaning_Web.DTO
{
    public class AnswerDTO
    {
        public string? AnswerId { get; set; }
        public string? Content { get; set; }
        public bool RightWrong { get; set; }
        public int IdExam { get; set; }
    }
}
