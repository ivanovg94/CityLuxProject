using CityLuxProject.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System;

namespace CityLuxProject.Data
{
    public class CItyLuxDbContext : IdentityDbContext<ApplicationUser>
    {
        public CItyLuxDbContext()
         : base("CItyLuxDb", throwIfV1Schema: false)
        {
        }

        public IDbSet<Component> Component { get; set; }

        public IDbSet<ComponentType> ComponentType { get; set; }

        public IDbSet<Construction> Construction { get; set; }

        public IDbSet<MerchandiseGroup> MerchandiseGroup { get; set; }

        public IDbSet<Product> Product { get; set; }

        public IDbSet<Recipe> Recipe { get; set; }

        public IDbSet<UnitOfMeasure> UnitOfMeasure { get; set; }

        internal static CItyLuxDbContext Create()
        {
            return new CItyLuxDbContext();
        }
    }
}