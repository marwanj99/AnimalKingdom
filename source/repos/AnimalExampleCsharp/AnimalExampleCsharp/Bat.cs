using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCsharp
{
    public class Bat : Mammal, Flying
    {
        //////////////////attributes////////////
        ///



        ///////////////constructors///////////////
        public Bat(String Name, int Age) : base(Name, Age)
        { }

        public Bat(int Age) : this("ManBat", Age) { }

        //public Bat() : base() { }

        ////////////Methods//////////////////////
        public override void Eat(string food)
        {
            //implement later
        }

        public void takeOff(){}

        public void flight() { }

        public void landing() { }
    }
}
