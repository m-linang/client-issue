
namespace ClientIssueTicketing.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The user status
    /// </summary>
    public class UserStatus
    {
        /// <summary>
        /// Gets or sets the status id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the status type
        /// </summary>
        public int StatusType { get; set; }

        /// <summary>
        /// Indicate wether is active 
        /// </summary>
        [Display(Name="Active")]
        public bool IsActive { get; set; }

        /// <summary>
        /// Indicate wether is disable
        /// </summary>
        [Display(Name = "Disable")]
        public bool IsDisable { get; set; }

        /// <summary>
        /// Indicate wether is removed
        /// </summary>
        [Display(Name = "Remove")]
        public bool IsRemoved { get; set; }
    }
}