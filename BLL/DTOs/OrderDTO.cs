using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }

        public int Amount { get; set; }

        public string Status { get; set; }
       
        public string OrderBy { get; set; }
       
        public int IteamId { get; set; }

    }
}
