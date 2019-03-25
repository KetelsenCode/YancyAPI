using System.ComponentModel.DataAnnotations;

namespace YancyAPI.Controllers.Resources
{
    public class ContactResource
    {
        [Required]
        [StringLength(225)]
        public string Name { get; set; }
        [StringLength(225)]
        public string Mail { get; set; }
        [Required]
        [StringLength(225)]
        public string Phone { get; set; }
    }
}
