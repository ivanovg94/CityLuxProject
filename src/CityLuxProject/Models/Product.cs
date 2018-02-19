using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CityLuxProject.Models
{
    public class Product
    {
        private ICollection<Construction> constructions;
        private ICollection<Recipe> recipies;

        public Product()
        {
            this.constructions = new HashSet<Construction>();
            this.recipies = new HashSet<Recipe>();
        }

        [Key]
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [ForeignKey("MerchandiseGroup")]
        public string MerchandiseGroupId { get; set; }

        public virtual MerchandiseGroup MerchandiseGroup { get; set; }

        public ICollection<Construction> Constructions
        {
            get { return this.constructions; }
            set { this.constructions = value; }
        }

        public ICollection<Recipe> Recipes
        {
            get { return this.recipies; }
            set { this.recipies = value; }
        }
    }
}