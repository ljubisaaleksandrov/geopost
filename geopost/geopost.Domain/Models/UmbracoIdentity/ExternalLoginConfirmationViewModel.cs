using System.ComponentModel.DataAnnotations;

namespace geopost.Domain.Models.UmbracoIdentity
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
