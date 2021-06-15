using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GymManagement.Models;

namespace GymManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Equipement> Equipements { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

    }
}
