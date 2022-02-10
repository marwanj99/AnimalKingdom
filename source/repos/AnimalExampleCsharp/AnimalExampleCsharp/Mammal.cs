using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCsharp
{

    public abstract class Mammal : Animal
    {
        ///////////////atributes///////////
        ///
        public string Breathing { get; private set; }


        ///////////Constructor////////////
        public Mammal()
        {

        }
        public Mammal(string Name, int Age, string Breathing) : base("default", 1)
        {
            this.Breathing = Breathing;
        }
        

        public Mammal(string Name, int Age) : base(Name, Age) { }

        public Mammal(int Age) : base( "default", Age) { }


        ////////////Method//////////////////
        override public void Breathe() 
        {
            Breathing =  "Mammals breath in air through their mouth and nose and send oxygen to their body";
        }
        override public abstract void Eat(string food);
        public override Mammal Reproduce(Animal otherParent)
        {
            return null;
        }
    }
}
