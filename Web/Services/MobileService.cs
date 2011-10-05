using System.Collections.Generic;

namespace MvcValidation.Web.Services
{
    public class MobileService : IMobileService
    {
        private readonly HashSet<string> _users = new HashSet<string>
                                                      {
                                                          {"0123"}
                                                      };

        public bool IsRegistered(string number)
        {
            return _users.Contains(number);
        }
    }
}