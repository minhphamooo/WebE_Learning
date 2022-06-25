using System.ComponentModel.DataAnnotations;

namespace WEB_ELEANING.Request
{
    public class ContentTestRequest
    {
        [Required(ErrorMessage = "Nhập sai nhập lại!!!")]
        public int ContentId { get; set; }
        [Required]
        public string Content { get; set; } = string.Empty;
        [Required]
        public int Result { get; set; }
        [Required]
        public int ExamID { get; set; }
        [Required]
        public int SubjectID { get; set; }
       
    }
}
