using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CityLuxProject.Models
{
    public class UnitOfMeasure
    {
        private ICollection<Construction> constructions;

        public UnitOfMeasure()
        {
            this.constructions = new HashSet<Construction>();
        }

        [Key]
        public string Id { get; set; }

        public string Name { get; set; }

        public ICollection<Construction> Constructions
        {
            get { return this.constructions; }
            set { this.constructions = value; }
        }
    }
}