using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Restaurant, string, Restaurant> RestaurantData()
        {
            return new RestaurantRepo();
        }
        public static IRepo<Order_Items, int, Order_Items> OrderData()
        {
            return new Order_ItemsRepo();
        }
        public static IRepo<Menu_Items, int, Menu_Items> MenuData()
        {
            return new Menu_ItemsRepo();
        }

    }
}
