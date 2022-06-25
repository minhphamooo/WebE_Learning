using System.ComponentModel.DataAnnotations;

namespace WEB_ELEANING.Request
{
    public class SemesterRequest
    {
        [Required(ErrorMessage = "Nhập sai nhập lại!!!")]
        public int SemesterId { get; set; }
        [Required]
        public string SemesterName { get; set; } = string.Empty;
        [Required]
        public DateTime StartDay { get; set; }
        [Required]
        public DateTime EndDay { get; set; }
    }
}
