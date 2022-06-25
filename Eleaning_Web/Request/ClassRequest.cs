using System.ComponentModel.DataAnnotations;

namespace WEB_ELEANING.Request
{
    public class ClassRequest
    {
        [Required(ErrorMessage = "Nhập sai nhập lại")]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string link { get; set; }

        [Required]
        public bool status { get; set; }

        [Required]
        public int Amount { get; set; }
    }
}
