using MvcValidation.Web.Utilities.State;

namespace MvcValidation.Web.Models.Login
{
    public class LogInUserCommand : GoToNextStepCommand
    {
        private readonly EnterLoginModel _model;

        public LogInUserCommand(EnterLoginModel model, IStepFactory stepFactory)
            : base(stepFactory.CreateCompleteStep().WithRedirectTo().Home())
        {
            _model = model;
        }

        public override void Execute(IProcess process)
        {
            _model.LogIn(new UserLoginSummary(process.Steps));
            base.Execute(process);
        }
    }
}