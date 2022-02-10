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

        public string Name { get; private set;  }
        public int Age { get; private set; }
        public string Type { get; set; }




        ////////////////////Constructors////////////////////////////
        public Animal(String Name, int Age)
        {
            this.Name  = Name;
            this.Age = Age;
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
            return Age;
        }

        public void SetAgeOldWay(int newAge)
        {
            Age = newAge;
        }

        public string GetType()
        {
            return Type;
        }

        public void SetType(string TypeOfAnimal) 
        {
            Type = TypeOfAnimal;
        }
   

    }
}
