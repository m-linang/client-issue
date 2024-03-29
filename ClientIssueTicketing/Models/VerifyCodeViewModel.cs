﻿
namespace ClientIssueTicketing.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The verify code view model
    /// </summary>
    public class VerifyCodeViewModel
    {
        /// <summary>
        /// Gets or sets the provider
        /// </summary>
        [Required]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or sets the code
        /// </summary>
        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the return url
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Gets or sets the remember browser
        /// </summary>
        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }
}