using System.ComponentModel.DataAnnotations;

namespace WEB_ELEANING.Request
{
    public class LearningResultRequest
    {
        [Required(ErrorMessage = "Nhập sai nhập lại")]
        public string LRId { get; set; } = string.Empty;
        [Required]
        public float ScoreAvg { get; set; }
        [Required]
        public float AttendancePoint { get; set; }
        [Required]
        public float ScoreOralTest { get; set; }
        [Required]
        public float Score { get; set; }
        [Required]
        public float Score15Minunes { get; set; }
        [Required]
        public float ScoreCoefficient2 { get; set; }
        [Required]
        public float ScoreCoefficient3 { get; set; }
        [Required]
        public float SumScoreAvg { get; set; }
        [Required]
        public bool ResultOfEvaluation { get; set; }
        [Required]
        public DateTime DateUpdate { get; set; }
        [Required]
        public int UserId { get; set; }
    }
}
