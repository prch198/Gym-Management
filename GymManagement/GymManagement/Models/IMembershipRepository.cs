using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymManagement.Models
{
    public interface IMembershipRepository
    {
        Membership Add(Membership Membership);
        Membership GetMembership(int Id);
        Membership Update(Membership MembershipChanges);
    }
}
