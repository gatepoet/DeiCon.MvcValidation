namespace MvcValidation.Web.Utilities.State
{
    public interface ICommandFactory
    {
        TCommand CreateCommand<TCommand>() where TCommand : IStepCompleteCommand;
        GoToNextStepCommand CreateNextStepCommandFrom(string dictionaryKey);
        GoToNextStepCommand CreateNextStepCommandFrom(IProcessStep nextStep);
    }
}