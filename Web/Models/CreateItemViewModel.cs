using System.ComponentModel.DataAnnotations;

namespace MvcValidation.Web.Models
{
    public class CreateItemViewModel
    {
        [Required]
        [StringLength(32)]
        public string Name { get; set; }
        
        [Required]
        [StringLength(256)]
        public string Description { get; set; }
    }
}