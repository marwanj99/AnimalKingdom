using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCsharp
{
    public abstract class Reptile : Animal
    {
        public string Breathing { get; private set; }


        ///////////Constructor////////////
        public Reptile()
        {

        }
        public Reptile(string Name, int Age, string Breathing) : base("default", 1)
        {
            this.Breathing = Breathing;
        }


        public Reptile(string Name, int Age) : base(Name, Age) { }

        public Reptile(int Age) : base("default", Age) { }

        ////////////Method//////////////////
        override public void Breathe()
        {
            Breathing = "Reptiles breath in air through their Beaks and nose and send oxygen to their body";
        }
        override public abstract void Eat(string food);
        public override Mammal Reproduce(Animal otherParent)
        {
            return null;
        }
    }
}
