using System;
using System.Web.Routing;

namespace MvcValidation.Web.Utilities.State
{
    public interface IProcessStep
    {
        bool IsNamed(string name);
        RouteValueDictionary RouteValues { get; }
        string Name { get; }
        event EventHandler<StepCompleteEventArgs> Complete;
    }
}