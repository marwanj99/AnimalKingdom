using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCsharp
{
    public class Colugo : Mammal, Flying 
    {
        ///////////////Attributes///////////


        //////////////Constructor//////////
        public Colugo(String Name, int Age) : base(Name, Age)
        { }

        public Colugo(int Age) : this("ManBat", Age) { }

        ////////////Methods///////////////

        public override void Eat(string food)
        {
            throw new NotImplementedException();
        }

        public void takeOff() { }

        public void flight() { }

        public void landing() { }
    }
}
