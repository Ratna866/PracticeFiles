using System.ComponentModel.DataAnnotations;

namespace changePassword.Models
{
    public class ChangePassword
    {
        [Required,DataType(DataType.Password),Display(Name ="CurrentPassword")]
        public string CurrentPassword { get; set; }
        [Required, DataType(DataType.Password), Display(Name = "New Password")]
        public string NewPassword { get; set; }
        [Required, DataType(DataType.Password), Display(Name = "confirm New Password")]
        [Compare("NewPassword",ErrorMessage ="Confirm new password does not match")]
        public string confirmNewPassword { get; set; }

    }
}
