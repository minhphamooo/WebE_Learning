using System.ComponentModel.DataAnnotations;

namespace WEB_ELEANING.Request
{
    public class QuestionRequest
    {
        [Required(ErrorMessage = "Nhập sai nhập lại!!!")]
        public string QuestionId { get; set; } = string.Empty;
        [Required]
        public string QuestionName { get; set; } = string.Empty;
        [Required]
        public string AnswerA { get; set; } = string.Empty;
        [Required]
        public string AnswerB { get; set; } = string.Empty;
        [Required]
        public string AnswerC { get; set; } = string.Empty;
        [Required]
        public string AnswerD { get; set; } = string.Empty;
        [Required]
        public string AnswerCorrect { get; set; } = string.Empty;
        [Required]
        public int ContentId { get; set; }
    }
}
