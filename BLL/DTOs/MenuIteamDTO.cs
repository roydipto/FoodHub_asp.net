using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class MenuIteamDTO
    {
        public int Id { get; set; }
        [Required]
        public string IteamName { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int Qty { get; set; }

        
    }
}
