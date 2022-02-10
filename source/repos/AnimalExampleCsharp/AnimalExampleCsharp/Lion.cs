using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCsharp
{
    public class Lion : Cats
    {
        /////////Attributes/////////


        ////////Constructor///////
        public Lion(String Name, int Age) : base(Name, Age)
        { }

        public Lion(int Age) : this("ManBat", Age) { }


        ///////Methods/////////



    }
}
