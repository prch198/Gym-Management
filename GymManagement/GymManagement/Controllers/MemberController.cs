using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymManagement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GymManagement.Controllers
{
    [Authorize(Roles = "Member")]
    public class MemberController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IEquipementRepository _equipRepo;
        private readonly IPlanRepository _planRepo;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMembershipRepository _memberRepo;
        public MemberController(RoleManager<IdentityRole> roleManager, IEquipementRepository equipRepo, IPlanRepository planRepo,UserManager<ApplicationUser> userManager,IMembershipRepository memberRepo)
        {
            this.roleManager = roleManager;
            _equipRepo = equipRepo;
            _planRepo = planRepo;
            _userManager = userManager;
            _memberRepo = memberRepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetPlans()
        {
            var model = _planRepo.GetAllPlans();
            return View(model);
        }
        public ViewResult GetEquips()
        {
            var model = _equipRepo.GetAllEquipements();
            return View(model);
        }
        public ViewResult GetPlan(int id)
        {
            ViewBag.userid = _userManager.GetUserId(HttpContext.User);
            ViewBag.planid = id;
            Plan plan = _planRepo.GetPlan(id);
            if (plan == null)
            {
                Response.StatusCode = 404;
                return View("NotFound");
            }
            return View(plan);
        }
        public IActionResult AddMembership(Plan model)
        {
            Plan plan = _planRepo.GetPlan(model.PlanId);
            ViewBag.userid = _userManager.GetUserId(HttpContext.User);
            ViewData["user"] = _userManager.FindByIdAsync(ViewBag.userid).Result;

            Membership newMembership = new Membership
            {
                applicationuser = (ApplicationUser)ViewData["user"],
                PayStatus = false,
                Plan = plan
            };
            _memberRepo.Add(newMembership);
            return RedirectToAction("MyPlan", new {id= newMembership.MembershipId,pid=model.PlanId });
        }
        public ViewResult MyPlan(int id,int pid)
        {
            Membership membership = _memberRepo.GetMembership(id);
            Plan plan = _planRepo.GetPlan(pid);
            ViewBag.pname = plan.PlanName;
            ViewBag.pamt = plan.amount;
            if(membership==null)
            {
                Response.StatusCode = 404;
                return View("NotFound");
            }
            return View(membership);
        }
        public IActionResult MakePay([Bind("MembershipId")] Membership m)
        {
            Membership member = _memberRepo.GetMembership(m.MembershipId);
            member.MembershipId = member.MembershipId;
            member.Plan = member.Plan;
            member.applicationuser = member.applicationuser;
            member.PayStatus = true;

            Membership updateMember = _memberRepo.Update(member);
            return RedirectToAction("GetPlans", "member");
        }
    }
}
