using System;
using System.Diagnostics;
using MvcValidation.Web.Services;

namespace MvcValidation.Web.Models.Login
{
    public class EnterGuestLoginModel : IModel
    {
        private readonly IFormsAuthenticationService _formsAuthenticationService;

        public EnterGuestLoginModel(IFormsAuthenticationService formsAuthenticationService, ITestService testService)
        {
            _formsAuthenticationService = formsAuthenticationService;
            var s = testService.GetTitle();
            Debug.WriteLine(s);
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