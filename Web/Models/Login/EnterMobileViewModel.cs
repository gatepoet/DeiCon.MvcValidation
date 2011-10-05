using System.ComponentModel;

namespace MvcValidation.Web.Models.Login
{
    public class EnterMobileViewModel
    {
        [DisplayName("Mobile phone")]
        public string MobilePhoneNumber { get; set;}
    }
}