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
        public void removePet()
        {
            String namePrompt = Console.ReadLine();
            foreach (VirtualPet arrayPet in shelterList)      
            {
                if (arrayPet.Equals(namePrompt))
                {
                    shelterList.Remove(arrayPet);
                    break;
                }
                else
                {
                    Console.WriteLine("pet not found..");
                }
            }
        }
        //do a method that removes from List, then call that in removePet


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
        public void waterPets()
        {
            foreach (VirtualPet arrayPet in shelterList)
            {
                arrayPet.water();
            }
        }
        public void playPets()
        {
            foreach (VirtualPet arrayPet in shelterList)
            {
                arrayPet.play();
            }
        }

        public void showPetsStatus()
        {
            foreach (VirtualPet arrayPet in shelterList)
            {
                arrayPet.status();
            }
        }
        public void tickPets()
        {
            foreach (VirtualPet arrayPet in shelterList)
            {
                arrayPet.Tick();
            }
        }     
    }
}
