using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GymManagement.Models
{
    public class Equipement
    {
        [Required]
        public int EquipementId { get; set; }

        [Required]
        public string eqname { get; set; }

        [Required]
        public int qty { get; set; }
        [Required]
        public double price { get; set; }

        [Required]
        public DateTime date { get; set; }
    }
}
