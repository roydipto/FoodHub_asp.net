namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<DAL.Models.FoodHubContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.Models.FoodHubContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            for (int i = 1; i <= 10; i++)
            {
                context.Items.AddOrUpdate(new Models.Menu_Items
                {
                    Name = Guid.NewGuid().ToString().Substring(0, 15),
                    Description = Guid.NewGuid().ToString(),
                    Price = Guid.NewGuid().ToString().Substring(0, 15),
                    AddedBy = i
                });
            }
            for (int i = 1; i <= 30; i++)
            {
                context.OrderItems.AddOrUpdate(new Models.Order_Items
                {
                    Name = Guid.NewGuid().ToString().Substring(0, 15),
                    Quantity = Guid.NewGuid().ToString().Substring(0, 15)
                });
            }

            Random random = new Random();
            for (int i = 1; i <= 10; i++)
            {
                context.DeliveryMens.AddOrUpdate(new Models.DeliveryMan
                {
                    UN = i,
                    Phone = "DeliveryMens-" + random.Next(1, 11),
                    Password = Guid.NewGuid().ToString().Substring(0, 15),
                    Address = Guid.NewGuid().ToString().Substring(0, 15),
                    AddedBy = i
                });
            }

            for (int i = 1; i <= 10; i++)
            {
                context.Restaurants.AddOrUpdate(new Models.Restaurant
                {
                    UN = i,
                    Address = Guid.NewGuid().ToString().Substring(0, 15),
                    Phone = "Restaurants-" + random.Next(1, 11),
                });
            }
        }
    }
}


