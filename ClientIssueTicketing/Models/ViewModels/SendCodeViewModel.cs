namespace ClientIssueTicketing.Models.ViewModels
{
    using System.Web.Mvc;
    using System.Collections.Generic;

    /// <summary>
    /// The send code view model
    /// </summary>
    public class SendCodeViewModel
    {
        /// <summary>
        /// Gets or sets the selected provider
        /// </summary>
        public string SelectedProvider { get; set; }

        /// <summary>
        ///  Gets or sets the providers
        /// </summary>
        public ICollection<SelectListItem> Providers { get; set; }

        /// <summary>
        /// Gets or sets the return url
        /// </summary>
        public string ReturnUrl { get; set; }

        public bool RememberMe { get; set; }
    }
}