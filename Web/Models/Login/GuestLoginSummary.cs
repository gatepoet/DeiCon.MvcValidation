using System.Collections.Generic;
using MvcValidation.Web.Utilities;
using MvcValidation.Web.Utilities.State;

namespace MvcValidation.Web.Models.Login
{
    public class GuestLoginSummary
    {
        public EnterMobileInputModel EnterMobileInputModel { get; private set; }
        public EnterGuestLoginInputModel EnterGuestLoginInputModel { get; private set; }

        public GuestLoginSummary(IEnumerable<IProcessStep> steps)
        {
            var enumerator = steps.GetEnumerator();
            enumerator.MoveNext();
            EnterMobileInputModel = enumerator.Current.As<EnterMobileStep>().InputModel;
            enumerator.MoveNext();
            EnterGuestLoginInputModel = enumerator.Current.As<EnterGuestLoginStep>().InputModel;
        }
    }
}