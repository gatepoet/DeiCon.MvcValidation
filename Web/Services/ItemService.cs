using System.Collections.Generic;
using MvcValidation.Web.Models;

namespace MvcValidation.Web.Services
{
    public class ItemService : IItemService
    {
        private static readonly Dictionary<string, ItemDto> Items = new Dictionary<string, ItemDto>();

        public IEnumerable<ItemDto> ListItems()
        {
            return Items.Values;
        }

        public void Add(ItemDto item)
        {
            Items.Add(item.Name, item);
        }

        public ItemDto GetItem(string name)
        {
            return Items[name];
        }
    }
}