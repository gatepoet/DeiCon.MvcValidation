using Microsoft.Practices.ServiceLocation;

namespace MvcValidation.Web.Utilities.State
{
    public class CommandFactory : ICommandFactory
    {
        private static IServiceLocator Locator { get { return ServiceLocator.Current; } }

        public TCommand CreateCommand<TCommand>() where TCommand : IStepCompleteCommand
        {
            return Locator.GetInstance<TCommand>();
        }
        public GoToNextStepCommand CreateNextStepCommandFrom(string dictionaryKey)
        {
            var nextStep = Locator.GetInstance<IProcessStep>(dictionaryKey);
            return new GoToNextStepCommand(nextStep);
        }
        public GoToNextStepCommand CreateNextStepCommandFrom(IProcessStep nextStep)
        {
            return new GoToNextStepCommand(nextStep);
        }
    }
}
