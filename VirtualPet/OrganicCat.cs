using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    public class OrganicCat : VirtualPet
    {
        protected String type;
        protected int litterboxFilthLevel;

        public OrganicCat(string type, int litterboxFilthLevel, string petName, int hungerLevel, int thirstLevel, int boredomLevel) : base(petName, hungerLevel, thirstLevel, boredomLevel)
        {
            this.type = type;
            this.litterboxFilthLevel = litterboxFilthLevel;
        }
    }
}
