using System;
using System.Collections.Generic;

namespace MvcValidation.Web.Utilities.State
{
    public interface IProcess
    {
        IProcessStep CurrentStep { get; }
        IEnumerable<IProcessStep> Steps { get; }
        void ContinueTo(IProcessStep nextStep);
        bool IsReadyFor(string step);
        void Reset();
        bool IsComplete();
    }
}
