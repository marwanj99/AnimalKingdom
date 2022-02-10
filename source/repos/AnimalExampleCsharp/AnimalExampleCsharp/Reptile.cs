using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCsharp
{
    public abstract class Reptile : Animal
    {
        public Reptile(String Name, int Age) : base(Name, Age)
        {

        }


        ////////////Method//////////////////
        override public void Breathe() { }
        override public abstract void Eat(string food);
        public override Mammal Reproduce(Animal otherParent)
        {
            return null;
        }
    }
}
