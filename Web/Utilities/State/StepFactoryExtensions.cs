using System.Collections.Generic;
using System.Web.Routing;

namespace MvcValidation.Web.Utilities.State
{
    public static class StepFactoryExtensions
    {
        public class CompleteWithRedirectTo
        {
            public CompleteStep Step { get; private set; }

            internal CompleteWithRedirectTo(CompleteStep step)
            {
                Step = step;
            }
        }
        public static CompleteWithRedirectTo WithRedirectTo(this CompleteStep step)
        {
            return new CompleteWithRedirectTo(step);
        }
        public static CompleteStep Home(this CompleteWithRedirectTo redirectTo)
        {
            var completeStep = redirectTo.Step;
            completeStep.RouteValues = new RouteValueDictionary(new Dictionary<string, object>
                                                                    {
                                                                        { "action", string.Empty },
                                                                        { "controller", "Home" }
                                                                    });
            return completeStep;
        }
    }
}