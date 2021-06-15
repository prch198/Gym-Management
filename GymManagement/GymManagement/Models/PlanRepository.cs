using GymManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymManagement.Models
{
    public class PlanRepository : IPlanRepository
    {
        private readonly ApplicationDbContext context;
        public PlanRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public Plan Add(Plan Plan)
        {
            context.Plans.Add(Plan);
            context.SaveChanges();
            return Plan;
        }

        public Plan Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Plan> GetAllPlans()
        {
            return context.Plans;
        }

        public Plan GetPlan(int Id)
        {
            return context.Plans.Find(Id);
        }
    }
}
