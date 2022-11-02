using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    public abstract class OrganicPet : VirtualPet
    {

        protected OrganicPet(String name, int hungerLevel, int thirstLevel, int boredomLevel) 
            : base(name, "Organic", hungerLevel, thirstLevel, boredomLevel)
        {
            
              
        }
    }
}
