using System;
using System.Linq;

namespace MvcValidation.Web.Utilities.State
{
    public interface IStepCompleteCommand
    {
        void Execute(IProcess process);
    }
}