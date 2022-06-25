using System.ComponentModel.DataAnnotations;

namespace WEB_ELEANING.Request
{
    public class TypeExamRequest
    {
        [Required(ErrorMessage = "Nhập sai nhập lại!!!")]

        public string TypeExamId { get; set; } = string.Empty;
        [Required]
        public string TypeExamName { get; set; } = string.Empty;
       
        
    }
}
