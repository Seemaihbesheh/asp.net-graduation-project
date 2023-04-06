

using System;
namespace WebApplication3.Models.DTO
{
    public record ResetPassDtoo
    {
        public string Email { get; set; }
        public string EmailToken { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
