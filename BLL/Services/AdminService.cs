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
    public class AdminService
    {

        public static List<AdminDTO> Get()
        {
            var data = DataAccessFactory.AdminData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<AdminDTO>>(data);
            return mapped;

        }
        public static AdminDTO Get(int id)
        {
            var data = DataAccessFactory.AdminData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<AdminDTO>(data);
            return mapped;
        }
        public static AdminDTO Insert()
        {
            var data = DataAccessFactory.AdminData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin,AdminDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<AdminDTO>(data);
            return mapped;

        }

        public static AdminDTO Add(AdminDTO admin)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminDTO>();
                c.CreateMap<AdminDTO, Admin>();
            });
            var mapper = new Mapper(cfg);
            var ad = mapper.Map<Admin>(admin);
            var data = DataAccessFactory.AdminData().Create(ad);
            if (data != null) return mapper.Map<AdminDTO>(data);
            return null;
        }
    }

    public static bool Delete(string id)
    {
        var res = DataAccessFactory.AdminData().Delete(id);
        return res;
    }

}
