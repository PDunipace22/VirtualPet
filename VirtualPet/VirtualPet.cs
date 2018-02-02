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
        private string mood;

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
        public string Mood
        {
            get { return this.mood; }
            set { this.mood = value; }
        }

        //Constructors- at least 
        public VirtualPet()
        {

        }


        //Methods- at leat 3 including TICK method
        // method for pet's mood
        public string Feed()
        {
            if (IsHungry == false)
            {
                IsHungry = true;
                return "You fed pet.";
            }
            else
            {
                return "pet has already eaten.";
            }
        }
        public string Talk()
        {
            if (IsBored == false)
            {
                IsBored = true;
                return "You just had a conversation with Sam.";
            }
            else
            {
                return "Sam is already talking to itself.";
            }
        }
        public string Sleep()
        {
            if (IsTired == false)
            {
                IsTired = true;
                return "Sam just had a nap.";
            }
            else
            {
                return "Sam already took a nap.";
            }
        }
        public string Health()
        {
            if (IsSick == false)
            {
                IsSick = true;
                return "Sam just got back from the vet.";
            }
            else
            {
                return "Sam already went to the vet.";
            }
        }
        
    }
}