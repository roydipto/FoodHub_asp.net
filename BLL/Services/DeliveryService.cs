using BLL.DTO_s;
using AutoMapper;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class DeliveryService
    {
        public static List<DeliveryDTO> Get()
        {
            var data = DataAccessFactory.DeliveryData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Delivery, DeliveryDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<DeliveryDTO>>(data);
            return mapped;
          }
        }
    }
