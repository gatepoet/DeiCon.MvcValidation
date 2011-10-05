using MvcValidation.Web.Models;
using MvcValidation.Web.Services;

namespace MvcValidation.Web.Utilities.Bootstrapper
{
    public class AddTestData : IBootstrapTask
    {
        private readonly IItemService _itemService;
        private readonly IMobileService _mobileService;

        public AddTestData(IItemService itemService, IMobileService mobileService)
        {
            _itemService = itemService;
            _mobileService = mobileService;
        }

        public void Execute()
        {
            AddItems();
        }

        private void AddItems()
        {
            _itemService.Add(new ItemDto{Name = "asdf", Description = "ldslkdskl"});
            _itemService.Add(new ItemDto{Name = "bvcxxcv", Description = "aa"});
        }
    }
}