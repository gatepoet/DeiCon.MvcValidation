using MvcValidation.Web.Utilities.State;

namespace MvcValidation.Web.Models.Login
{
    public class LogInGuestCommand : GoToNextStepCommand
    {
        private readonly EnterGuestLoginModel _model;

        public LogInGuestCommand(EnterGuestLoginModel model, IStepFactory stepFactory)
            : base(stepFactory.CreateCompleteStep().WithRedirectTo().Home())
        {
            _model = model;
        }

        public override void Execute(IProcess process)
        {
            _model.LogInGuest(new GuestLoginSummary(process.Steps));
            base.Execute(process);
        }
    }
}