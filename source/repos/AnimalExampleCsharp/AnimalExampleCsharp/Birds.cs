using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCsharp
{
    public abstract class Birds : Animal , Flying 
    {
        /////////Attributes/////////

        public string Breathing { get; private set; }


        ///////////Constructor////////////
        public Birds()
        {

        }
        public Birds(string Name, int Age, string Breathing) : base("default", 1)
        {
            this.Breathing = Breathing;
        }


        public Birds(string Name, int Age) : base(Name, Age) { }

        public Birds(int Age) : base("default", Age) { }

        ////////////Method//////////////////
        override public void Breathe()
        {
            Breathing = "Birds breath in air through their Beaks and nose and send oxygen to their body";
        }

        override public abstract void Eat(string food);
        public override Birds Reproduce(Animal otherParent)
        {
            return null;
        }

        public void takeOff() { }
        public void flight() { }

        public void landing() { }
    }
}
