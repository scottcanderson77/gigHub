using System.ComponentModel.DataAnnotations;

namespace GigHub.ViewModels
{
    public class ForgotViewModel
    {
        [Required]
        public string Email { get; set; }
    }
}