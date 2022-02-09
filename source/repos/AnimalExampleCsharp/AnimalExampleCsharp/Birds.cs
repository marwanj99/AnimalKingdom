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


        ////////Constructor///////



        ///////Methods/////////
        override public void Breathe() { }
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
