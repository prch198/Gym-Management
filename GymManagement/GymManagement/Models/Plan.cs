using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GymManagement.Models
{
    public class Plan
    {
        [Required]
        public int PlanId { get; set; }

        [Required]
        public string PlanName { get; set; }

        [Required]
        public string details { get; set; }

        [Required]
        public double amount { get; set; }
    }
}
