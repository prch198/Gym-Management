using GymManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymManagement.Models
{
    public class MembershipRepository : IMembershipRepository
    {
        private readonly ApplicationDbContext context;
        public MembershipRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public Membership Add(Membership Membership)
        {
            context.Memberships.Add(Membership);
            context.SaveChanges();
            return Membership;
        }
        public  Membership GetMembership(int Id)
        {
            return context.Memberships.Find(Id);
        }
        public Membership Update(Membership MembershipChanges)
        {
            var membership = context.Memberships.Attach(MembershipChanges);
            membership.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return MembershipChanges;
        }
    }
}
