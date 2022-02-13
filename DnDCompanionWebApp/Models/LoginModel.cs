using System.ComponentModel.DataAnnotations;

namespace DnDCompanionWebApp.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Please enter a username to proceed.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please enter a password to proceed.")]
        public string Password { get; set; }
        public bool IsDungeonMaster { get; set; }

    }
}
