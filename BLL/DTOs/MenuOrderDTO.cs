using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class MenuOrderDTO : MenuIteamDTO
    {
        public List<OrderDTO> Orders { get; set; }
        
        public MenuOrderDTO() { 
        
        Orders= new List<OrderDTO>();
        }
    }
}
