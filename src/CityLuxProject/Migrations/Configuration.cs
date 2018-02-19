namespace CityLuxProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<CityLuxProject.Data.CItyLuxDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(CityLuxProject.Data.CItyLuxDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.MerchandiseGroup.AddOrUpdate(
                new Models.MerchandiseGroup() { Id = Guid.NewGuid().ToString(), Name = "Полилеи" },
                new Models.MerchandiseGroup() { Id = Guid.NewGuid().ToString(), Name = "Настолни лампи" },
                new Models.MerchandiseGroup() { Id = Guid.NewGuid().ToString(), Name = "Лампиони" },
                new Models.MerchandiseGroup() { Id = Guid.NewGuid().ToString(), Name = "Портативни лампи" }
                );

            context.UnitOfMeasure.AddOrUpdate(
               new Models.UnitOfMeasure() { Id = Guid.NewGuid().ToString(), Name = "Кг" },
               new Models.UnitOfMeasure() { Id = Guid.NewGuid().ToString(), Name = "См" },
               new Models.UnitOfMeasure() { Id = Guid.NewGuid().ToString(), Name = "W" }
               );

            context.ComponentType.AddOrUpdate(
                new Models.ComponentType() { Id = Guid.NewGuid().ToString(), Name = "Абажури" },
                new Models.ComponentType() { Id = Guid.NewGuid().ToString(), Name = "Верижки" },
                new Models.ComponentType() { Id = Guid.NewGuid().ToString(), Name = "Плафон" },
                new Models.ComponentType() { Id = Guid.NewGuid().ToString(), Name = "Аплици" },
                new Models.ComponentType() { Id = Guid.NewGuid().ToString(), Name = "Крушки" },
                new Models.ComponentType() { Id = Guid.NewGuid().ToString(), Name = "Пендели" });
        }
    }
}
