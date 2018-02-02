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
        private string sleep;
        private string exercise;

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
        public string Sleep
        {
            get { return this.sleep; }
            set { this.sleep = value; }
        }
        public string Exercise
        {
            get { return this.exercise; }
            set { this.exercise = value; }
        }
        //Constructors- at least 1
        //Methods- at leat 3 including TICK method
    }
}
