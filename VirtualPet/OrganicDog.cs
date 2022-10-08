using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    public class OrganicDog : VirtualPet
    {
        protected String type;
        protected int cageFilthLevel;

        public OrganicDog(string type, int cageFilthLevel, string petName, int hungerLevel, int thirstLevel, int boredomLevel) : base(petName, hungerLevel, thirstLevel, boredomLevel)
        {
            this.type = type;
            this.cageFilthLevel = cageFilthLevel;
        }
    }
}
