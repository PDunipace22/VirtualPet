using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an interactive console window
            //Prompt user to choose what to do with the virtual pet
            //Call methods on virtual pet object to do what the user wants
            int userChoice;
            VirtualPet bird = new VirtualPet();
            do
            {
                Console.WriteLine("Sam the Mynah Bird");
                Console.WriteLine("");
                Console.WriteLine("How would you like to interact with your bird?");
                Console.WriteLine("1.Feed Sam");
                Console.WriteLine("2.Take Sam to the vet");
                Console.WriteLine("3.Talk to Sam");
                Console.WriteLine("4.Have Sam sleep");
                Console.WriteLine("5.Leave");
                Console.WriteLine("");

                userChoice = int.Parse(Console.ReadLine());
                switch(userChoice)
                {
                    case 1:
                        Console.WriteLine(bird.Feed());
                        break;
                    case 2:
                        Console.WriteLine(bird.Health());
                        break;
                    case 3:
                        Console.WriteLine(bird.Talk());
                        break;
                    default:
                        Console.WriteLine(bird.Sleep());
                        break;
                }

                Console.WriteLine("");
                
            } while (userChoice != 5);
        }
    } 
}
