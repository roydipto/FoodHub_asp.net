using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class FoodHubContext : DbContext
    { 
        public DbSet<Restaurant> Restaurants { get; set;}
        public DbSet<Menu_Items> Items { get; set;}
        public DbSet<Order_Items> OrderItems { get; set;}
        public DbSet<DeliveryMan> DeliveryMens { get; set;}
    }
}
