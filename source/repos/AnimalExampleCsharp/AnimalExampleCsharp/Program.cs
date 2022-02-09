using System;

namespace AnimalExampleCsharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Bat myBat = new Bat();

            Console.WriteLine(myBat.ToString());
            Console.WriteLine(myBat.GetAgeOldWay);
            Console.WriteLine(myBat.Poo());
        }
    }
}
