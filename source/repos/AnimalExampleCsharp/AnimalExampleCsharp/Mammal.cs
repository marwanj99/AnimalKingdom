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



        ///////////Constructor////////////
        public Mammal(string Name, int Age) : base("default", 1)
        {

        }

        /*public Mammal(string Name, int Age) : base(Name, Age)
        {

        }
        */


        ////////////Method//////////////////
        override public void Breathe() { }
        override public abstract void Eat(string food);
        public override Mammal Reproduce(Animal otherParent)
        {
            return null;
        }
    }
}
