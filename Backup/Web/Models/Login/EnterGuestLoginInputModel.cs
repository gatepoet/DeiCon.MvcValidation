using System.ComponentModel.DataAnnotations;
using MvcValidation.Web.Utilities;

namespace MvcValidation.Web.Models.Login
{
    public class EnterGuestLoginInputModel
    {
        [Required]
        public string DisplayName { get; set; }

        [Numeric]
        [StringLength(6)]
        public string VerificationCode { get; set; }
    }
}