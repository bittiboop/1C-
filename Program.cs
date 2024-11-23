using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _1C_
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number from 1 to 100: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 1 || num > 100)
            {
                Console.WriteLine("The number is not in the range from 1 to 100");
                return;
            }
            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(num);
            }

        }
    }
}
