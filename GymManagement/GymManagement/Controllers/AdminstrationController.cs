using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymManagement.Models;
using GymManagement.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GymManagement.Controllers
{
    [Authorize(Roles="Admin")]
    public class AdminstrationController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IEquipementRepository _equipRepo;
        private readonly IPlanRepository _planRepo;
        public AdminstrationController(RoleManager<IdentityRole> roleManager,IEquipementRepository equipRepo,IPlanRepository planRepo)
        {
            this.roleManager = roleManager;
            _equipRepo = equipRepo;
            _planRepo = planRepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult GetEquips()
        {
            var model = _equipRepo.GetAllEquipements();
            return View(model);
        }
        [HttpGet]
        public ViewResult CreateEquip()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateEquip(Equipement model)
        {
            if(ModelState.IsValid)
            {
                Equipement newEquipement = new Equipement
                {
                    EquipementId=model.EquipementId,
                    eqname=model.eqname,
                    qty=model.qty,
                    price=model.price,
                    date=model.date
                };
                _equipRepo.Add(newEquipement);
                return RedirectToAction("GetEquips", "adminstration");
            }
            return View();
        }
        [HttpGet]
        public IActionResult DeleteEquip(int id)
        {
            Equipement equip = _equipRepo.GetEquipement(id);
            if(equip==null)
            {
                return View("NotFound");
            }
            return View(equip);
        }
        [HttpPost,ActionName("DeleteEquip")]
        public  IActionResult DeleteConfirm(int id)
        {
            var equip = _equipRepo.GetEquipement(id);
            _equipRepo.Delete(equip.EquipementId);
            return RedirectToAction("GetEquips");
        }
        [HttpGet]
        public ViewResult EditEquip(int id)
        {
            Equipement equip = _equipRepo.GetEquipement(id);
            Equipement newEquip = new Equipement
            {
                EquipementId = equip.EquipementId,
                eqname = equip.eqname,
                qty = equip.qty,
                price = equip.price,
                date = equip.date
            };
            return View(newEquip);
        }
        [HttpPost]
        public IActionResult EditEquip(Equipement model)
        {
            if(ModelState.IsValid)
            {
                Equipement equip = _equipRepo.GetEquipement(model.EquipementId);
                equip.EquipementId = model.EquipementId;
                equip.eqname = model.eqname;
                equip.qty = model.qty;
                equip.price = model.price;
                equip.date = model.date;

                Equipement updateEquip = _equipRepo.Update(equip);
                return RedirectToAction("GetEquips");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult CreatePlan()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePlan(Plan model)
        {
            if (ModelState.IsValid)
            {
                Plan newPlan = new Plan
                {
                    PlanId = model.PlanId,
                    PlanName = model.PlanName,
                    details = model.details,
                    amount = model.amount
                };
                _planRepo.Add(newPlan);
                return RedirectToAction("GetPlans", "adminstration");
            }
            return View();
        }
        public IActionResult GetPlans()
        {
            var model = _planRepo.GetAllPlans();
            return View(model);
        }
        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRole model)
        {
            if(ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.RoleName
                };
                IdentityResult result = await roleManager.CreateAsync(identityRole);
                if(result.Succeeded)
                {
                    return RedirectToAction("index", "home");
                }
                foreach(IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }
    }
}
