

namespace ClientIssueTicketing.Models
{
    using System;

    /// <summary>
    /// The user claims
    /// </summary>
    public class UserClaims
    {
        /// <summary>
        /// Gets or sets the claims id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the claim type
        /// </summary>
        public int ClaimType { get; set; }

        /// <summary>
        /// Gets or sets the ClaimValue
        /// </summary>
        public string ClaimValue { get; set; }
    }
}