using System;

namespace MvcValidation.Web.Models.Login
{
    public class EnterLoginModel : IModel
    {
        private readonly IFormsAuthenticationService _formsAuthenticationService;

        public EnterLoginModel(IFormsAuthenticationService formsAuthenticationService)
        {
            _formsAuthenticationService = formsAuthenticationService;
        }

        public void LogIn(UserLoginSummary summary)
        {
            _formsAuthenticationService.SignIn(summary.EnterLoginInputModel.Username, false);
        }

        public object GetViewModel()
        {
            return new EnterLoginViewModel();
        }
    }
}