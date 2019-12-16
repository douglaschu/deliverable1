using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare and initialize the vacationType and groupSize variables variable
            string groupSize, vacationType;
            Console.WriteLine("Hello, and welcome to TRAVEL-MATIC 3000.");
            Console.WriteLine("Choosing the vacation of your dreams has never been easier with TRAVEL-MATIC 3000! ");
            Console.WriteLine($"What kind of trip would you like to go on: musical, tropical, or adventurous? ");
            vacationType = Console.ReadLine();
        //declare and initialize groupSize variable
            Console.Write("How many people, including yourself, will be in your group? ");
            groupSize = Console.ReadLine();
            
            if (vacationType == ("musical"))
                
                Console.Write($"For the live {vacationType} experience of a lifetime, you should go to New Orleans ");

            else if (vacationType == ("tropical"))

                Console.Write($"For a {vacationType} getaway, you should take a beach vacation to Mexico ");
           
            else if (vacationType == "adventurous")

                Console.Write($"For our {vacationType} types, you should go whitewater rafting down the Grand Canyon ");

            int i = int.Parse(groupSize);

            if (i >= 0)
            {
                Console.WriteLine("and you should fly first class. ");
            }
            else if (i >= 3 && i <= 5)
            {
                Console.WriteLine("and you should take a helicopter to get there. ");
            }

            else if (i >= 6)
            {
                Console.WriteLine("and you should charter a flight to get there. ");
            }

            Console.WriteLine();
            Console.WriteLine("Thank you for choosing TRAVEL-MATIC 3000.");
            Console.WriteLine();
                      
        }
    }
}
