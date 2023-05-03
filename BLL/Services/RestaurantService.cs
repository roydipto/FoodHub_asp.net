using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class RestaurantService
    {
        public static List<RestaurantDTO> Get()
        {
            var data = DataAccessFactory.RestaurantData().Read();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Restaurant, RestaurantDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<RestaurantDTO>>(data);
            return mapped;

        }
        public static RestaurantDTO Get(string id)
        {
            var data = DataAccessFactory.RestaurantData().Read(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Restaurant, RestaurantDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<RestaurantDTO>(data);
            return mapped;

        }
        public static RestaurantDTO Add(RestaurantDTO restaurant)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Restaurant, RestaurantDTO>();
                c.CreateMap<RestaurantDTO, Restaurant>();
            });
            var mapper = new Mapper(cfg);
            var res = mapper.Map<Restaurant>(restaurant);
            var data = DataAccessFactory.RestaurantData().Create(res);

            if (data != null) return mapper.Map<RestaurantDTO>(data);
            return null;
        }

        public static RestaurantDTO Update(RestaurantDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<RestaurantDTO, Restaurant>();
                cfg.CreateMap<Restaurant, RestaurantDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Restaurant>(obj);
            var rs = DataAccessFactory.RestaurantData().Update(converted);
            var res = mapper.Map<RestaurantDTO>(rs);
            return res;
        }

        public static bool Delete(string UN)
        {
            var res = DataAccessFactory.RestaurantData().Delete(UN);
            return res;
        }
    }
}
