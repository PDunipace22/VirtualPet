using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static Random responseOption = new Random();
        static string[] hungryResponses = { "Sam wants a cracker.", "Sam wants a gummy bear.", "Sam wants a bowl of soup." };
        static string[] boredResponses = { "Pretty boy! Pretty boy!", "Let's have a party.", "Where's Bob?"};
    
        static void Main(string[] args)
        {
            //create an interactive console window
            //Prompt user to choose what to do with the virtual pet
            //Call methods on virtual pet object to do what the user wants
            int userChoice;

            string lastResponse = string.Empty;
            VirtualPet bird = new VirtualPet(false, true, true, false);
            do
            {
                Console.Clear();
                Console.WriteLine("Sam the Mynah Bird");
                ShowSam(bird);
                Status(bird);
                Console.WriteLine(string.Empty);
                Menu();
                Console.WriteLine(string.Empty);
                Console.WriteLine(lastResponse);
                userChoice = int.Parse(Console.ReadLine());
                lastResponse = string.Empty;
                switch (userChoice)
                {
                    case 1:
                        lastResponse = bird.Feed();
                        break;
                    case 2:
                        lastResponse = bird.Health();
                        break;
                    case 3:
                        lastResponse = bird.Talk();
                        break;
                    case 4:
                        lastResponse = bird.Sleep();
                        break;
                    default:
                        bird.Tick();
                        break;
                }
                Console.WriteLine("");
            } while (userChoice != 6);
        }

        static void Status(VirtualPet bird)
        {
            if (bird.IsHungry)
            {
                Console.WriteLine("Sam is hungry.");
            }
            if(bird.IsSick)
            {
                Console.WriteLine("Sam is not feeling well.");
            }
            if (bird.IsBored)
            {
                Console.WriteLine("Sam wishes to talk.");
            }
            if(bird.IsTired)
            {
                Console.WriteLine("Sam needs a nap.");
            }
            if(!bird.IsHungry && !bird.IsSick && !bird.IsBored && !bird.IsTired)
            {
                Console.WriteLine("Sam is happy.");
            }
         
        }

        static void Menu()
        {
            Console.WriteLine("How would you like to interact with your bird?");
            Console.WriteLine("1.Feed Sam");
            Console.WriteLine("2.Take Sam to the vet");
            Console.WriteLine("3.Talk to Sam");
            Console.WriteLine("4.Have Sam sleep");
            Console.WriteLine("5.Tick");
            Console.WriteLine("6.Leave");
        }

        static void ShowSam(VirtualPet bird)
        {
            if(bird.IsSick)
            {
                SickSam();
            }
            else if (bird.IsHungry)
            {
                HungrySam();
            }
            else if (bird.IsTired)
            {
                SleepySam();
            }
            else if (bird.IsBored)
            {
                BoredSam();
            }
            else
            {
                HappySam();
            }
        }

        static void HappySam()
        {
            Console.WriteLine("  ___");
            Console.WriteLine(" ('v')");
            Console.WriteLine("((   ))");
            Console.WriteLine("  ^ ^");
        }

        static void HungrySam()
        {
            Console.WriteLine("  ___");
            Console.WriteLine(" ('v') < " + hungryResponses[responseOption.Next(1,4)]);
            Console.WriteLine("((   ))");
            Console.WriteLine("  ^ ^");
        }

        static void SleepySam()
        {
            Console.WriteLine("  ___");
            Console.WriteLine(" (`v`) zzzzz...");
            Console.WriteLine("((   ))");
            Console.WriteLine("  ^ ^");
        }

        static void SickSam()
        {
            Console.WriteLine("  ___");
            Console.WriteLine(" (~v~) ah-chew");
            Console.WriteLine("((   ))");
            Console.WriteLine("  ^ ^");
        }

        static void BoredSam()
        {
            Console.WriteLine("  ___");
            Console.WriteLine(" ('v') <" + boredResponses[responseOption.Next(1,4)]);
            Console.WriteLine("((   ))");
            Console.WriteLine("  ^ ^");
        }
    } 
} 