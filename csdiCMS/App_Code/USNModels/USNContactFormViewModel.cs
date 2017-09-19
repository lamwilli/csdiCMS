using System;
using System.ComponentModel.DataAnnotations;
using Umbraco.Core.Models;

namespace USNStarterKit.USNModels
{
    /// <summary>
    /// Not using strongly typed models here so that PureLive mode can be used
    /// </summary>
    public class USNContactFormViewModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]
        public string Email { get; set; }

        public string Telephone { get; set; }

        [DataType(DataType.MultilineText)]
        public string Message { get; set; }

        public Boolean NewsletterSignup { get; set; }

        public int CurrentNodeID { get; set; }

        public IPublishedContent GlobalSettings { get; set; }
    }

}