using MvcValidation.Web.Utilities;

namespace MvcValidation.Web.Models.Login
{
    public class EnterLoginInputModel
    {
        public string Username { get; set; }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = Crypto.Encrypt(value); }
        }
    }
}