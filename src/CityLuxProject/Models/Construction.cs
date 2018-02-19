using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CityLuxProject.Models
{
    public class Construction
    {
        [Key, Column(Order = 0), ForeignKey("Product")]
        public string ProductId { get; set; }

        [Key, Column(Order = 1), ForeignKey("ComponentType")]
        public string ComponentTypeId { get; set; }

        [Key, Column(Order = 2), ForeignKey("GetUnitOfMeasure")]
        public string UnitOfMeasureId { get; set; }

        public Product Product { get; set; }

        public ComponentType ComponentType { get; set; }

        public UnitOfMeasure GetUnitOfMeasure { get; set; }

        public int Quantity { get; set; }
    }
}