using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CityLuxProject.Models
{
    public class Recipe
    {
        [Key, Column(Order = 0), ForeignKey("Product")]
        public string ProductId { get; set; }

        [Key, Column(Order = 1), ForeignKey("Component")]
        public string ComponentId { get; set; }

        public string RecipeCode { get; set; }

        public Product Product { get; set; }

        public Component Component { get; set; }
    }
}