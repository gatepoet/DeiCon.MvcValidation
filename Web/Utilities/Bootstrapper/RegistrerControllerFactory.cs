using System.Web.Mvc;

namespace MvcValidation.Web.Utilities.Bootstrapper
{
    public class RegisterControllerFactory : IBootstrapTask
    {
        private readonly IControllerFactory _controllerFactory;

        public RegisterControllerFactory(IControllerFactory controllerFactory)
        {
            _controllerFactory = controllerFactory;
        }

        public void Execute()
        {
            ControllerBuilder.Current.SetControllerFactory(_controllerFactory);
        }
    }
}