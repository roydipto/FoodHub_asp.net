using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class DeliveryMan
    {
        public int Id { get; set; }
        [Required]
        public int UN { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        [StringLength(100)]
        public string Password { get; set; }
        [Required]
        [StringLength(200)]
        public string Address { get; set; }
        [ForeignKey("Restaurants")]
        public int AddedBy { get; set; }

        public virtual Restaurant Restaurants { get; set; }

    }
}
