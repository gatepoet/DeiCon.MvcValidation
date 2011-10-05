using System.Collections.Generic;
using System.Linq;

namespace MvcValidation.Web.Models
{
    public class ItemViewModel
    {
        public ItemDto[] Items { get; private set; }

        public ItemViewModel(IEnumerable<ItemDto> items)
        {
            Items = items.ToArray();
        }
    }
}