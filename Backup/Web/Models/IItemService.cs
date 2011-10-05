using System.Collections.Generic;

namespace MvcValidation.Web.Models
{
    public interface IItemService
    {
        IEnumerable<ItemDto> ListItems();
        void Add(ItemDto item);
        ItemDto GetItem(string name);
    }
}