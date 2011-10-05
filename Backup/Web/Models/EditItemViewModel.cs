using System.ComponentModel.DataAnnotations;

namespace MvcValidation.Web.Models
{
    public class EditItemViewModel
    {
        public EditItemViewModel()
        {
        }

        public EditItemViewModel(ItemDto item)
        {
            Name = item.Name;
            Description = item.Description;
            Loaner = item.Loaner;
        }

        public string Id { get; set; }

        [Required]
        [StringLength(32)]
        public string Name { get; set; }

        [Required]
        [StringLength(256)]
        public string Description { get; set; }

        public string Loaner { get; set; }
    }
}