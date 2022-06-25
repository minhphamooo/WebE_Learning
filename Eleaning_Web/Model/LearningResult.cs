using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WEB_ELEANING.Model
{
    public class LearningResult
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string LRId { get; set; }
        public float ScoreAvg { get; set; }
        public float AttendancePoint { get; set; }
        public float ScoreOralTest { get; set; }
        public float Score { get; set; }
        public float Score15Minunes { get; set; }
        public float ScoreCoefficient2 { get; set; }
        public float ScoreCoefficient3 { get; set; }
        public float SumScoreAvg { get; set; }
        public bool ResultOfEvaluation { get; set; }
        public DateTime DateUpdate { get; set; }
        public int UserId { get; set; }
        public User user { get; set; }
    }
}
