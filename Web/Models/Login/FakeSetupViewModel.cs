using System.ComponentModel;

namespace MvcValidation.Web.Models.Login
{
    public class FakeSetupViewModel
    {
        [DisplayName("Mobile phone")]
        public string MobilePhoneNumber { get; set;}
    }
}