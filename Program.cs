using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _1C_
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter first num: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second num: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 < num2)
            {
                Console.WriteLine("Result: ");
                for (int i = num1; i <= num2; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine("The first number must be less than the second number");
            }
        }
    }
}
