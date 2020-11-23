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


            while (oddOrEven == 1 || oddOrEven == 0)
            {
                //TODO check for other invalid inputs
                if (userInt < 1 || userInt > 1000)
                {
                    Console.WriteLine("Invalid input. Enter a whole number between 1 and 1000.");
                    userNumber = Console.ReadLine();
                    oddOrEven = (userInt % 2);
                }
                else if (oddOrEven == 1)
                {
                    Console.WriteLine($"You entered " + userNumber + ". It is an odd number.");
                }
                else Console.WriteLine($"You entered " + userNumber + ". It is an even number.");
            }
        }
    }
}
