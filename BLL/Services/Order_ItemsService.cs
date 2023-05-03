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
    public class Order_ItemsService
    {
        public static List<Order_ItemsDTO> Get()
        {
            var data = DataAccessFactory.OrderData().Read();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Order_Items, Order_Items>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<Order_ItemsDTO>>(data);
            return mapped;

        }
        public static Order_ItemsDTO Get(int id)
        {
            var data = DataAccessFactory.OrderData().Read(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Order_Items, Order_ItemsDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Order_ItemsDTO>(data);
            return mapped;

        }
        public static Order_ItemsDTO Add(Order_ItemsDTO order)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Order_Items, Order_ItemsDTO>();
                c.CreateMap<Order_ItemsDTO, Order_Items>();
            });
            var mapper = new Mapper(cfg);
            var res = mapper.Map<Order_Items>(order);
            var data = DataAccessFactory.OrderData().Create(res);

            if (data != null) return mapper.Map<Order_ItemsDTO>(data);
            return null;
        }

        public static Order_ItemsDTO Update(Order_ItemsDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Order_ItemsDTO, Order_Items>();
                cfg.CreateMap<Order_Items, Order_ItemsDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Order_Items>(obj);
            var rs = DataAccessFactory.OrderData().Update(converted);
            var res = mapper.Map<Order_ItemsDTO>(rs);
            return res;
        }

        public static bool Delete(int UN)
        {
            var res = DataAccessFactory.OrderData().Delete(UN);
            return res;
        }
    }
}
