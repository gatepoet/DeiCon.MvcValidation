namespace MvcValidation.Web.Utilities.State
{
    public class GoToNextStepCommand : IStepCompleteCommand
    {
        private readonly IProcessStep _nextStep;

        internal GoToNextStepCommand(IProcessStep nextStep)
        {
            _nextStep = nextStep;
        }

        public virtual void Execute(IProcess process)
        {
            process.ContinueTo(_nextStep);
        }
    }
}