using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    public class Application
    {

        static void Main(string[] args)
        {
            Application newGame = new Application();
            newGame.gameLoop();


        }

        public void gameLoop()
        {
            Console.WriteLine("_________Welcome to Virtual Pet!_________");
            Console.WriteLine("\nPlease enter the name of your pet: \n");
            String petName = Console.ReadLine();
            VirtualPet pet1 = new VirtualPet("Patches", 0, 0, 0);

            Console.WriteLine("Nice to met you, " + petName + "! Your new master awaits.");
            pet1.status();
            Console.WriteLine("\nNow, what would you like to do with your new pet " + petName + "?\n");
            Console.WriteLine("1: Feed it\n2: give it water\n3: Play with it\n4: quit game");
            int prompt = Convert.ToInt32(Console.ReadLine());

            if(prompt == 1)
            {
                pet1.feed();
                pet1.Tick();
                pet1.status();
            }
        }
    }
}
