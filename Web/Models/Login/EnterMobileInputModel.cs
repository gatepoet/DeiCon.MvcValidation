using System.ComponentModel.DataAnnotations;

namespace MvcValidation.Web.Models.Login
{
    public class EnterMobileInputModel
    {
        public EnterMobileInputModel()
        {
        }

        [Required]
        [Range(7,8)]
        public string MobilePhoneNumber { get; set;}
    }
}