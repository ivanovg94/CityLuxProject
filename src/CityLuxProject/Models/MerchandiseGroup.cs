using System.ComponentModel.DataAnnotations;

namespace CityLuxProject.Models
{
    public class MerchandiseGroup
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }
    }
}