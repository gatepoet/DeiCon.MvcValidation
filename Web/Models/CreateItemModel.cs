using MvcValidation.Web.Services;

namespace MvcValidation.Web.Models
{
    public class CreateItemModel : IModel
    {
        private readonly IItemService _itemService;
        
        /// <summary>
        /// Do not use!
        /// </summary>
        public CreateItemModel(){}
        public CreateItemModel(IItemService itemService)
        {
            _itemService = itemService;
        }

        public object GetViewModel()
        {
            return new CreateItemViewModel();
        }

        public void AddItem(CreateItemViewModel viewModel)
        {
            _itemService.Add(new ItemDto{Name=viewModel.Name, Description = viewModel.Description});
        }
    }
}