namespace MvcValidation.Web.Utilities.State
{
    public interface IStepFactory
    {
        IProcessStep CreateCompleteStep(string name, string action, string controller);
        CompleteStep CreateCompleteStep();
        IProcessStep CreateCompleteStep(string name);
    }
}