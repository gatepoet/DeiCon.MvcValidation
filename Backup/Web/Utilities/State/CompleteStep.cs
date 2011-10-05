using System;
using System.Web.Routing;

namespace MvcValidation.Web.Utilities.State
{
    public class CompleteStep : IProcessStep
    {
        internal const string DefaultName = "Complete";

        internal CompleteStep(){}

        public CompleteStep(RouteValueDictionary completePage)
        {
            Name = DefaultName;
            RouteValues = completePage;
        }

        public CompleteStep(string name, RouteValueDictionary completePage)
        {
            Name = name;
            RouteValues = completePage;
        }

        public bool IsNamed(string name)
        {
            return Name.Equals(name);
        }

        public string Name { get; internal set; }

        public RouteValueDictionary RouteValues { get; internal set; }

        public event EventHandler<StepCompleteEventArgs> Complete;
    }
}