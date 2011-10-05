using MvcValidation.Web.Utilities.State;

namespace MvcValidation.Web.Models.Login
{
    public class EnterLoginStep : ProcessStepCore
    {
        public EnterLoginStep(ICommandFactory commandFactory) : base(commandFactory) { }

        public EnterLoginStep() { }

        public EnterLoginInputModel InputModel { get; private set; }

        public void Proceed(EnterLoginInputModel inputModel)
        {
            InputModel = inputModel;
            OnComplete(Factory.CreateCommand<LogInUserCommand>());
        }
    }
}