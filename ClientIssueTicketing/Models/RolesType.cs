
namespace ClientIssueTicketing.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The roles type
    /// </summary>
    public class RolesType 
    {
        /// <summary>
        /// Gets or sets the roles id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the role value
        /// </summary>
        [Required]
        [StringLength(100)]
        public string RoleValue { get; set; }
    }
}