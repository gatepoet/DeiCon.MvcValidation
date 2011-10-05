using MvcValidation.Web.Utilities.State;

namespace MvcValidation.Web.Models.Login
{
    public class LoginProcess : ProcessCore
    {
        public LoginProcess() : base(new CreateStepStrategy(typeof(EnterMobileStep))) { }
    }
}