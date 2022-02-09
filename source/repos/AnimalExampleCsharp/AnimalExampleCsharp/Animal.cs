using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCsharp
{
    public abstract class Animal
    {
        //////////////////Attributes/////////////////////////

        public string name { get; private set;  }
        public int age { get; private set; }
        public int Age { get; private set; }




        ////////////////////Constructors////////////////////////////
        public Animal()
            : base()
        {
            age = 1;
            name = "bob";
        }



        ///////////////////Methods//////////////////////////////
        public abstract void Eat(string food);

        public void Sleep(int lengthOfSleep)
        {
            //sleep method
        }
        public abstract Animal Reproduce(Animal otherParent);
        public abstract void Breathe();
        public string Poo()
        {
            Age = 16;
            return "I have logged this";
        }
        public void Die()
        {
            //add die method
        }

        public int GetAgeOldWay()
        {
            return age;
        }

        public void SetAgeOldWay(int newAge)
        {
            age = newAge;
        }


        public int getAge { get; private set; }
   

    }
}
