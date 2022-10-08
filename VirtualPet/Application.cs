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
            VirtualPet pet1 = new VirtualPet(petName, 0, 0, 0);

            Console.WriteLine("Nice to met you, " + petName + "! Your new master awaits.");
            bool gameOn = true;
            pet1.status();
            while (gameOn == true)
            {       
                Console.WriteLine("\nNow, what would you like to do with your pet " + petName + "?\n");
                Console.WriteLine("1: Feed it\n2: give it water\n3: Play with it\n4: new game\n5: quit");
                int prompt = int.Parse(Console.ReadLine());            
            
                if (prompt == 1)
                {
                    pet1.feed();
                    pet1.Tick();
                    pet1.status();
                    
                }
                else if (prompt == 2)
                {
                    pet1.water();
                    pet1.Tick();
                    pet1.status();
                    
                }
                else if (prompt == 3)
                {
                    pet1.play();
                    pet1.Tick();
                    pet1.status();
                    
                }
                else if (prompt == 4)
                {
                    Console.WriteLine("Are you sure? All unsaved progress will be lost..\n(enter y if yes, enter n if not)\n");
                    String promptNewGame = Console.ReadLine();
                    if (promptNewGame.Equals("y"))
                    {
                        gameLoop();
                    }
                    else if (promptNewGame.Equals("n"))
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("that is not what I asked..");
                    }
                    
                }
                else if (prompt == 5)
                {
                    Console.WriteLine("Are you sure? All unsaved progress will be lost..\n(enter y if yes, enter n if not)\n");
                    String promptNewGame = Console.ReadLine();
                    if (promptNewGame.Equals("y"))
                    {
                        Environment.Exit(0);
                    }
                    else if (promptNewGame.Equals("n"))
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("that is not what I asked..");
                    }    
                }
                else
                {
                    Console.WriteLine("I'm sorry, I didn't understand.. Please clarify your choice by selecting an option 1 through 4");
                    continue;
                }
            }           
        }
    }
}
