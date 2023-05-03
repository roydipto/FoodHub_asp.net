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
    public class MenuIteamService
    {
        public static List<MenuIteamDTO> Get() //To see all menuIteams
        {
            // first we collect data from data accessLayer
            var data = DataAccessFactory.MenuIteamData().Read();

            // now we need to convert Data From BAL to DTOs by Automapper

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<MenuIteam,MenuIteamDTO>(); // from where to where
            });

            var mapper = new Mapper(cfg); 
            var mapped = mapper.Map<List<MenuIteamDTO>>(data); //Ki formate && kake 

            return mapped;



        }


        //Find by Id

        public static MenuIteamDTO Get (int id)
        {
            var data = DataAccessFactory.MenuIteamData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<MenuIteam,MenuIteamDTO>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<MenuIteamDTO>(data);
            return mapped;
        }

        public static MenuOrderDTO GetWithOrder(int id)
        {
            var data = DataAccessFactory.MenuIteamData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<MenuIteam, MenuOrderDTO>();
                c.CreateMap<Order, OrderDTO>(); 
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<MenuOrderDTO>(data);
            return mapped;
        }
    }
}
