namespace WEB_ELEANING.Request
{
    public class ResultExamRequest
    {
        public int ResultExamId { get; set; }
        public float Score { get; set; }
        public DateTime ExamDate { get; set; }

        public int UserId { get; set; }
        public int ExamId { get; set; }
    }
}
