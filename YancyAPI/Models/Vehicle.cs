using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YancyAPI.Models
{
    [Table("Vehicles")]
    public class Vehicle
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
        public bool IsRegistred { get; set; }
        [Required]
        [StringLength(225)]
        public string ContactName { get; set; }
        [StringLength(225)]
        public string ContactMail { get; set; }
        [Required]
        [StringLength(225)]
        public string ContactPhone { get; set; }
        public DateTime LastUpdate { get; set; }
        public ICollection<VehicleFeature> Features { get; set; }
        public Vehicle()
        {
            Features = new Collection<VehicleFeature>();
        }
    }
}
