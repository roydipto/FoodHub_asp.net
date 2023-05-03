using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class Order_ItemsRepo : Repo, IRepo<Order_Items, int, Order_Items>
    {
        public Order_Items Create(Order_Items obj)
        {
            db.OrderItems.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public Order_Items Add(Order_Items obj)
        {
            db.OrderItems.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int Id)
        {
            var ex = Read(Id);
            db.OrderItems.Remove(ex);
            return db.SaveChanges() > 0;
        }


        public List<Order_Items> Read()
        {
            return db.OrderItems.ToList();
        }

        public Order_Items Read(int id)
        {
            return db.OrderItems.Find(id);
        }
        
        public Order_Items Update(Order_Items obj)
        {
            var ex = Read(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
