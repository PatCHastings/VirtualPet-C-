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
        protected List<VirtualPet> combatants = new List<VirtualPet>();

        public List<VirtualPet> Combatants { get; set; }


        //public PetArena()
        //{
        //}

        public int arenaPopulation()
        {
            return combatants.Count;
        }

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
}
