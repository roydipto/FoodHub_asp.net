using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class RestaurantDTO
    {
        [Required]
        public int UN { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }

    }
}
