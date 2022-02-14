using System;

namespace OnlineMovieRentalSoftware
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("who are you?");
            switch (Console.ReadLine() == "Admin") 
            {
                case "Customer":

                break;
                case "Admin":

                break;
                default:
                Console.WriteLine("Please state your customer or Aadmin status");
                break;
            }

            Console.WriteLine("Hello World!");
        }
    }
}
