using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymManagement.Models
{
    public interface IEquipementRepository
    {
        Equipement GetEquipement(int Id);
        IEnumerable<Equipement> GetAllEquipements();

        Equipement Add(Equipement Equipement);
        Equipement Update(Equipement EquipementChanges);
        Equipement Delete(int Id);
    }
}
