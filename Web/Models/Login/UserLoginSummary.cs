using System.Collections.Generic;
using MvcValidation.Web.Utilities;
using MvcValidation.Web.Utilities.State;

namespace MvcValidation.Web.Models.Login
{
    public class UserLoginSummary
    {
        public EnterMobileInputModel EnterMobileInputModel { get; private set; }
        public EnterLoginInputModel EnterLoginInputModel { get; private set; }

        public UserLoginSummary(IEnumerable<IProcessStep> steps)
        {
            var enumerator = steps.GetEnumerator();
            enumerator.MoveNext();
            EnterMobileInputModel = enumerator.Current.As<EnterMobileStep>().InputModel;
            enumerator.MoveNext();
            EnterLoginInputModel = enumerator.Current.As<EnterLoginStep>().InputModel;
        }
    }
}