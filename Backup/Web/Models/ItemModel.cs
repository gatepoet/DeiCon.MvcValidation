namespace MvcValidation.Web.Models
{
    public class ItemModel : IModel
    {
        private readonly IItemService _itemService;

        public ItemModel(IItemService itemService)
        {
            _itemService = itemService;
        }

        public object GetViewModel()
        {
            return new ItemViewModel(_itemService.ListItems());
        }
    }
}