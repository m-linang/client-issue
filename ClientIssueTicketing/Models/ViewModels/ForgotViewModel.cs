namespace ClientIssueTicketing.Models.ViewModels
{

    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The forgot view model
    /// </summary>
    public class ForgotViewModel
    {
        /// <summary>
        /// Gets or sets the email
        /// </summary>
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}