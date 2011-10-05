using System.Collections.Generic;
using System.Web.Routing;

namespace MvcValidation.Web.Utilities.State
{
    public class StepFactory : IStepFactory
    {
        public IProcessStep CreateCompleteStep(string name, string action, string controller)
        {
            var completePage = new RouteValueDictionary(new Dictionary<string, object> { { "action", action }, { "controller", controller } });
            return new CompleteStep(name, completePage);
        }

        public CompleteStep CreateCompleteStep()
        {
            return new CompleteStep();
        }

        public IProcessStep CreateCompleteStep(string name)
        {
            var completePage = new RouteValueDictionary(new Dictionary<string, object> { { "action", string.Empty }});
            return new CompleteStep(name, completePage);
        }
    }
}