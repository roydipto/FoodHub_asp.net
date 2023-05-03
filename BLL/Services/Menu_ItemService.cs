using AutoMapper;
using BLL.DTOs;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class Menu_ItemService
    {
        public static List<Menu_ItemsDTO> Get()
        {
            var data = DataAccessFactory.MenuData().Read();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Menu_Items, Menu_ItemsDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<Menu_ItemsDTO>>(data);
            return mapped;

        }
        public static Menu_ItemsDTO Get(int id)
        {
            var data = DataAccessFactory.MenuData().Read(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Menu_Items, Menu_ItemsDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Menu_ItemsDTO>(data);
            return mapped;

        }
        public static Menu_ItemsDTO Add(Menu_ItemsDTO order)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Menu_Items, Menu_ItemsDTO>();
                c.CreateMap<Menu_ItemsDTO, Menu_Items>();
            });
            var mapper = new Mapper(cfg);
            var res = mapper.Map<Menu_Items>(order);
            var data = DataAccessFactory.MenuData().Create(res);

            if (data != null) return mapper.Map<Menu_ItemsDTO>(data);
            return null;
        }

        public static Menu_ItemsDTO Update(Menu_ItemsDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Menu_ItemsDTO, Menu_Items>();
                cfg.CreateMap<Menu_Items, Menu_ItemsDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Menu_Items>(obj);
            var rs = DataAccessFactory.MenuData().Update(converted);
            var res = mapper.Map<Menu_ItemsDTO>(rs);
            return res;
        }

        public static bool Delete(int id)
        {
            var res = DataAccessFactory.MenuData().Delete(id);
            return res;
        }

}
}
