using System;
using Microsoft.Practices.ServiceLocation;

namespace MvcValidation.Web.Utilities.State
{
    public class CreateStepStrategy : ICreateStepStrategy
    {
        private readonly string _key;

        public CreateStepStrategy(Type type)
        {
            _key = type.GetKey("Step");
        }
        public CreateStepStrategy(string key)
        {
            _key = key;
        }

        public IProcessStep CreateFirstStep()
        {
            return ServiceLocator.Current.GetInstance<IProcessStep>(_key);
        }
    }
}