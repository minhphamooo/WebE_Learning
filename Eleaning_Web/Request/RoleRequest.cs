using System.ComponentModel.DataAnnotations;

namespace WEB_ELEANING.Request
{
    public class RoleRequest
    {
        [Required(ErrorMessage = "Nhập sai nhập lại!!!")]
       
        public int RoleId { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
