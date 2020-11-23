using System;

namespace Odd_Even
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Get user input
            Console.WriteLine("Enter a whole number between 1 and 1000.");
            string userNumber = Console.ReadLine();
            //Convert string to int
            int userInt = Int32.Parse(userNumber);

            int oddOrEven = (userInt % 2);


            while (userInt < 1 || userInt > 1000)
            {
                //TODO check for other invalid inputs
                Console.WriteLine("Invalid input. Enter a whole number between 1 and 1000.");
                userNumber = Console.ReadLine();
                userInt = Int32.Parse(userNumber);
                oddOrEven = (userInt % 2);
            }

            if (oddOrEven == 1)
            {
                Console.WriteLine($"You entered " + userNumber + ". It is an odd number.");
            }
            else Console.WriteLine($"You entered " + userNumber + ". It is an even number.");

        }
    }
}
