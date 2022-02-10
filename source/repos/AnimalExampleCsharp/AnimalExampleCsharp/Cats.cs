using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCsharp
{
    public abstract class Cats : Mammal
    {

        /////////Attributes/////////


        ////////Constructor///////
        public Cats(String Name, int Age) : base(Name, Age)
        { }

        public Cats(int Age) : this("ManBat", Age) { }


        ///////Methods/////////
        public override void Eat(string food)
        {
            throw new NotImplementedException();
        }
    }
}
