using MvcValidation.Web.Utilities.State;

namespace MvcValidation.Web.Models.Login
{
    public class EnterGuestLoginStep : ProcessStepCore
    {
        public EnterGuestLoginStep(ICommandFactory commandFactory) : base(commandFactory) { }

        public EnterGuestLoginStep() { }

        public EnterGuestLoginInputModel InputModel { get; private set; }

        public void Proceed(EnterGuestLoginInputModel inputModel)
        {
            InputModel = inputModel;
            OnComplete(Factory.CreateCommand<LogInGuestCommand>());
        }
    }
}