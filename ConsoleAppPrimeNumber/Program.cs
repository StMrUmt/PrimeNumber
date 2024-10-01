using System;

namespace PrimeNumber
{
    class Program
    {
        static bool IsItaPrimeNumber(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 Numbers");

            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());

            int total = number1 + number2 + number3;

            if (IsItaPrimeNumber(total))
                Console.WriteLine("Is a prime number");

            else
            {
                Console.WriteLine("Is not a prime number");
            };
            Console.ReadLine();
        }

    }
}
// Hello, the purpose of the "Math.Sqrt" code here is to return the square root of the specified number.