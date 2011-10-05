using System;

namespace MvcValidation.Web.Models
{
    public class EditItemModel : IEditableModel
    {
        private readonly IItemService _itemService;

        public EditItemModel(){}
        public EditItemModel(IItemService itemService)
        {
            _itemService = itemService;
        }

        public object GetViewModel(string name)
        {
            var item = _itemService.GetItem(name);
            return new EditItemViewModel(item);
        }

        public void EditItem(EditItemViewModel model)
        {
            var original = _itemService.GetItem(model.Id);
            original.Name = model.Name;
            original.Description = model.Description;
            original.Loaner = model.Loaner;
        }
    }
}