using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class RestaurantRepo : Repo, IRepo<Restaurant, string, Restaurant>
    {
        public Restaurant Create(Restaurant obj)
        {
            db.Restaurants.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public Restaurant Add(Restaurant obj)
        {
            db.Restaurants.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
        public bool Delete(string UN)
        {
            var ex = Read(UN);
            db.Restaurants.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Restaurant> Read()
        {
            return db.Restaurants.ToList();
        }

        public Restaurant Read(string id)
        {
            return db.Restaurants.Find(id);
        }

        public Restaurant Update(Restaurant obj)
        {
            var ex = Read(obj.Address);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if(db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
