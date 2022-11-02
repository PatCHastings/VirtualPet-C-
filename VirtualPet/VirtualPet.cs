using System;

namespace VirtualPet
{
    public abstract class VirtualPet
    {
        protected String petName;
        protected String petType;
        protected int hungerLevel;
        protected int thirstLevel;
        protected int boredomLevel;
        protected int healthBar; 
        protected int attackPower;
        protected int defense;

        public VirtualPet(String name, String type, int hungerLevel, int thirstLevel, int boredomLevel, int healthBar, int attackPower, int defense)
        {
            this.petName = name;
            this.petType = type;
            this.hungerLevel = hungerLevel;
            this.thirstLevel = thirstLevel;
            this.boredomLevel = boredomLevel;
            this.healthBar = healthBar;
            this.attackPower = attackPower;
            this.defense = defense;
        }
        
        public String Name { get; set; }
        public String Type { get; set; }
        public int HungerLevel { get; set; }
        public int ThirstLevel { get; set; }
        public int BoredomLevel { get; set; }


        public void feed()
        {
            hungerLevel = hungerLevel - 4;
            if (hungerLevel < 0)
            {
                hungerLevel = -2;
            }
        }
        public void water()
        {
            thirstLevel = thirstLevel - 4;
            if (thirstLevel < 0)
            {
                thirstLevel = -2;
            }
        }
        public void play()
        {
            boredomLevel = boredomLevel - 4;
            if (boredomLevel < 0)
            {
                boredomLevel = -2;
            }
        }

        public void Tick()
        {
            hungerLevel += 2;
            thirstLevel += 2;
            boredomLevel += 2;
        }

        public void status()
        {
            Console.WriteLine(petName + ": " + "Hunger: " + hungerLevel + " Thirst: " + thirstLevel + " boredom: " + boredomLevel);
            if (hungerLevel >= 10)
            {
                Console.WriteLine(petName + " is about to starve! You better Feed it" +
                    "!");
            }
            if (thirstLevel >= 10)
            {
                Console.WriteLine(petName + " is about to dehydrate! get it some water!");
            }
            if (boredomLevel >= 10)
            {
                Console.WriteLine(petName + " is about to run away! You better play with it!");
            }
            if(hungerLevel > 12)
            {
                Console.WriteLine("RIP: " + petName + " died of starvation..");
                VirtualPet.gameOver();
            }
            if (hungerLevel > 12)
            {
                Console.WriteLine("I am sorry, " + petName + " died of dehydration..");
                VirtualPet.gameOver();
            }
            if (hungerLevel > 12)
            {
                Console.WriteLine("uh oh, " + petName + " ran away and found a better master..");
                VirtualPet.gameOver();
            }

        }

        public static void gameOver()
        {
            Console.WriteLine("\n_____!!!!GAME OVER!!!!!_____\n");
            Environment.Exit(0);
        }
    }
}