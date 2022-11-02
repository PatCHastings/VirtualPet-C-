using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    public class OrganicCat : VirtualPet
    {
        
        protected int litterboxFilthLevel;

        public OrganicCat(string type, int litterboxFilthLevel, String petName, int hungerLevel, int thirstLevel, int boredomLevel) 
            : base(name, "OrganicCat")
        {
            

            this.litterboxFilthLevel = litterboxFilthLevel;
            this.healthBar = healthBar;
            this.attackPower = attackPower;
            this.defense = defense;
            

        }
        public String PetType { get; set; }
        public int LitterboxFilthLevel { get; set; }
        public int HealthBar { get; set; }
        public int AttackPower { get; set; }
        public int Defense { get; set; }
        
      //public static PetType()
      //  {
      //      Type = "organic_Cat";
      //  }
       
    
    }
}

