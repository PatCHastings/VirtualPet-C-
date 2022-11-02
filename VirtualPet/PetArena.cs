using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    public class PetArena 
    {
        protected ArrayList<VirtualPet> combatants = new ArrayList<VirtualPet>(); 
    }
        public ArrayList<VirtualPet> Combatants { get; set; }
    //public PetArena()
    //{
    //}



    public void addCombatantToArena(VirtualPet addCombatant)
    {
        combatants.Add(addCombatant);
    }

    public void defeatedPet(string remove)
    {
        foreach (VirtualPet arrayCombatant in combatants)
        {

        }
    }

    public void attackDogs()
    {
        foreach (VirtualPet arrayCombatants in combatants)
        {
            if (arrayCombatants.Type.Equals("OrganicCat"))
            {
                Console.WriteLine("wtf");
            }
        }
    }
}
