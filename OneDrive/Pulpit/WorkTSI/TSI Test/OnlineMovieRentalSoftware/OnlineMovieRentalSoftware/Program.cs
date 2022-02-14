using System;

namespace OnlineMovieRentalSoftware
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("who are you?");
            string x = Console.ReadLine();
            switch (x) 
            {
                case "Customer":
                    Console.WriteLine("Welcome user");
                break;
                case "Admin":
                    Console.WriteLine("welcome admin");
                break;
                default:
                Console.WriteLine("Please state your customer or Aadmin status");
                break;
            }

            Console.WriteLine("Hello World!");
        }
    }
}
