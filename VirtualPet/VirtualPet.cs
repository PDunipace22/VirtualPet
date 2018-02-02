using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    public class VirtualPet
    {
        //Fields-at least 3
        private int hunger;
        private int thirst;
        private int sleep;
        private int exercise;

        //Properties-at least 3
        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }
        public int Thirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }
        public int Sleep
        {
            get { return this.sleep; }
            set { this.sleep = value; }
        }
        public int Exercise
        {
            get { return this.exercise; }
            set { this.exercise = value; }
        }

        //Constructors- at least 
        public VirtualPet()
        {

        }
        public VirtualPet(int hunger, int thirst, int sleep, int exercise)
        {
            this.hunger = hunger;
            this.thirst = thirst;
            this.sleep = sleep;
            this.exercise = exercise;
        }

        //Methods- at leat 3 including TICK method
    }
}
