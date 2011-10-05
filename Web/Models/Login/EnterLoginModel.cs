using System;
using System.Diagnostics;
using MvcValidation.Web.Services;

namespace MvcValidation.Web.Models.Login
{
    public class EnterLoginModel : IModel
    {
        private readonly IFormsAuthenticationService _formsAuthenticationService;

        public EnterLoginModel(IFormsAuthenticationService formsAuthenticationService, ITestService testService)
        {
            _formsAuthenticationService = formsAuthenticationService;
            var s = testService.GetTitle();
            Debug.WriteLine(s);
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