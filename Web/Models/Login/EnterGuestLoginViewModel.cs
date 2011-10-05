using System.ComponentModel;

namespace MvcValidation.Web.Models.Login
{
    public class EnterGuestLoginViewModel
    {
        private string _displayName;

        [DisplayName("Display name")]
        public string DisplayName
        {
            get { return _displayName ?? "Guest"; }
            set { _displayName = value; }
        }

        [DisplayName("Verification Code")]
        public string VerificationCode { get; set; }
    }
}