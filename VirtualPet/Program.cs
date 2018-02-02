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

            int userActivities;
            VirtualPet userFridge = new VirtualPet(50, 50, 50, 50);
            do
            {
                Console.WriteLine("Alfred the Elephant");
                //Console.WriteLine("hunger:");
                Console.WriteLine("");
                Console.WriteLine("What would you like to do with your pet?");
                Console.WriteLine("To give the pet food, press 1.");
                Console.WriteLine("To give the pet water, press 2.");
                Console.WriteLine("To have the pet take a nap, press 3.");
                Console.WriteLine("To play with the pet, press 4.");
                Console.WriteLine("To do nothing, press 5");
                Console.WriteLine("");



                userActivities = int.Parse(Console.ReadLine());
                Console.WriteLine(""); ;
            } while (userActivities != 5);
        }
    }
}
