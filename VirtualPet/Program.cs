using System;

namespace VirtualPet
{
    public class VirtualPet
    {
        protected String petName;
        protected int hungerLevel;
        protected int thirstLevel;
        protected int boredomLevel;

        public VirtualPet(string petName, int hungerLevel, int thirstLevel, int boredomLevel)
        {
            this.petName = petName;
            this.hungerLevel = hungerLevel;
            this.thirstLevel = thirstLevel;
            this.boredomLevel = boredomLevel;
        }
        
        public String PetName { get; set; }
        public int HungerLevel { get; set; }
        public int ThirstLevel { get; set; }
        public int BoredomLevel { get; set; }


        public void feed()
        {
            hungerLevel = hungerLevel - 2;
            if (hungerLevel < 0)
            {
                hungerLevel = 0;
            }
        }
        public void water()
        {
            thirstLevel = thirstLevel - 2;
            if (thirstLevel < 0)
            {
                thirstLevel = 0;
            }
        }
        public void play()
        {
            boredomLevel = boredomLevel - 2;
            if (boredomLevel < 0)
            {
                boredomLevel = 0;
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
            Console.WriteLine("\nHunger: " + hungerLevel + " Thirst: " + thirstLevel + " boredom: " + boredomLevel);
        }
    }
}