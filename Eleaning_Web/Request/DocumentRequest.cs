using System.ComponentModel.DataAnnotations;

namespace WEB_ELEANING.Request
{
    public class DocumentRequest
    {
        [Required(ErrorMessage = "Nhập sai nhập lại!!!")]
        public string DocumentName { get; set; } = string.Empty;

        [Required]
        public string link { get; set; }

        [Required]
        public int SubjectId { get; set; }
    }
}
