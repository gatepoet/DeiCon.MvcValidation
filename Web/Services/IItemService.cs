using System.Collections.Generic;
using MvcValidation.Web.Models;

namespace MvcValidation.Web.Services
{
    public interface IItemService
    {
        IEnumerable<ItemDto> ListItems();
        void Add(ItemDto item);
        ItemDto GetItem(string name);
    }
}