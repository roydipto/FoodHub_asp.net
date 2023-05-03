using AutoMapper;
using BLL.DTO_s;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ResService
    {
        public static List<ResDTO> Get()
        {
            var data = DataAccessFactory.ResData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Restaurant,ResDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map <List<ResDTO>>(data);
            return mapped;
            
        }
        public static ResDTO Get(int id)
        {
            var data = DataAccessFactory.ResData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Restaurant, ResDTO>();
            });
            var mapper = new Mapper(cfg);   
            var mapped = mapper.Map<ResDTO>(data);
            return mapped;
        }

        public static ResDTO Add(ResDTO res)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Restaurant, ResDTO>();
                c.CreateMap<ResDTO, Restaurant>();
            });
            var mapper = new Mapper(cfg);
            var r = mapper.Map<Restaurant>(res);
            var data = DataAccessFactory.ResData().Create(r);
            if (data != null) return mapper.Map<ResDTO>(data);
            return null;
        }
    }
}
