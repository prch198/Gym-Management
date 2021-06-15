using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymManagement.Models
{
    public interface IPlanRepository
    {
        Plan GetPlan(int Id);
        IEnumerable<Plan> GetAllPlans();
        Plan Add(Plan Plan);
        Plan Delete(int Id);
    }
}
