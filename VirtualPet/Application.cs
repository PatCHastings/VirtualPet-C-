using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
            VirtualPet pet1 = new OrganicCat("Organic", 0, petName, 0, 0, 0);

            Console.WriteLine("Nice to met you, " + petName + "! Your new master awaits.");
            bool gameOn = true;
            pet1.status();
            while (gameOn == true)
            {       
                Console.WriteLine("\nNow, what would you like to do with your pet " + petName + "?\n");
                Console.WriteLine("1: Feed it\n2: give it water\n3: Play with it\n4: Enter the Pet Shelter\n5: new game\n6: quit");
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
                    Console.WriteLine("Okay then, right this way");  
                    gameLoopShelter();
                }
                else if (prompt == 5)
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
                else if (prompt == 6)
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

        public void gameLoopShelter()
        {
            Console.WriteLine("Welcome to the Pet Shelter");
            VirtualPetShelter petShelter = new VirtualPetShelter();
            PetArena petArena = new PetArena();
            bool quitGame = false;

            while (!quitGame)
            {
                Console.WriteLine("\nWhat would you like to do here?\n" +
                    "\n1: Add a Pet to the Shelter" +
                    "\n2: Feed pets" +
                    "\n3: Water pets" +
                    "\n4: play with pets" +
                    "\n5: Remove a pet" +
                    "\n6: Enter the Arena!" +
                    "\n7: go back");
                int prompt = int.Parse(Console.ReadLine());
                if (prompt == 1)
                {
                    Console.WriteLine("\nWould you like to add a Cat or a Dog?\n" +
                        "\n1: add Cat" +
                        "\n2: add Dog");
                    int promptNested = int.Parse(Console.ReadLine());
                    if(promptNested==1)
                    {
                        Console.WriteLine("Enter your new cat's name:");
                        String typeName = Console.ReadLine();
                        VirtualPet petTypeAdded = new OrganicCat("OrganicCat", 0, typeName, 0, 0, 0);
                        petShelter.addPetToShelter(petTypeAdded);
                        petShelter.shelterPopulation();
                    }
                    else if(promptNested==2)
                    {
                        Console.WriteLine("Enter your new dog's name:");
                        String typeName = Console.ReadLine();
                        VirtualPet petTypeAdded = new OrganicDog("OrganicDog", 0, typeName, 0, 0, 0);
                        petShelter.addPetToShelter(petTypeAdded);
                    }
                    else
                    {
                        Console.WriteLine("I dont understand, please choose 1 or 2..");
                        continue; 
                    }
                }
                else if (prompt == 2)
                {
                    petShelter.feedPets();                
                    petShelter.showPetsStatus();
                    petShelter.tickPets();
                }
                else if (prompt == 3)
                {
                    petShelter.waterPets();
                    petShelter.showPetsStatus();
                    petShelter.tickPets();
                }
                else if (prompt == 4)
                {
                    petShelter.playPets();
                    petShelter.showPetsStatus();
                    petShelter.tickPets();
                }
                else if (prompt == 5)
                {
                    Console.WriteLine("Please type the name of the pet you wish to get rid of: ");
                    String name = Console.ReadLine();
                    petShelter.removePet(name);
                }
                else if (prompt == 6)
                {
                    gameLoopArena();
                }
                else if (prompt == 7)
                {
                    quitGame = true;
                }
            }
        }
    }
}
