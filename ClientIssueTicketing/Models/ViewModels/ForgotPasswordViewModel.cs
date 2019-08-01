
namespace ClientIssueTicketing.Models.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The forgot password view model
    /// </summary>
    public class ForgotPasswordViewModel
    {
        /// <summary>
        /// Gets or sets email
        /// </summary>
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}