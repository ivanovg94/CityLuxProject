using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CityLuxProject.Models
{
    public class Component
    {
        private ICollection<Recipe> recipies;

        public Component()
        {
            this.recipies = new HashSet<Recipe>();
        }

        [Key]
        public string Id { get; set; }

        [ForeignKey("ComponentType")]
        public string ComponentTypeId { get; set; }

        public virtual ComponentType ComponentType { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public ICollection<Recipe> Recipies
        {
            get { return this.recipies; }
            set { this.recipies = value; }
        }

    }
}