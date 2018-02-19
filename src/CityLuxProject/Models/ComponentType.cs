using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CityLuxProject.Models
{
    public class ComponentType
    {
        private ICollection<Construction> constructions;
        //private ICollection<Recipe> recipies;

        public ComponentType()
        {
            this.constructions = new HashSet<Construction>();
            //this.recipies = new HashSet<Recipe>();
        }

        [Key]
        public string Id { get; set; }

        public string Name { get; set; }

        public ICollection<Construction> Constructions
        {
            get { return this.constructions; }
            set { this.constructions = value; }
        }

        //public ICollection<Recipe> Recipes
        //{
        //    get { return this.recipies; }
        //    set { this.recipies = value; }
        //}
    }
}