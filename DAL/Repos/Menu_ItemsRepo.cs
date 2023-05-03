using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class Menu_ItemsRepo : Repo, IRepo<Menu_Items, int, Menu_Items>
    {
        public Menu_Items Create(Menu_Items obj)
        {
            db.Items.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public Menu_Items Add(Menu_Items obj)
        {
            db.Items.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Items.Remove(ex);
            return db.SaveChanges() > 0;
        }
        public List<Menu_Items> Read()
        {
            return db.Items.ToList();
        }

        public Menu_Items Read(int id)
        {
            return db.Items.Find(id);
        }

        public Menu_Items Update(Menu_Items obj)
        {
            var ex = Read(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
