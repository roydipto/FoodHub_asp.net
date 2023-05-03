using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Menu_Items
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        [StringLength(500)]
        public string Description { get; set; }
        [Required]
        [StringLength(200)]
        public string Price { get; set; }
        [ForeignKey("Restaurants")]
        public int AddedBy { get; set; }

        public virtual Restaurant Restaurants { get; set; }

    }
}
