namespace MvcValidation.Web.Models
{
    public class LogOutModel
    {
        private readonly IFormsAuthenticationService _formsAuthenticationService;

        public LogOutModel() { }
        public LogOutModel(IFormsAuthenticationService formsAuthenticationService)
        {
            _formsAuthenticationService = formsAuthenticationService;
        }

        public void LogOut()
        {
            _formsAuthenticationService.SignOut();
        }
    }
}