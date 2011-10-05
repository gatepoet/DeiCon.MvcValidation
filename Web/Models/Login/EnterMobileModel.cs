using System.Diagnostics;
using MvcValidation.Web.Services;
using MvcValidation.Web.Utilities;

namespace MvcValidation.Web.Models.Login
{
    public class EnterMobileModel : IModel
    {
        private readonly IMobileService _mobileService;
        public EnterMobileModel(IMobileService mobileService, ITestService testService)
        {
            _mobileService = mobileService;
            var s = testService.GetTitle();
            Debug.WriteLine(s);
        }

        public string GetNextStepFor(EnterMobileInputModel inputModel)
        {
            var suffix = "Step";
            return _mobileService.IsRegistered(inputModel.MobilePhoneNumber)
                       ? typeof(EnterLoginStep).GetKey(suffix)
                       : typeof(EnterGuestLoginStep).GetKey(suffix);
        }

        public object GetViewModel()
        {
            return new EnterMobileViewModel();
        }
    }
}