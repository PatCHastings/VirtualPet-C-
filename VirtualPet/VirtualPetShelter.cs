using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VirtualPet
{
    public class VirtualPetShelter
    {
        protected List<VirtualPet> shelterList = new List<VirtualPet>();
        public List<VirtualPet> ShelterList { get; set; }   
        

        public void addPetToShelter(VirtualPet petToAdd)
        {
            shelterList.Add(petToAdd);
        }

        public int shelterPopulation()
        {
            return shelterList.Count;
        }

        public void feedPets()
        {
            foreach (VirtualPet arrayPet in shelterList)
            {
                arrayPet.feed();
            }
        }
        internal void waterPets()
        {
            foreach (VirtualPet arrayPet in shelterList)
            {
                arrayPet.water();
            }
        }

        public void showPetsStatus()
        {
            foreach (VirtualPet arrayPet in shelterList)
            {
                arrayPet.status();
            }
        }

       
    }

}
