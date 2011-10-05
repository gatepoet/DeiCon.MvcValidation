using System;
using System.Web.Routing;

namespace MvcValidation.Web.Utilities.State
{
    public class ProcessStepCore : IProcessStep
    {
        public ICommandFactory Factory { get; private set; }

        protected ProcessStepCore(){}
        protected ProcessStepCore(ICommandFactory factory)
        {
            Factory = factory;
        }

        public string Name
        {
            get { return GetType().GetKey("Step"); }
        }

        public bool IsNamed(string name)
        {
            return Name.Equals(name);
        }

        public virtual RouteValueDictionary RouteValues
        {
            get { return new RouteValueDictionary {{"action", Name}}; }
        }

        public virtual event EventHandler<StepCompleteEventArgs> Complete;

        protected void OnComplete(IStepCompleteCommand command)
        {
            var args = new StepCompleteEventArgs(command);
            if (!Complete.IsNull())
                Complete(this, args);
        }
    }
}