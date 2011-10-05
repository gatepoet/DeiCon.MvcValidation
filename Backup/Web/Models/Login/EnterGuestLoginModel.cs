using System;

namespace MvcValidation.Web.Models.Login
{
    public class EnterGuestLoginModel : IModel
    {
        private readonly IFormsAuthenticationService _formsAuthenticationService;

        public EnterGuestLoginModel(IFormsAuthenticationService formsAuthenticationService)
        {
            _formsAuthenticationService = formsAuthenticationService;
        }

        public void LogInGuest(GuestLoginSummary loginSummary)
        {
            _formsAuthenticationService.SignIn(loginSummary.EnterGuestLoginInputModel.DisplayName, false);
        }

        public object GetViewModel()
        {
            return new EnterGuestLoginViewModel();
        }
    }
}