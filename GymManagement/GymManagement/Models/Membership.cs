using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GymManagement.Models
{
    public class Membership
    {
        [Key]
        [Required]
        public int MembershipId { get; set; }
        [Required]
        public Boolean PayStatus { get; set; }
        [Required]
        [ForeignKey("PlanId")]
        public Plan Plan { get; set; }
        [Required]
        [ForeignKey("UserId")]
        public ApplicationUser applicationuser { get; set; }
    }
}
