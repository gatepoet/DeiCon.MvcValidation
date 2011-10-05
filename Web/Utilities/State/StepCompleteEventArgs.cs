using System;

namespace MvcValidation.Web.Utilities.State
{
    public class StepCompleteEventArgs : EventArgs
    {
        private readonly IStepCompleteCommand _command;

        public StepCompleteEventArgs(IStepCompleteCommand command)
        {
            _command = command;
        }

        public IStepCompleteCommand Command
        {
            get { return _command; }
        }
    }
}