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
        private bool isHungry;
        private bool isBored;
        private bool isTired;
        private bool isSick;

        //Properties-at least 3
        public bool IsHungry
        {
            get { return this.isHungry; }
            set { this.isHungry = value; }
        }
        public bool IsBored
        {
            get { return this.isBored; }
            set { this.isBored = value; }
        }
        public bool IsTired
        {
            get { return this.isTired; }
            set { this.isTired = value; }
        }
        public bool IsSick
        {
            get { return this.isSick; }
            set { this.isSick = value; }
        }

        //Constructors- at least 1
        public VirtualPet()
        {

        }
        public VirtualPet(bool isHungry, bool isBored, bool isTired, bool isSick)
        {
            this.isHungry = isHungry;
            this.isBored = isBored;
            this.isTired = isTired;
            this.isSick = isSick;
        }

        //Methods- at leat 3 including TICK method
        public string Feed()
        {
            string message = string.Empty;
            if (IsHungry)
            {
                message = "Sam wants a cracker.";
            }
            else
            {
                message = "Sam is not hungry right now.";
            }
            Tick();
            IsHungry = false;
            return message;
        }
        public string Talk()
        {
            string message = string.Empty;
            if (IsBored)
            {
                message = "Sam wishes you to have a conversation with you.";
            }
            else
            {
                message = "Sam is already talking to itself.";
            }
            IsBored = false;
            return message;
        }
        public string Sleep()
        {
            string message = string.Empty;
            if (IsTired)
            {
                message = "Sam needs a nap.";
            }
            else
            {
                message = "Sam already took a nap.";
            }
            Tick();
            IsTired = false;
            return message;
        }
        public string Health()
        {
            string message = string.Empty;
            if (IsSick)
            {
                message = "Time to take Sam to the vet.";
            }
            else
            {
                message = "Sam already went to the vet.";
            }
            Tick();
            IsSick = false;
            return message;
        }
        public void Tick()
        {
            Random careOptions = new Random();
            IsHungry = (careOptions.Next(1,5) == 3 || IsHungry);
            IsBored = (careOptions.Next(1,3)  == 1  || IsBored);
            IsTired = (careOptions.Next(1, 8) == 7 || IsTired);
            IsSick = (careOptions.Next(1, 50)  == 25 || IsSick);
        }
    }
}