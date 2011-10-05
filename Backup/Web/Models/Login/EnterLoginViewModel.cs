using System.ComponentModel;

namespace MvcValidation.Web.Models.Login
{
    public class EnterLoginViewModel
    {
        [DisplayName("Username")]
        public string Username { get; set; }
        [DisplayName("Password")]
        public string Password { get; set; }
    }
}