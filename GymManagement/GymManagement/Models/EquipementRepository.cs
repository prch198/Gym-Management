using GymManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymManagement.Models
{
    public class EquipementRepository : IEquipementRepository
    {
        private readonly ApplicationDbContext context;
        public EquipementRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public Equipement Add(Equipement Equipement)
        {

            context.Equipements.Add(Equipement);
            context.SaveChanges();
            return Equipement;
        }

        public Equipement Delete(int Id)
        {
            Equipement equipement = context.Equipements.Find(Id);
            if (equipement != null)
            {
                context.Equipements.Remove(equipement);
                context.SaveChanges();
            }
            return equipement;
        }

        public IEnumerable<Equipement> GetAllEquipements()
        {
            return context.Equipements;
        }

        public Equipement GetEquipement(int Id)
        {
            return context.Equipements.Find(Id);
        }

        public Equipement Update(Equipement EquipementChanges)
        {
            var equipement = context.Equipements.Attach(EquipementChanges);
            equipement.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return EquipementChanges;
        }
    }
}
