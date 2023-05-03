using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Restaurant
    {
        [Key] 
        public int UN { get; set; }
        [Required]
        [StringLength(50)]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }

        public virtual ICollection<Menu_Items> Items { get; set; }  
        public virtual ICollection<DeliveryMan> DeliveryMens { get; set; }

        public Restaurant() { 
        Items = new List<Menu_Items>();
        DeliveryMens = new List<DeliveryMan>();
        }
    }
}
