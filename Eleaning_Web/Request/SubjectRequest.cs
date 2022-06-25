using System.ComponentModel.DataAnnotations;

namespace WEB_ELEANING.Request
{
    public class SubjectRequest
    {
        [Required(ErrorMessage = "Nhập sai nhập lại!!!")]
        public string SubjectName { get; set; } = string.Empty;

        [Required]
        public int Period { get; set; }

        [Required]
        public DateTime StartDay { get; set; }

        [Required]
        public DateTime EndDay { get; set; }
    }
}
