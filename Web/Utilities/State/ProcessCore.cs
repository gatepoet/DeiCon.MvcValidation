using System;
using System.Collections.Generic;
using System.Linq;

namespace MvcValidation.Web.Utilities.State
{
    public class ProcessCore : IProcess
    {
        private readonly ICreateStepStrategy _createStepStrategy;

        public ProcessCore(ICreateStepStrategy strategy)
        {
            _createStepStrategy = strategy;
            CreateFirstStep();
        }

        private void CreateFirstStep()
        {
            var firstStep = _createStepStrategy.CreateFirstStep();
            AddStep(firstStep);
        }

        private readonly LinkedList<IProcessStep> _steps = new LinkedList<IProcessStep>();
        public IEnumerable<IProcessStep> Steps { get { return _steps; } }

        public IProcessStep CurrentStep { get; private set; }

        protected void AddStep(IProcessStep step)
        {
            step.Complete += StepComplete;

            _steps.AddLast(step);
            CurrentStep = step;
        }

        private void RemoveAllStepsAfterCurrent()
        {
            if (CurrentStep.IsNotNull() && CurrentStep == _steps.Last.Value)
                return;

            _steps.RemoveLast();
            RemoveAllStepsAfterCurrent();
        }

        public virtual bool IsReadyFor(string currentStep)
        {
            return _steps
                .Reverse()
                .Any(step => step.IsNamed(currentStep));
        }

        public void Reset()
        {
            CurrentStep = null;
            _steps.Clear();
            CreateFirstStep();
        }

        public bool IsComplete()
        {
            return CurrentStep is CompleteStep;
        }

        public void ContinueTo(IProcessStep nextStep)
        {
            RemoveAllStepsAfterCurrent();
            AddStep(nextStep);
        }

        protected virtual void StepComplete(object sender, StepCompleteEventArgs args)
        {
            args.Command.Execute(this);
        }
    }
}