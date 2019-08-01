
namespace ClientIssueTicketing.Models.ViewModels
{

    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The login view model
    /// </summary>
    public class LoginViewModel
    {
        /// <summary>
        /// Gets or sets the email
        /// </summary>
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets username
        /// </summary>
        [Required]
        [Display(Name = "Username")]
        [StringLength(100)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the password
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}