using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    public abstract class OrganicPet : VirtualPet
    {

        protected String type;

        protected OrganicPet(string type, string petName, int hungerLevel, int thirstLevel, int boredomLevel) : base(petName, hungerLevel, thirstLevel, boredomLevel)
        {
            this.type = type;   
        }
        public String Type { get; set; }
    }
}
