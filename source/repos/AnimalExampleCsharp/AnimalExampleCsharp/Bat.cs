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
        public Bat(String Name, int Age, string Breathing) : base(Name, Age, Breathing)
        { }

        public Bat(int Age, string Breathing) : this("ManBat", Age, Breathing) { }

        //public Bat() : base() { }

        ////////////Methods//////////////////////
        public override void Eat(string food)
        {
            //implement later
        }

        public void takeOff() { }

        public void flight() { }

        public void landing() { }
    }
}
