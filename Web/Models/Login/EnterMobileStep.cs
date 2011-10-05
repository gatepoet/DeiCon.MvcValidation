using MvcValidation.Web.Utilities.State;

namespace MvcValidation.Web.Models.Login
{
    public class EnterMobileStep : ProcessStepCore
    {
        private readonly EnterMobileModel _model;
        public EnterMobileStep(EnterMobileModel model, ICommandFactory commandFactory) : base(commandFactory)
        {
            _model = model;
        }

        public EnterMobileStep() { }

        public EnterMobileInputModel InputModel { get; private set; }

        public void Proceed(EnterMobileInputModel inputModel)
        {
            InputModel = inputModel;
            var nextStepKey = _model.GetNextStepFor(inputModel);
            var command = Factory.CreateNextStepCommandFrom(nextStepKey);
            OnComplete(command);
        }
    }
}