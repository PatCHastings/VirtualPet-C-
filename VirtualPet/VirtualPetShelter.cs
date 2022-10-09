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


    }

}
