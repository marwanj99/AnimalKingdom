using System;

namespace AnimalExampleCsharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Bat myBat = new Bat("BatMan",17);
            Console.WriteLine(myBat.ToString());
            Console.WriteLine(myBat.Poo());
            myBat.Flight();
            Console.WriteLine("I am " + myBat.Name);
            Console.WriteLine(myBat, Age);
            Bat batMy = new Bat(17);
            Console.WriteLine(batMy.Name);
        }
    }
}
