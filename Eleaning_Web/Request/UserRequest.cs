using System.ComponentModel.DataAnnotations;
namespace WEB_ELEANING.Request
{
    public class UserRequest
    {
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required, MinLength(10, ErrorMessage = "Số điện thoại gồm 10 số !")]
        public string phone { get; set; }
        [Required, MinLength(5, ErrorMessage = "Mật khẩu phải trên 5 ký tự!!!")]
        public string Password { get; set; } = string.Empty;
        [Required, Compare("Password")]
        public string ConfirmPassword { get; set; } = string.Empty;

        public int RoleId { get; set; }
    }
}
