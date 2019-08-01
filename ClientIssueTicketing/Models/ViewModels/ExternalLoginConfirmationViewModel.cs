﻿
namespace ClientIssueTicketing.Models.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The external login confirmation view model
    /// </summary>
    public class ExternalLoginConfirmationViewModel
    {
        /// <summary>
        /// Gets or sets the email
        /// </summary>
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets username
        /// </summary>
        [Required]
        [StringLength(100)]
        [Display(Name ="Username")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the password
        /// </summary>
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the confirm password
        /// </summary>
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

    }
}